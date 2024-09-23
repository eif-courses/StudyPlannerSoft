using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace StudyPlannerSoft.Features.Auth.CookieBased;

internal sealed class LogOut: EndpointWithoutRequest
{
    public override void Configure()
    {
        Post("/auth/logout");
        AuthSchemes(CookieAuthenticationDefaults.AuthenticationScheme);
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await CookieAuth.SignOutAsync();
        await SendOkAsync(ct);
    }
}