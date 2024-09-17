namespace StudyPlannerSoft.Entities;

public class Lecturer
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Ulid PositionId { get; set; } // Foreign key to Position
    public Position Position { get; set; } = new Position();

    public Ulid DepartmentId { get; set; } // Foreign key to Department
    public Department Department { get; set; } = new Department();
}
