using FastEndpoints;
using StudyPlannerSoft.Data;

namespace StudyPlannerSoft.Features.StudyPlan.Subjects;

public class SubjectRequest
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}


internal sealed class CreateSubject : Endpoint<SubjectRequest>
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

    public override async Task HandleAsync(SubjectRequest req, CancellationToken ct)
    {
        
        // var subject = new SubjectOld
        // {
        //     Title = req.Title,
        //     Description = req.Description
        // };
        //
        // await _context.Subjects.AddAsync(subject, ct);
        // await _context.SaveChangesAsync(ct);
        //
        // await SendAsync(new { Message = "Subject created successfully" }, 201, ct);
        //
    }
}