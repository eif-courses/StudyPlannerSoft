using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.Subjects;

public class ListAllSubjects : EndpointWithoutRequest<List<Subject>>
{

    private readonly MyDatabaseContext _context;

    public ListAllSubjects(MyDatabaseContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Get("/subjects");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var subjects = await _context.Subjects.ToListAsync(ct);
        await SendAsync(subjects, 200, ct);
    }
}