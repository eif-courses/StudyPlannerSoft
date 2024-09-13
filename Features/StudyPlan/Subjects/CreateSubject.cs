using FastEndpoints;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.StudyPlan.Subjects;

internal sealed record CreateSubjectRequest(Subject Subject);

internal sealed class CreateSubject : Endpoint<CreateSubjectRequest>
{
    
    private readonly MyDatabaseContext _context;

    public CreateSubject(MyDatabaseContext context)
    {
        _context = context;
    }

    public override void Configure()
    {
        Post("/studyplan/subjects");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateSubjectRequest req, CancellationToken ct)
    {
        await _context.Subjects.AddAsync(req.Subject, ct);
        await _context.SaveChangesAsync(ct);
        
        await SendAsync(new { Message = "Subject created successfully" }, 201, ct);
        
    }
}