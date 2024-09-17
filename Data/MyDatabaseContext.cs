using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Data;

public class MyDatabaseContext: IdentityDbContext
{
    
    
    public DbSet<Subject> Subjects { get; set; }
    
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
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MyDatabase.db");

    }
}