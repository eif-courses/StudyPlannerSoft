using System.Security.Claims;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Identity;

namespace StudyPlannerSoft.Features.Auth.CookieBased;

public class SingInRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

internal sealed class LogIn : Endpoint<SingInRequest>
{
    private readonly UserManager<MyUser> _userManager;
    private readonly SignInManager<MyUser> _signInManager;


    public LogIn(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public override void Configure()
    {
        Post("/auth/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(SingInRequest req, CancellationToken ct)
    {
        var user = await _userManager.FindByEmailAsync(req.Username);
        if (user == null)
        {
            await SendUnauthorizedAsync(ct);
            return;
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, req.Password, lockoutOnFailure: false);
        if (!result.Succeeded)
        {
            await SendUnauthorizedAsync(ct);
            return;
        }
    
        var roles = await _userManager.GetRolesAsync(user);
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, user.UserName),
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.NameIdentifier, user.Id)
        };

        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        // Sign in the user and log the operation
        await CookieAuth.SignInAsync(u =>
        {
            u.Claims.AddRange(claims);
            u.Roles.AddRange(roles);
        });
        
        
        // Log successful login
        Console.WriteLine($"User {user.UserName} signed in successfully.");

        await SendOkAsync(ct);
    }

}