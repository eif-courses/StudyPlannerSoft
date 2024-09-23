﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudyPlannerSoft.Data;

#nullable disable

namespace StudyPlannerSoft.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FavouriteColor")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FacultyId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "01J8FT59KNQDPP7SSBBSXZQB16",
                            Email = "a.kirdeikiene@eif.viko.lt",
                            FacultyId = "01J8FT59KNCNHGTPWS257NSRT7",
                            Name = "Elektronikos ir kompiuterių inžinerijos katedra",
                            ShortName = "EKIK"
                        },
                        new
                        {
                            Id = "01J8FT59KNS2XAEKPF5KPJMZ04",
                            Email = "t.liogiene@eif.viko.lt",
                            FacultyId = "01J8FT59KNCNHGTPWS257NSRT7",
                            Name = "Informacinių sistemų katedra",
                            ShortName = "ISK"
                        },
                        new
                        {
                            Id = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Email = "j.zailskas@eif.viko.lt",
                            FacultyId = "01J8FT59KNCNHGTPWS257NSRT7",
                            Name = "Programinės įrangos katedra",
                            ShortName = "PĮK"
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Faculty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = "01J8FT59KNCCCFFRX3S5ESEHTZ",
                            Email = "administracija@atf.viko.lt",
                            Name = "Agrotechnologijų fakultetas",
                            ShortName = "ATF"
                        },
                        new
                        {
                            Id = "01J8FT59KNFCRVTVRK128MQ3W5",
                            Email = "administracija@dif.viko.lt",
                            Name = "Dizaino fakultetas",
                            ShortName = "DIF"
                        },
                        new
                        {
                            Id = "01J8FT59KNCNHGTPWS257NSRT7",
                            Email = "info@eif.viko.lt",
                            Name = "Elektronikos ir informatikos fakultetas",
                            ShortName = "EIF"
                        },
                        new
                        {
                            Id = "01J8FT59KNWD3VGJJGC4AQRSNX",
                            Email = "administracija@ekf.viko.lt",
                            Name = "Ekonomikos fakultetas",
                            ShortName = "EKF"
                        },
                        new
                        {
                            Id = "01J8FT59KN6EP6J5QEQBCYSRH1",
                            Email = "administracija@pdf.viko.lt",
                            Name = "Pedagogikos fakultetas",
                            ShortName = "PDF"
                        },
                        new
                        {
                            Id = "01J8FT59KNF388XPFC3ZBT9KNE",
                            Email = "administracija@mtf.viko.lt",
                            Name = "Menų ir kūrybinių technologijų fakultetas",
                            ShortName = "MTF"
                        },
                        new
                        {
                            Id = "01J8FT59KNG7FCWMT4Y7965RHN",
                            Email = "administracija@stf.viko.lt",
                            Name = "Statybos fakultetas",
                            ShortName = "STF"
                        },
                        new
                        {
                            Id = "01J8FT59KN2G190AGQABB7AKMW",
                            Email = "info@spf.viko.lt",
                            Name = "Sveikatos priežiūros fakultetas",
                            ShortName = "SPF"
                        },
                        new
                        {
                            Id = "01J8FT59KNM6HSHK77C0ET3B1F",
                            Email = "administracija@tef.viko.lt",
                            Name = "Technikos fakultetas",
                            ShortName = "TEF"
                        },
                        new
                        {
                            Id = "01J8FT59KNB004XT48DQFFHX1S",
                            Email = "administracija@vvf.viko.lt",
                            Name = "Verslo vadybos fakultetas",
                            ShortName = "VVF"
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Lecturer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.PlannedGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("CurrentYear")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OtherType")
                        .HasColumnType("integer");

                    b.Property<int>("Semester")
                        .HasColumnType("integer");

                    b.Property<int>("SemesterType")
                        .HasColumnType("integer");

                    b.Property<int>("Vf")
                        .HasColumnType("integer");

                    b.Property<int>("Vnf")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PlannedGroups");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Position", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Pab")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.StudyProgram", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("StudyType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("StudyPrograms");

                    b.HasData(
                        new
                        {
                            Id = "01J8FT59KNV2RQC8EYHRPS7H5B",
                            DepartmentId = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Name = "Programinės įrangos testavimas",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J8FT59KNX5FKSK7BK626EMSE",
                            DepartmentId = "01J8FT59KNQDPP7SSBBSXZQB16",
                            Name = "Elektronikos inžinerija",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J8FT59KNGE5JDQCMNZWX9AV2",
                            DepartmentId = "01J8FT59KNQDPP7SSBBSXZQB16",
                            Name = "Elektronikos inžinerija",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J8FT59KNWFJ2K88K40A78FV8",
                            DepartmentId = "01J8FT59KNS2XAEKPF5KPJMZ04",
                            Name = "Informacijos sistemos",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J8FT59KNX6HW5PXAWARPEZDG",
                            DepartmentId = "01J8FT59KNS2XAEKPF5KPJMZ04",
                            Name = "Informacijos sistemos",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J8FT59KN388X90J3Z17NVHP1",
                            DepartmentId = "01J8FT59KNS2XAEKPF5KPJMZ04",
                            Name = "Informacijos sistemos",
                            StudyType = 3
                        },
                        new
                        {
                            Id = "01J8FT59KN95NTXK5AZCCT499P",
                            DepartmentId = "01J8FT59KNQDPP7SSBBSXZQB16",
                            Name = "Kompiuterių inžinerija",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J8FT59KN2DAZVT19P7M0ARD4",
                            DepartmentId = "01J8FT59KNQDPP7SSBBSXZQB16",
                            Name = "Kompiuterių inžinerija",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J8FT59KN4CRB6EYSMEVKJA4N",
                            DepartmentId = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Name = "Programų sistemos",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J8FT59KN1RNXGZHBHNGYH9Q8",
                            DepartmentId = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Name = "Programų sistemos",
                            StudyType = 4
                        },
                        new
                        {
                            Id = "01J8FT59KNHS7WNB1149HY3H8H",
                            DepartmentId = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Name = "Programų sistemos",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J8FT59KNQH5ZCR83C0QD3YNW",
                            DepartmentId = "01J8FT59KN56MKEC8H4XQJ4G00",
                            Name = "Programų sistemos",
                            StudyType = 3
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<double>("ConsultationCount")
                        .HasColumnType("double precision");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<string>("EvaluationForm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EvaluationFormShort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("FinalProjectExamCount")
                        .HasColumnType("double precision");

                    b.Property<double>("GradingHoursCount")
                        .HasColumnType("double precision");

                    b.Property<double>("GradingNumberCount")
                        .HasColumnType("double precision");

                    b.Property<double>("LectureHours")
                        .HasColumnType("double precision");

                    b.Property<int>("LecturesCount")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("OtherContactHoursCount")
                        .HasColumnType("double precision");

                    b.Property<double>("OtherNonContactCount")
                        .HasColumnType("double precision");

                    b.Property<double>("PracticeHours")
                        .HasColumnType("double precision");

                    b.Property<double?>("RemoteLectureHours")
                        .HasColumnType("double precision");

                    b.Property<double?>("RemotePracticeHours")
                        .HasColumnType("double precision");

                    b.Property<double>("SelfStudyHours")
                        .HasColumnType("double precision");

                    b.Property<int>("Semester")
                        .HasColumnType("integer");

                    b.Property<string>("StudyProgramId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SubGroupsCount")
                        .HasColumnType("integer");

                    b.Property<int>("SubjectType")
                        .HasColumnType("integer");

                    b.Property<string>("SubjectTypeCategoryDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudyProgramId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Department", b =>
                {
                    b.HasOne("StudyPlannerSoft.Entities.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Lecturer", b =>
                {
                    b.HasOne("StudyPlannerSoft.Entities.Department", "Department")
                        .WithMany("Lecturers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudyPlannerSoft.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.StudyProgram", b =>
                {
                    b.HasOne("StudyPlannerSoft.Entities.Department", "Department")
                        .WithMany("StudyPrograms")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Subject", b =>
                {
                    b.HasOne("StudyPlannerSoft.Entities.StudyProgram", "StudyProgram")
                        .WithMany("Subjects")
                        .HasForeignKey("StudyProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudyProgram");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Department", b =>
                {
                    b.Navigation("Lecturers");

                    b.Navigation("StudyPrograms");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Faculty", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.StudyProgram", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
