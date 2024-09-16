using FastEndpoints;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Dto;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.StudyPlan.Subjects;



internal sealed class CreateSubject : Endpoint<SubjectDto>
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

    public override async Task HandleAsync(SubjectDto req, CancellationToken ct)
    {
        
        var subject = new Subject
        {
            Title = req.Title,
            Description = req.Description
        };
        
        await _context.Subjects.AddAsync(subject, ct);
        await _context.SaveChangesAsync(ct);
        
        await SendAsync(new { Message = "Subject created successfully" }, 201, ct);
        
    }
}