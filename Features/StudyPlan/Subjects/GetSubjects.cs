using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Dto;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.StudyPlan.Subjects;


//public List<SubjectDto> Subjects { get; set; } = new List<SubjectDto>();
    


// internal sealed class GetSubjects: EndpointWithoutRequest<List<SubjectDto>, GetSubjectsMapper>
// {
//     
//     private readonly MyDatabaseContext _context;
//
//     public GetSubjects(MyDatabaseContext context)
//     {
//         _context = context;
//     }
//
//     public override void Configure()
//     {
//         Get("/studyplan/subjects");
//         AllowAnonymous();
//     }
//
//     public override async Task HandleAsync(CancellationToken ct)
//     {
//         var subjects = await _context.Subjects.ToListAsync(ct);
//         
//         var response = Map.FromEntity(subjects);
//         
//         await SendAsync(response, 200, ct);
//     }
// }
//
// internal sealed class GetSubjectsMapper : ResponseMapper<List<SubjectDto>, List<SubjectOld>>
// {
//     public override List<SubjectDto> FromEntity(List<SubjectOld> e)
//     {
//         return e.Select(subject => new SubjectDto
//         {
//             Id = subject.Id,
//             Title = subject.Title,
//             Description = subject.Description
//         }).ToList();
//     }
// }

