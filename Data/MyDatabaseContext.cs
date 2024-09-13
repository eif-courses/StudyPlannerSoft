using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Data;

public class MyDatabaseContext: DbContext
{
    
    
    public DbSet<Subject> Subjects { get; set; }
    
    public MyDatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MyDatabase.db");

    }
}