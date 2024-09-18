﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

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
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "01J834XSRB7WRPGXYG8HKS95KG",
                            Email = "a.kirdeikiene@eif.viko.lt",
                            FacultyId = "01J834XSRB6YRE5ZWN7NPEPM0Y",
                            Name = "Elektronikos ir kompiuterių inžinerijos katedra",
                            ShortName = "EKIK"
                        },
                        new
                        {
                            Id = "01J834XSRBH6V718AYH0R3026V",
                            Email = "t.liogiene@eif.viko.lt",
                            FacultyId = "01J834XSRB6YRE5ZWN7NPEPM0Y",
                            Name = "Informacinių sistemų katedra",
                            ShortName = "ISK"
                        },
                        new
                        {
                            Id = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Email = "j.zailskas@eif.viko.lt",
                            FacultyId = "01J834XSRB6YRE5ZWN7NPEPM0Y",
                            Name = "Programinės įrangos katedra",
                            ShortName = "PĮK"
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Faculty", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = "01J834XSRBPWTW1BZ55TRF2AHM",
                            Email = "administracija@atf.viko.lt",
                            Name = "Agrotechnologijų fakultetas",
                            ShortName = "ATF"
                        },
                        new
                        {
                            Id = "01J834XSRBWXBFBZMQZCCDGGM0",
                            Email = "administracija@dif.viko.lt",
                            Name = "Dizaino fakultetas",
                            ShortName = "DIF"
                        },
                        new
                        {
                            Id = "01J834XSRB6YRE5ZWN7NPEPM0Y",
                            Email = "info@eif.viko.lt",
                            Name = "Elektronikos ir informatikos fakultetas",
                            ShortName = "EIF"
                        },
                        new
                        {
                            Id = "01J834XSRBWPXM2BVFQCNJT399",
                            Email = "administracija@ekf.viko.lt",
                            Name = "Ekonomikos fakultetas",
                            ShortName = "EKF"
                        },
                        new
                        {
                            Id = "01J834XSRBGVSHWWT3G1GHQMJ9",
                            Email = "administracija@pdf.viko.lt",
                            Name = "Pedagogikos fakultetas",
                            ShortName = "PDF"
                        },
                        new
                        {
                            Id = "01J834XSRBC00KH92RRASMG7Q7",
                            Email = "administracija@mtf.viko.lt",
                            Name = "Menų ir kūrybinių technologijų fakultetas",
                            ShortName = "MTF"
                        },
                        new
                        {
                            Id = "01J834XSRBCJYY7QJZ8NMTAFVF",
                            Email = "administracija@stf.viko.lt",
                            Name = "Statybos fakultetas",
                            ShortName = "STF"
                        },
                        new
                        {
                            Id = "01J834XSRB6KVG5CQ8SYKXAYXT",
                            Email = "info@spf.viko.lt",
                            Name = "Sveikatos priežiūros fakultetas",
                            ShortName = "SPF"
                        },
                        new
                        {
                            Id = "01J834XSRBVDNSGJQZDACZB0KE",
                            Email = "administracija@tef.viko.lt",
                            Name = "Technikos fakultetas",
                            ShortName = "TEF"
                        },
                        new
                        {
                            Id = "01J834XSRBKENTHS4GJFFNPRER",
                            Email = "administracija@vvf.viko.lt",
                            Name = "Verslo vadybos fakultetas",
                            ShortName = "VVF"
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Lecturer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.PlannedGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OtherType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SemesterType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vf")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vnf")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PlannedGroups");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Position", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Pab")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.StudyProgram", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("StudyType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("StudyPrograms");

                    b.HasData(
                        new
                        {
                            Id = "01J834XSRBXBPYC2874Z4T09JN",
                            DepartmentId = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Name = "Programinės įrangos testavimas",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J834XSRBZ116E33W5F2H73QB",
                            DepartmentId = "01J834XSRB7WRPGXYG8HKS95KG",
                            Name = "Elektronikos inžinerija",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J834XSRBMP2RXKFHR1ZRHG62",
                            DepartmentId = "01J834XSRB7WRPGXYG8HKS95KG",
                            Name = "Elektronikos inžinerija",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J834XSRBSDP4ZM0N8C0SJJSK",
                            DepartmentId = "01J834XSRBH6V718AYH0R3026V",
                            Name = "Informacijos sistemos",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J834XSRBHJFJ17BY44TJ5BWG",
                            DepartmentId = "01J834XSRBH6V718AYH0R3026V",
                            Name = "Informacijos sistemos",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J834XSRB88BHJE27KQGRND7B",
                            DepartmentId = "01J834XSRBH6V718AYH0R3026V",
                            Name = "Informacijos sistemos",
                            StudyType = 3
                        },
                        new
                        {
                            Id = "01J834XSRBW9B73838P92HKZK2",
                            DepartmentId = "01J834XSRB7WRPGXYG8HKS95KG",
                            Name = "Kompiuterių inžinerija",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J834XSRBWWQ4J9ZTY486K5YX",
                            DepartmentId = "01J834XSRB7WRPGXYG8HKS95KG",
                            Name = "Kompiuterių inžinerija",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J834XSRB04K94BEEKGDPDWKD",
                            DepartmentId = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Name = "Programų sistemos",
                            StudyType = 1
                        },
                        new
                        {
                            Id = "01J834XSRB3XE3DVW4R5BJDST6",
                            DepartmentId = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Name = "Programų sistemos",
                            StudyType = 4
                        },
                        new
                        {
                            Id = "01J834XSRB5F9GGKS8RBCC26DH",
                            DepartmentId = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Name = "Programų sistemos",
                            StudyType = 2
                        },
                        new
                        {
                            Id = "01J834XSRBG41A0QZB27P7VDF0",
                            DepartmentId = "01J834XSRBFJF2RTCB4KKEF3Y0",
                            Name = "Programų sistemos",
                            StudyType = 3
                        });
                });

            modelBuilder.Entity("StudyPlannerSoft.Entities.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<double>("ConsultationCount")
                        .HasColumnType("REAL");

                    b.Property<int>("Credits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EvaluationForm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EvaluationFormShort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("FinalProjectExamCount")
                        .HasColumnType("REAL");

                    b.Property<double>("GradingHoursCount")
                        .HasColumnType("REAL");

                    b.Property<double>("GradingNumberCount")
                        .HasColumnType("REAL");

                    b.Property<double>("LectureHours")
                        .HasColumnType("REAL");

                    b.Property<int>("LecturesCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("OtherContactHoursCount")
                        .HasColumnType("REAL");

                    b.Property<double>("OtherNonContactCount")
                        .HasColumnType("REAL");

                    b.Property<double>("PracticeHours")
                        .HasColumnType("REAL");

                    b.Property<double?>("RemoteLectureHours")
                        .HasColumnType("REAL");

                    b.Property<double?>("RemotePracticeHours")
                        .HasColumnType("REAL");

                    b.Property<double>("SelfStudyHours")
                        .HasColumnType("REAL");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudyProgramId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubGroupsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubjectTypeCategoryDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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
