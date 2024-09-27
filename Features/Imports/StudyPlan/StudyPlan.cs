using StudyPlannerSoft.Data;
using FastEndpoints;
namespace StudyPlannerSoft.Features.Imports;



internal sealed class ImportSubjectsRequest
{
    public IFormFile File { get; set; }
}
internal sealed class StudyPlan : Endpoint<ImportSubjectsRequest>
{
    
    private readonly SubjectImporter _subjectImporter;
    private readonly MyDatabaseContext _dbContext;

    public StudyPlan(SubjectImporter subjectImporter, MyDatabaseContext dbContext)
    {
        _subjectImporter = subjectImporter;
        _dbContext = dbContext;
    }

    public override void Configure()
    {
        Post("imports/study-plan");
        AllowFileUploads();
        AllowAnonymous();
    }

    public override async Task HandleAsync(ImportSubjectsRequest req, CancellationToken ct)
    {
        var subjects = _subjectImporter.ImportFromExcel(req.File.OpenReadStream());
        
        _dbContext.Subjects.AddRange(subjects);
        await _dbContext.SaveChangesAsync(ct);

        await SendOkAsync(ct);
    }
}