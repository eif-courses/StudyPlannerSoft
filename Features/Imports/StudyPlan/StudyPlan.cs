using FastEndpoints;
using StudyPlannerSoft.Data;

namespace StudyPlannerSoft.Features.Imports.StudyPlan;

internal sealed class ImportSubjectsRequest
{
    public IFormFile File { get; set; }
}
internal sealed class StudyPlan(SubjectImporter subjectImporter, MyDatabaseContext dbContext)
    : Endpoint<ImportSubjectsRequest>
{
    public override void Configure()
    {
        Post("imports/study-plan");
        AllowFileUploads();
        AllowAnonymous();
    }

    public override async Task HandleAsync(ImportSubjectsRequest req, CancellationToken ct)
    {
        var subjects = subjectImporter.ImportFromExcel(req.File.OpenReadStream());
        
        dbContext.Subjects.AddRange(subjects);
        await dbContext.SaveChangesAsync(ct);

        await SendOkAsync(ct);
    }
}