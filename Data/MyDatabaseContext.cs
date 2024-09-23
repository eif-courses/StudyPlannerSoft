using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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

        SeedFaculties(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

            if (isDevelopment)
            {
                optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
            }
            else
            {
                var connectionString = Environment.GetEnvironmentVariable("DATABASE_PUBLIC_URL");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("DATABASE_PUBLIC_URL environment variable is not set.");
                }

                connectionString = connectionString.Replace("postgres://", "Host=")
                    .Replace(":", ";Port=")
                    .Replace("@", ";Username=")
                    .Replace("/", ";Database=");

                connectionString += ";SSL Mode=Require;Trust Server Certificate=true;";

                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }

    private void SeedFaculties(ModelBuilder modelBuilder)
    {
        var facultyIds = new List<Ulid>
        {
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid()
        };


        modelBuilder.Entity<Faculty>().HasData(
            new Faculty
            {
                Id = facultyIds[0],
                Name = "Agrotechnologijų fakultetas",
                ShortName = "ATF",
                Email = "administracija@atf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[1],
                Name = "Dizaino fakultetas",
                ShortName = "DIF",
                Email = "administracija@dif.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[2],
                Name = "Elektronikos ir informatikos fakultetas",
                ShortName = "EIF",
                Email = "info@eif.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[3],
                Name = "Ekonomikos fakultetas",
                ShortName = "EKF",
                Email = "administracija@ekf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[4],
                Name = "Pedagogikos fakultetas",
                ShortName = "PDF",
                Email = "administracija@pdf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[5],
                Name = "Menų ir kūrybinių technologijų fakultetas",
                ShortName = "MTF",
                Email = "administracija@mtf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[6],
                Name = "Statybos fakultetas",
                ShortName = "STF",
                Email = "administracija@stf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[7],
                Name = "Sveikatos priežiūros fakultetas",
                ShortName = "SPF",
                Email = "info@spf.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[8],
                Name = "Technikos fakultetas",
                ShortName = "TEF",
                Email = "administracija@tef.viko.lt"
            },
            new Faculty
            {
                Id = facultyIds[9],
                Name = "Verslo vadybos fakultetas",
                ShortName = "VVF",
                Email = "administracija@vvf.viko.lt"
            }
        );

        var departmentEifIds = new List<Ulid>
        {
            Ulid.NewUlid(),
            Ulid.NewUlid(),
            Ulid.NewUlid()
        };

        // EIF FAKULTETAS
        modelBuilder.Entity<Department>().HasData(
            new Department
            {
                Id = departmentEifIds[0],
                Name = "Elektronikos ir kompiuterių inžinerijos katedra",
                Email = "a.kirdeikiene@eif.viko.lt",
                ShortName = "EKIK",
                FacultyId = facultyIds[2]
            },
            new Department
            {
                Id = departmentEifIds[1],
                Name = "Informacinių sistemų katedra",
                Email = "t.liogiene@eif.viko.lt",
                ShortName = "ISK",
                FacultyId = facultyIds[2]
            },
            new Department
            {
                Id = departmentEifIds[2],
                Name = "Programinės įrangos katedra",
                Email = "j.zailskas@eif.viko.lt",
                ShortName = "PĮK",
                FacultyId = facultyIds[2]
            }
        );

        modelBuilder.Entity<StudyProgram>().HasData(
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Programinės įrangos testavimas",
                StudyType = StudyType.Normal,
                DepartmentId = departmentEifIds[2]
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Elektronikos inžinerija",
                DepartmentId = departmentEifIds[0],
                StudyType = StudyType.Normal
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Elektronikos inžinerija",
                DepartmentId = departmentEifIds[0],
                StudyType = StudyType.Sessions,
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Informacijos sistemos",
                DepartmentId = departmentEifIds[1],
                StudyType = StudyType.Normal
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Informacijos sistemos",
                DepartmentId = departmentEifIds[1],
                StudyType = StudyType.Sessions
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Informacijos sistemos",
                DepartmentId = departmentEifIds[1],
                StudyType = StudyType.Remote
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Kompiuterių inžinerija",
                DepartmentId = departmentEifIds[0],
                StudyType = StudyType.Normal
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Kompiuterių inžinerija",
                DepartmentId = departmentEifIds[0],
                StudyType = StudyType.Sessions
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Programų sistemos",
                DepartmentId = departmentEifIds[2],
                StudyType = StudyType.Normal
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Programų sistemos",
                DepartmentId = departmentEifIds[2],
                StudyType = StudyType.English
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Programų sistemos",
                DepartmentId = departmentEifIds[2],
                StudyType = StudyType.Sessions
            },
            new StudyProgram
            {
                Id = Ulid.NewUlid(),
                Name = "Programų sistemos",
                DepartmentId = departmentEifIds[2],
                StudyType = StudyType.Remote
            }
        );
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