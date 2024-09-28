using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Data;

public class MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : IdentityDbContext<MyUser>(options)
{
    public DbSet<Lecturer> Lecturers { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<StudyProgram> StudyPrograms { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<PlannedGroup> PlannedGroups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ConvertUlidsForEntities(modelBuilder);

        LecturerEntityConfiguration.Configure(modelBuilder);
        StudyProgramEntityConfiguration.Configure(modelBuilder);
        SubjectEntityConfiguration.Configure(modelBuilder);
        DepartmentEntityConfiguration.Configure(modelBuilder);
        PlannedGroupEntityConfiguration.Configure(modelBuilder);
        
        
        SeedData.Initialize(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var npgsqlConnectionString = new NpgsqlConnectionStringBuilder
            {
                Host = Environment.GetEnvironmentVariable("POSTGRES_HOST"),
                Port = Convert.ToInt32(Environment.GetEnvironmentVariable("POSTGRES_PORT")),
                Username = Environment.GetEnvironmentVariable("POSTGRES_USER"),
                Password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD"),
                Database = Environment.GetEnvironmentVariable("POSTGRES_DB"),
                SslMode = SslMode.Require
            };
            optionsBuilder.UseNpgsql(npgsqlConnectionString.ConnectionString);
        }
    }


    private void ConvertUlidsForEntities(ModelBuilder modelBuilder)
    {
        var ulidConverter = new UlidValueConverter();

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
    }
}