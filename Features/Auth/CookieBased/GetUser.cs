namespace StudyPlannerSoft.Features.Auth.CookieBased;

using System.Security.Claims;
using FastEndpoints;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

public class GetUserResponse
{
    public string Email { get; set; }
    public string UserName { get; set; }
    public string UserId { get; set; }
    public List<string> Roles { get; set; }
}

public class GetUser: EndpointWithoutRequest<GetUserResponse>
{
    
    
    private readonly UserManager<MyUser> _userManager;

    public GetUser(UserManager<MyUser> userManager)
    {
        _userManager = userManager;
    }
    
    public override void Configure()
    {
        Get("/auth/user");
        AuthSchemes(CookieAuthenticationDefaults.AuthenticationScheme);
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
        {
            Console.WriteLine("User ID not found in claims."); // Debugging
            await SendUnauthorizedAsync(ct);
            return;
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            Console.WriteLine($"User not found with ID: {userId}"); // Debugging
            await SendNotFoundAsync(ct);
            return;
        }

        var roles = await _userManager.GetRolesAsync(user);

        var response = new GetUserResponse
        {
            Email = user.Email,
            UserName = user.UserName,
            UserId = user.Id,
            Roles = roles.ToList()
        };

        await SendOkAsync(response, ct);
    }
}