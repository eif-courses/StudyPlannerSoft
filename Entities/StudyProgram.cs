using Microsoft.EntityFrameworkCore;

namespace StudyPlannerSoft.Entities;

public class StudyProgram
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty; // Dieninis, Sesijinis, English,  
    public Ulid DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}

public static class StudyProgramEntityConfiguration
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<StudyProgram>()
            .HasOne(sp => sp.Department)
            .WithMany(d => d.StudyPrograms)
            .HasForeignKey(sp => sp.DepartmentId);
        
        
        modelBuilder.Entity<StudyProgram>()
            .Property(sp => sp.Name)
            .HasMaxLength(255);

        modelBuilder.Entity<StudyProgram>()
            .Property(sp => sp.Type)
            .HasMaxLength(50); 
    }
}