namespace StudyPlannerSoft.Entities;
public enum SubjectType
{
    Mandatory = 1,
    SpecializedElective = 2,
    Optional = 3
}

public class Subject
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public Semester Semester { get; set; } = Semester.First;
    public int Credits { get; set; } = 0;
    public string EvaluationForm { get; set; } = string.Empty;
    public string EvaluationFormShort { get; set; } = string.Empty;

    public SubjectType SubjectType { get; set; } = SubjectType.Mandatory;
    public string SubjectTypeCategoryDescription { get; set; } = string.Empty;
    
    // Kontaktines valandos

    public double LectureHours { get; set; } = 0.0;
    public double PracticeHours { get; set; } = 0.0;
    public double? RemoteLectureHours { get; set; } = null;
    public double? RemotePracticeHours { get; set; } = null;
    public double SelfStudyHours { get; set; } = 0.0;
    public string Notes { get; set; } = string.Empty;

    public int SubGroupsCount { get; set; } = 1;
    public int LecturesCount { get; set; } = 0;
    public double FinalProjectExamCount { get; set; } = 0.0;
    public double OtherContactHoursCount { get; set; } = 0.0;
    public double ConsultationCount { get; set; } = 0.0;

    // Ne kontaktines valandos

    public double GradingNumberCount { get; set; } = 0.0;
    public double GradingHoursCount { get; set; } = 0.0;
    public double OtherNonContactCount { get; set; } = 0.0;
    
    public Ulid DepartmentId { get; set; } // Foreign key to Department
    public Department Department { get; set; } = new Department();

    public Ulid StudyProgramId { get; set; } // Foreign key to StudyProgram
    public StudyProgram StudyProgram { get; set; } = new StudyProgram();
}
