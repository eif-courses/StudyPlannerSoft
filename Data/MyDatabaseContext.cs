using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Data;

public class MyDatabaseContext : IdentityDbContext
{
    public DbSet<Lecturer> Lecturers { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<StudyProgram> StudyPrograms { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<PlannedGroup> PlannedGroups { get; set; }


    public MyDatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2", Name = "Deputy", NormalizedName = "DEPUTY" },
            new IdentityRole { Id = "3", Name = "Lecturer", NormalizedName = "LECTURER" },
            new IdentityRole { Id = "4", Name = "Faculty", NormalizedName = "FACULTY" },
            new IdentityRole { Id = "5", Name = "Department", NormalizedName = "DEPARTMENT" }
        );

        var ulidConverter = new UlidValueConverter();

        // Apply Ulid conversion globally
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            var properties = entity.ClrType.GetProperties()
                .Where(p => p.PropertyType == typeof(Ulid));
            foreach (var property in properties)
            {
                modelBuilder.Entity(entity.ClrType)
                    .Property(property.Name)
                    .HasConversion(ulidConverter);
            }
        }

        // Lecturer-Position relationship
        modelBuilder.Entity<Lecturer>()
            .HasOne(l => l.Position)
            .WithMany()
            .HasForeignKey(l => l.PositionId);

        // Lecturer-Department relationship
        modelBuilder.Entity<Lecturer>()
            .HasOne(l => l.Department)
            .WithMany(d => d.Lecturers)
            .HasForeignKey(l => l.DepartmentId);

        // Department-Faculty relationship
        modelBuilder.Entity<Department>()
            .HasOne(d => d.Faculty)
            .WithMany(f => f.Departments)
            .HasForeignKey(d => d.FacultyId);

        // StudyProgram-Faculty relationship
        modelBuilder.Entity<StudyProgram>()
            .HasOne(sp => sp.Faculty)
            .WithMany(f => f.StudyPrograms)
            .HasForeignKey(sp => sp.FacultyId);

        // Subject-Department relationship
        modelBuilder.Entity<Subject>()
            .HasOne(s => s.Department)
            .WithMany(d => d.Subjects)
            .HasForeignKey(s => s.DepartmentId);

        // Subject-StudyProgram relationship
        modelBuilder.Entity<Subject>()
            .HasOne(s => s.StudyProgram)
            .WithMany(sp => sp.Subjects)
            .HasForeignKey(s => s.StudyProgramId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
    }
}