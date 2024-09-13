using FastEndpoints;

namespace StudyPlannerSoft.Features.hello;


internal record HelloResponse(string Message);


internal sealed class GetHelloEndpoint: EndpointWithoutRequest<HelloResponse>
{
    
    public override void Configure()
    {
        Get("/hello");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync(new HelloResponse("Hello"), 200, ct);
    }

  
}