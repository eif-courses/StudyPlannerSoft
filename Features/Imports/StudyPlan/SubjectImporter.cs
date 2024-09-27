using OfficeOpenXml;
using StudyPlannerSoft.Data;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.Imports;

public class SubjectImporter
{
    private readonly MyDatabaseContext _dbContext;

    public SubjectImporter(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }


    public IEnumerable<Subject> ImportFromExcel(Stream excelStream)
    {
        var subjects = new List<Subject>();

        using (var package = new ExcelPackage(excelStream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first sheet
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 7; row <= rowCount; row++) // Start from row 2 to skip headers
            {
                string studyProgramName = worksheet.Cells[row, 1].Text;
                string studyProgramType = worksheet.Cells[row, 2].Text;

                if (!Enum.TryParse(studyProgramType, out StudyType timetableType))
                {
                    Console.WriteLine($"Invalid timetable type '{studyProgramType}' in row {row}.");
                    throw new Exception($"Invalid timetable type '{studyProgramType}' in row {row}.");
                }

                var studyProgram = _dbContext.StudyPrograms
                    .FirstOrDefault(sp => sp.Name == studyProgramName && sp.StudyType == timetableType);

                if (studyProgram == null)
                {
                    Console.WriteLine($"StudyProgram '{studyProgramName}' not found.");
                    throw new KeyNotFoundException($"StudyProgram '{studyProgramName}' not found.");
                }

                var subject = new Subject
                {
                    Name = worksheet.Cells[row, 3].Text,
                    Semester = Enum.TryParse<Semester>(worksheet.Cells[row, 4].Text, out var semester)
                        ? semester
                        : Semester.First,
                    SubjectType = Enum.TryParse<SubjectType>(worksheet.Cells[row, 5].Text, out var subjectType)
                        ? subjectType
                        : SubjectType.Mandatory,
                    LectureHours = double.TryParse(worksheet.Cells[row, 6].Text, out var lectureHours)
                        ? lectureHours
                        : 0,
                    PracticeHours = double.TryParse(worksheet.Cells[row, 7].Text, out var practiceHours)
                        ? practiceHours
                        : 0,
                    RemoteLectureHours = double.TryParse(worksheet.Cells[row, 8].Text, out var remoteLectureHours)
                        ? remoteLectureHours
                        : 0,
                    RemotePracticeHours = double.TryParse(worksheet.Cells[row, 9].Text, out var remotePracticeHours)
                        ? remotePracticeHours
                        : 0,
                    SelfStudyHours = double.TryParse(worksheet.Cells[row, 10].Text, out var selfStudyHours)
                        ? selfStudyHours
                        : 0,
                    Credits = int.TryParse(worksheet.Cells[row, 11].Text, out var credits) ? credits : 0,
                    EvaluationForm = worksheet.Cells[row, 12].Text,
                    Category = worksheet.Cells[row, 13].Text,
                    CategoryDescription = worksheet.Cells[row, 14].Text,
                    FinalProjectExamCount =
                        double.TryParse(worksheet.Cells[row, 15].Text, out var finalProjectExamCount)
                            ? finalProjectExamCount
                            : 0,
                    OtherContactHoursCount =
                        double.TryParse(worksheet.Cells[row, 16].Text, out var otherContactHoursCount)
                            ? otherContactHoursCount
                            : 0,
                    ConsultationCount = double.TryParse(worksheet.Cells[row, 17].Text, out var consultationCount)
                        ? consultationCount
                        : 0,
                    GradingNumberCount = double.TryParse(worksheet.Cells[row, 18].Text, out var gradingNumberCount)
                        ? gradingNumberCount
                        : 0,
                    HomeworkHoursCount = double.TryParse(worksheet.Cells[row, 19].Text, out var homeworkHoursCount)
                        ? homeworkHoursCount
                        : 0,
                    PracticeReportHoursCount =
                        double.TryParse(worksheet.Cells[row, 20].Text, out var practiceReportHoursCount)
                            ? practiceReportHoursCount
                            : 0,
                    RemoteTeachingHoursCount =
                        double.TryParse(worksheet.Cells[row, 21].Text, out var remoteTeachingHoursCount)
                            ? remoteTeachingHoursCount
                            : 0,
                    CourseWorkHoursCount = double.TryParse(worksheet.Cells[row, 22].Text, out var courseWorkHoursCount)
                        ? courseWorkHoursCount
                        : 0,
                    ExamHours = double.TryParse(worksheet.Cells[row, 23].Text, out var examHours) ? examHours : 0,
                    OtherNonContactCount = double.TryParse(worksheet.Cells[row, 24].Text, out var otherNonContactCount)
                        ? otherNonContactCount
                        : 0,
                    StudyProgramId = studyProgram.Id,
                };
                subjects.Add(subject);
            }
        }
        return subjects;
    }
}