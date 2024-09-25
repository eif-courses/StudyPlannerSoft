using OfficeOpenXml;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Features.Imports;

public class SubjectImporter
{
    public IEnumerable<Subject> ImportFromExcel(Stream excelStream)
    {
        var subjects = new List<Subject>();

        using (var package = new ExcelPackage(excelStream))
        {
            var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first sheet
            var rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++) // Start from row 2 to skip headers
            {
                var subject = new Subject
                {
                    Name = worksheet.Cells[row, 1].Text,
                    // Using TryParse to safely parse the values and provide a fallback if parsing fails
                    Semester = Enum.TryParse<Semester>(worksheet.Cells[row, 2].Text, out var semester) ? semester : Semester.First, 
                    Credits = int.TryParse(worksheet.Cells[row, 3].Text, out var credits) ? credits : 0,
                    EvaluationForm = worksheet.Cells[row, 4].Text,
                    SubjectType = Enum.TryParse<SubjectType>(worksheet.Cells[row, 5].Text, out var subjectType) ? subjectType : SubjectType.Mandatory,
                    LectureHours = double.TryParse(worksheet.Cells[row, 6].Text, out var lectureHours) ? lectureHours : 0,
                    PracticeHours = double.TryParse(worksheet.Cells[row, 7].Text, out var practiceHours) ? practiceHours : 0,
                    RemoteLectureHours = double.TryParse(worksheet.Cells[row, 8].Text, out var remoteLectureHours) ? (double?)remoteLectureHours : null,
                    RemotePracticeHours = double.TryParse(worksheet.Cells[row, 9].Text, out var remotePracticeHours) ? (double?)remotePracticeHours : null,
                    SelfStudyHours = double.TryParse(worksheet.Cells[row, 10].Text, out var selfStudyHours) ? selfStudyHours : 0,
                    SubGroupsCount = int.TryParse(worksheet.Cells[row, 11].Text, out var subGroupsCount) ? subGroupsCount : 0,
                    LecturesCount = int.TryParse(worksheet.Cells[row, 12].Text, out var lecturesCount) ? lecturesCount : 0,
                    FinalProjectExamCount = double.TryParse(worksheet.Cells[row, 13].Text, out var finalProjectExamCount) ? finalProjectExamCount : 0,
                    OtherContactHoursCount = double.TryParse(worksheet.Cells[row, 14].Text, out var otherContactHoursCount) ? otherContactHoursCount : 0,
                    ConsultationCount = double.TryParse(worksheet.Cells[row, 15].Text, out var consultationCount) ? consultationCount : 0,
                    GradingNumberCount = double.TryParse(worksheet.Cells[row, 16].Text, out var gradingNumberCount) ? gradingNumberCount : 0,
                    GradingHoursCount = double.TryParse(worksheet.Cells[row, 17].Text, out var gradingHoursCount) ? gradingHoursCount : 0,
                    OtherNonContactCount = double.TryParse(worksheet.Cells[row, 18].Text, out var otherNonContactCount) ? otherNonContactCount : 0,
                    Notes = worksheet.Cells[row, 19].Text,
                    // StudyProgram = ,
                    // EvaluationFormShort = ,
                    // StudyProgramId = ,
                    // SubjectTypeCategoryDescription = 
                };

                subjects.Add(subject);
            }
        }

        return subjects;
    }
}
