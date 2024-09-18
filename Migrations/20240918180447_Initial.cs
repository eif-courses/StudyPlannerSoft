using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyPlannerSoft.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlannedGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Semester = table.Column<int>(type: "INTEGER", nullable: false),
                    Vf = table.Column<int>(type: "INTEGER", nullable: false),
                    Vnf = table.Column<int>(type: "INTEGER", nullable: false),
                    OtherType = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentYear = table.Column<int>(type: "INTEGER", nullable: false),
                    SemesterType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Pab = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    FacultyId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PositionId = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lecturers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecturers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyPrograms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    StudyType = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyPrograms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Semester = table.Column<int>(type: "INTEGER", nullable: false),
                    Credits = table.Column<int>(type: "INTEGER", nullable: false),
                    EvaluationForm = table.Column<string>(type: "TEXT", nullable: false),
                    EvaluationFormShort = table.Column<string>(type: "TEXT", nullable: false),
                    SubjectType = table.Column<int>(type: "INTEGER", nullable: false),
                    SubjectTypeCategoryDescription = table.Column<string>(type: "TEXT", nullable: false),
                    LectureHours = table.Column<double>(type: "REAL", nullable: false),
                    PracticeHours = table.Column<double>(type: "REAL", nullable: false),
                    RemoteLectureHours = table.Column<double>(type: "REAL", nullable: true),
                    RemotePracticeHours = table.Column<double>(type: "REAL", nullable: true),
                    SelfStudyHours = table.Column<double>(type: "REAL", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    SubGroupsCount = table.Column<int>(type: "INTEGER", nullable: false),
                    LecturesCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FinalProjectExamCount = table.Column<double>(type: "REAL", nullable: false),
                    OtherContactHoursCount = table.Column<double>(type: "REAL", nullable: false),
                    ConsultationCount = table.Column<double>(type: "REAL", nullable: false),
                    GradingNumberCount = table.Column<double>(type: "REAL", nullable: false),
                    GradingHoursCount = table.Column<double>(type: "REAL", nullable: false),
                    OtherNonContactCount = table.Column<double>(type: "REAL", nullable: false),
                    StudyProgramId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J834XSRB6KVG5CQ8SYKXAYXT", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J834XSRB6YRE5ZWN7NPEPM0Y", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J834XSRBC00KH92RRASMG7Q7", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J834XSRBCJYY7QJZ8NMTAFVF", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J834XSRBGVSHWWT3G1GHQMJ9", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J834XSRBKENTHS4GJFFNPRER", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J834XSRBPWTW1BZ55TRF2AHM", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J834XSRBVDNSGJQZDACZB0KE", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J834XSRBWPXM2BVFQCNJT399", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J834XSRBWXBFBZMQZCCDGGM0", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J834XSRB7WRPGXYG8HKS95KG", "a.kirdeikiene@eif.viko.lt", "01J834XSRB6YRE5ZWN7NPEPM0Y", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" },
                    { "01J834XSRBFJF2RTCB4KKEF3Y0", "j.zailskas@eif.viko.lt", "01J834XSRB6YRE5ZWN7NPEPM0Y", "Programinės įrangos katedra", "PĮK" },
                    { "01J834XSRBH6V718AYH0R3026V", "t.liogiene@eif.viko.lt", "01J834XSRB6YRE5ZWN7NPEPM0Y", "Informacinių sistemų katedra", "ISK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J834XSRB04K94BEEKGDPDWKD", "01J834XSRBFJF2RTCB4KKEF3Y0", "Programų sistemos", 1 },
                    { "01J834XSRB3XE3DVW4R5BJDST6", "01J834XSRBFJF2RTCB4KKEF3Y0", "Programų sistemos", 4 },
                    { "01J834XSRB5F9GGKS8RBCC26DH", "01J834XSRBFJF2RTCB4KKEF3Y0", "Programų sistemos", 2 },
                    { "01J834XSRB88BHJE27KQGRND7B", "01J834XSRBH6V718AYH0R3026V", "Informacijos sistemos", 3 },
                    { "01J834XSRBG41A0QZB27P7VDF0", "01J834XSRBFJF2RTCB4KKEF3Y0", "Programų sistemos", 3 },
                    { "01J834XSRBHJFJ17BY44TJ5BWG", "01J834XSRBH6V718AYH0R3026V", "Informacijos sistemos", 2 },
                    { "01J834XSRBMP2RXKFHR1ZRHG62", "01J834XSRB7WRPGXYG8HKS95KG", "Elektronikos inžinerija", 2 },
                    { "01J834XSRBSDP4ZM0N8C0SJJSK", "01J834XSRBH6V718AYH0R3026V", "Informacijos sistemos", 1 },
                    { "01J834XSRBW9B73838P92HKZK2", "01J834XSRB7WRPGXYG8HKS95KG", "Kompiuterių inžinerija", 1 },
                    { "01J834XSRBWWQ4J9ZTY486K5YX", "01J834XSRB7WRPGXYG8HKS95KG", "Kompiuterių inžinerija", 2 },
                    { "01J834XSRBXBPYC2874Z4T09JN", "01J834XSRBFJF2RTCB4KKEF3Y0", "Programinės įrangos testavimas", 1 },
                    { "01J834XSRBZ116E33W5F2H73QB", "01J834XSRB7WRPGXYG8HKS95KG", "Elektronikos inžinerija", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_DepartmentId",
                table: "Lecturers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_PositionId",
                table: "Lecturers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPrograms_DepartmentId",
                table: "StudyPrograms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudyProgramId",
                table: "Subjects",
                column: "StudyProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "PlannedGroups");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "StudyPrograms");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
