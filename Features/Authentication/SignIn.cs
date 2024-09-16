using FastEndpoints;

namespace StudyPlannerSoft.Features.Authentication;

public class SingInRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

internal sealed class SignIn : Endpoint<SingInRequest>
{
    public override void Configure()
    {
        Post("/authentication/signin");
        AllowAnonymous();
    }

    public override Task HandleAsync(SingInRequest req, CancellationToken ct)
    {
        return base.HandleAsync(req, ct);
    }
}