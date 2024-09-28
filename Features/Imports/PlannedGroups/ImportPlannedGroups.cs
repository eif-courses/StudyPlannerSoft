using FastEndpoints;
using StudyPlannerSoft.Data;

namespace StudyPlannerSoft.Features.Imports.PlannedGroups;

internal sealed class ImportPlannedGroupsRequest
{
    public IFormFile File { get; set; }
}

internal sealed class ImportPlannedGroups : Endpoint<ImportPlannedGroupsRequest>
{
    private readonly MyDatabaseContext _dbContext;
    private readonly PlannedGroupImporter _plannedGroupImporter;
    private readonly ILogger<ImportPlannedGroups> _logger;

    public ImportPlannedGroups(MyDatabaseContext dbContext, PlannedGroupImporter plannedGroupImporter,
        ILogger<ImportPlannedGroups> logger)
    {
        _dbContext = dbContext;
        _plannedGroupImporter = plannedGroupImporter;
        _logger = logger;
    }

    public override void Configure()
    {
        Post("imports/planned-groups");
        AllowFileUploads();
        AllowAnonymous();
    }

    public override async Task HandleAsync(ImportPlannedGroupsRequest req, CancellationToken ct)
    {
        var groups = _plannedGroupImporter.ImportFromExcel(req.File.OpenReadStream());
        _dbContext.PlannedGroups.AddRange(groups);

        await _dbContext.SaveChangesAsync(ct);
        await SendOkAsync(ct);
    }
}