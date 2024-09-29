using FastEndpoints;
using StudyPlannerSoft.Data;

namespace StudyPlannerSoft.Features.PlannedGroups;

internal sealed class ImportPlannedGroupsRequest
{
    public IFormFile File { get; set; }
}

internal sealed class ImportPlannedGroups : Endpoint<ImportPlannedGroupsRequest>
{
    private readonly MyDatabaseContext _dbContext;
    private readonly ImportPlannedGroupsService _importPlannedGroupsService;
    private readonly ILogger<ImportPlannedGroups> _logger;

    public ImportPlannedGroups(MyDatabaseContext dbContext, ImportPlannedGroupsService importPlannedGroupsService,
        ILogger<ImportPlannedGroups> logger)
    {
        _dbContext = dbContext;
        _importPlannedGroupsService = importPlannedGroupsService;
        _logger = logger;
    }

    public override void Configure()
    {
        Post("planned-groups/import");
        AllowFileUploads();
        AllowAnonymous();
    }

    public override async Task HandleAsync(ImportPlannedGroupsRequest req, CancellationToken ct)
    {
        var groups = _importPlannedGroupsService.ImportFromExcel(req.File.OpenReadStream());
        _dbContext.PlannedGroups.AddRange(groups);

        await _dbContext.SaveChangesAsync(ct);
        await SendOkAsync(ct);
    }
}