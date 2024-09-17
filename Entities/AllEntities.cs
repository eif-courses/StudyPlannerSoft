namespace StudyPlannerSoft.Entities;

public class Lecturer
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string Position { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
}

public class Faculty
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class Department
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;

    public Faculty Faculty { get; set; } = new Faculty();
}

public class Position
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Pab { get; set; } = 0;
}

// Studiju planas 

public class StudyProgram
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Dieninis, Sesijinis, English,  

    public Faculty Faculty { get; set; } = new Faculty();
}

public enum Semester
{
    First = 1,
    Second = 2,
    Third = 3,
    Fourth = 4,
    Fifth = 5,
    Sixth = 6,
    Seventh = 7
}

public enum SemesterType
{
    Autumn = 1,
    Spring = 2
}

public class PlannedGroup
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty; // Jeigu yra per kableli reiskia yra srautas
    public Semester Semester { get; set; }
    public int Vf { get; set; } = 0;
    public int Vnf { get; set; } = 0;
    public int OtherType { get; set; } = 0;
    public int CurrentYear { get; set; } = 0;
    public SemesterType SemesterType { get; set; } = SemesterType.Autumn;
}

public class ContactHour
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public double LectureHours { get; set; } = 0.0;
    public double PracticeHours { get; set; } = 0.0;
    public double? RemoteLectureHours { get; set; } = null;
    public double? RemotePracticeHours { get; set; } = null;
    public double SelfStudyHours { get; set; } = 0.0;
    public string Notes { get; set; } = string.Empty;

    public int SubGroupsCount { get; set; } = 1;
    public int LecturesCount { get; set; } = 0;
    public double FinalProjectExamCount { get; set; } = 0.0;
    public double OtherCount { get; set; } = 0.0;
    public double ConsultationCount { get; set; } = 0.0;
}

public class NonContactHour
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public double GradingNumberCount { get; set; } = 0.0;
    public double GradingHoursCount { get; set; } = 0.0;
    public double OtherCount { get; set; } = 0.0;
}