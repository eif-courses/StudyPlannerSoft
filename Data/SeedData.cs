using FastEndpoints;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudyPlannerSoft.Entities;

namespace StudyPlannerSoft.Data;

public static class SeedData
{
    
    private const string AdminUserId = "01H6N7NV2P1KCVKY7F6EJH0FAF";
    
    private const string AdminRoleId = "01H6N7NV1KTPB9QDZ7FYDJ3HHK";
    private const string DeputyRoleId = "01H6N7NV1JHYY7N2NFDYX4ATAP";
    private const string LecturerRoleId = "01H6N7NV1YTMCV8YPZC7QQGGG7";
    private const string FacultyRoleId = "01H6N7NV18JWC8MYPXCVZR9WZW";
    private const string DepartmentRoleId = "01H6N7NV1MHQDXGNYH2HQT34V9";
    
    public static void Initialize(ModelBuilder modelBuilder)
    {
        SeedRoles(modelBuilder);
        SeedUsers(modelBuilder);
        SeedFaculties(modelBuilder);
        SeedPositions(modelBuilder);
    }

    private static void SeedPositions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Position>().HasData(
            new Position
            {
                Id = Ulid.NewUlid(),
                Name = "Lektorius",
                Pab = 8.7,
                Description = "Lektorius 760 val."
            },
            new Position
            {
                Id = Ulid.NewUlid(),
                Name = "Asistentas",
                Pab = 9.7,
                Description = "Asitentas mokslininkas 460 val."
            }
        );
    }

    private static void SeedRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = AdminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = DeputyRoleId, Name = "Deputy", NormalizedName = "DEPUTY" },
            new IdentityRole { Id = LecturerRoleId, Name = "Lecturer", NormalizedName = "LECTURER" },
            new IdentityRole { Id = FacultyRoleId, Name = "Faculty", NormalizedName = "FACULTY" },
            new IdentityRole { Id = DepartmentRoleId, Name = "Department", NormalizedName = "DEPARTMENT" }
        );
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<MyUser>();
        var adminUser = new MyUser
        {
            Id = AdminUserId,
            UserName = "admin@viko.lt",
            NormalizedUserName = "ADMIN@VIKO.LT",
            Email = "admin@viko.lt",
            NormalizedEmail = "ADMIN@VIKO.LT",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Kolegija1@"),
            SecurityStamp = Guid.NewGuid().ToString(),
            FavouriteColor = "Red"
        };

        modelBuilder.Entity<MyUser>().HasData(adminUser);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = AdminUserId,
            RoleId = AdminRoleId
        });
    }

    private static void SeedFaculties(ModelBuilder modelBuilder)
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
}