namespace StudyPlannerSoft.Entities;

public class StudyProgram
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Dieninis, Sesijinis, English,  

    public Ulid FacultyId { get; set; } // Foreign key to Faculty
    public Faculty Faculty { get; set; } = new Faculty();

    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
