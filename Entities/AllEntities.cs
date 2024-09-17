namespace StudyPlannerSoft.Entities;

public class Lecturer
{
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    
    public string Position { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    
}

public class Faculty
{
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class Department {
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    
    public Faculty Faculty { get; set; } = new Faculty();
}

public class Position
{
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Pab { get; set; } = 0;
}

// Studiju planas 

public class StudyProgram
{
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    
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

public class PlannedGroup
{
    public Ulid Id { get; set; } = new Ulid();
    public string Name { get; set; } = string.Empty;
    public Semester Semester { get; set; }
    public int Vf { get; set; } = 0;
    public int Vnf { get; set; } = 0;
    public int OtherType { get; set; } = 0;
    
}




