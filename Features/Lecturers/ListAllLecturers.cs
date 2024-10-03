using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;

namespace StudyPlannerSoft.Features.Lecturers;

public class ListAllLecturers: EndpointWithoutRequest
{
    private readonly MyDatabaseContext _context;

    public ListAllLecturers(MyDatabaseContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Get("/lecturers");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        var response = await _context.Lecturers.ToListAsync(ct);
        
        await SendAsync(response, 200, ct);
    }

    
}