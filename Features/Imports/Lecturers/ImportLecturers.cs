using FastEndpoints;
using StudyPlannerSoft.Data;
namespace StudyPlannerSoft.Features.Imports.Lecturers;

internal sealed class ImportLecturersRequest
{
    public IFormFile File { get; set; }
}

internal sealed class ImportLecturers : Endpoint<ImportLecturersRequest>
{
    private readonly MyDatabaseContext _dbContext;
    private readonly LecturerImporter _lecturerImporter;
    private readonly ILogger<ImportLecturers> _logger;

    public ImportLecturers(MyDatabaseContext dbContext, LecturerImporter lecturerImporter,
        ILogger<ImportLecturers> logger)
    {
        _dbContext = dbContext;
        _lecturerImporter = lecturerImporter;
        _logger = logger;
    }

    public override void Configure()
    {
        Post("imports/lecturers");
        AllowFileUploads();
        AllowAnonymous();
    }

    public override async Task HandleAsync(ImportLecturersRequest req, CancellationToken ct)
    {
        var lecturers = _lecturerImporter.ImportFromExcel(req.File.OpenReadStream());
        _dbContext.Lecturers.AddRange(lecturers);
        
        await _dbContext.SaveChangesAsync(ct);
        await SendOkAsync(ct);
    }
}
