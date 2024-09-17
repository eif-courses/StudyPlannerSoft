namespace StudyPlannerSoft.Entities;

public class Department
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;

    public Ulid FacultyId { get; set; } // Foreign key to Faculty
    public Faculty Faculty { get; set; } = new Faculty();

    public ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
