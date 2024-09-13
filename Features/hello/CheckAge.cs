using FastEndpoints;
using FluentValidation;

namespace StudyPlannerSoft.Features.hello;


internal record AgeRequest(int Age);
internal record AgeResponse(bool isAdult);

internal sealed class CheckAge: Endpoint<AgeRequest, AgeResponse>
{
    
    public override void Configure()
    {
        Post("/hello");
        AllowAnonymous();
        Validator<AgeValidator>();
    }
    public override async Task HandleAsync(AgeRequest req, CancellationToken ct)
    {
        await SendAsync(new AgeResponse(true), 200, ct);
    }
    
}

internal class AgeValidator : Validator<AgeRequest>
{
    public AgeValidator()
    {
        RuleFor(x => x.Age)
            .NotEmpty()
            .GreaterThanOrEqualTo(18)
            .WithMessage("Age must be greater than 18");
    }
}
