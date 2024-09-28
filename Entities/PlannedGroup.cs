using Microsoft.EntityFrameworkCore;

namespace StudyPlannerSoft.Entities;

public class PlannedGroup
{
    public Ulid Id { get; set; } = Ulid.NewUlid();
    public string Name { get; set; } = string.Empty; // Jeigu yra per kableli reiskia yra srautas
    public Semester Semester { get; set; } 
    public int? Vf { get; set; } = 0;
    public int? Vnf { get; set; } = 0;
    public string? SubGroupCount = "1";
    public int? OtherType { get; set; } = 0;
    public string? LabelName { get; set; } = string.Empty;

    public Ulid StudyProgramId { get; set; } 
    public StudyProgram StudyProgram { get; set; }
}


public static class PlannedGroupEntityConfiguration
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlannedGroup>(entity =>
        {
            entity.Property(e => e.SubGroupCount)
                .HasMaxLength(10) 
                .HasDefaultValue("1");
            
            entity.HasOne(e => e.StudyProgram)
                .WithMany(sp => sp.PlannedGroups)
                .HasForeignKey(e => e.StudyProgramId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}