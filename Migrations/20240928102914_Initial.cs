using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FavouriteColor = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlannedGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    Vf = table.Column<int>(type: "integer", nullable: false),
                    Vnf = table.Column<int>(type: "integer", nullable: false),
                    OtherType = table.Column<int>(type: "integer", nullable: false),
                    CurrentYear = table.Column<int>(type: "integer", nullable: false),
                    SemesterType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Pab = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    FacultyId = table.Column<string>(type: "text", nullable: false)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PositionId = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<string>(type: "text", nullable: false)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    StudyType = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<string>(type: "text", nullable: false)
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
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    Credits = table.Column<int>(type: "integer", nullable: false),
                    EvaluationForm = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: true),
                    CategoryDescription = table.Column<string>(type: "text", nullable: true),
                    SubjectType = table.Column<int>(type: "integer", nullable: false),
                    LectureHours = table.Column<double>(type: "double precision", nullable: false),
                    PracticeHours = table.Column<double>(type: "double precision", nullable: false),
                    RemoteLectureHours = table.Column<double>(type: "double precision", nullable: true),
                    RemotePracticeHours = table.Column<double>(type: "double precision", nullable: true),
                    SelfStudyHours = table.Column<double>(type: "double precision", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    SubGroupsCount = table.Column<int>(type: "integer", nullable: false),
                    LecturesCount = table.Column<int>(type: "integer", nullable: false),
                    FinalProjectExamCount = table.Column<double>(type: "double precision", nullable: false),
                    OtherContactHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    ConsultationCount = table.Column<double>(type: "double precision", nullable: false),
                    GradingNumberCount = table.Column<double>(type: "double precision", nullable: false),
                    GradingHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    HomeworkHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    PracticeReportHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    RemoteTeachingHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    CourseWorkHoursCount = table.Column<double>(type: "double precision", nullable: true),
                    ExamHours = table.Column<double>(type: "double precision", nullable: true),
                    OtherNonContactCount = table.Column<double>(type: "double precision", nullable: true),
                    StudyProgramId = table.Column<string>(type: "text", nullable: false)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01H6N7NV18JWC8MYPXCVZR9WZW", null, "Faculty", "FACULTY" },
                    { "01H6N7NV1JHYY7N2NFDYX4ATAP", null, "Deputy", "DEPUTY" },
                    { "01H6N7NV1KTPB9QDZ7FYDJ3HHK", null, "Admin", "ADMIN" },
                    { "01H6N7NV1MHQDXGNYH2HQT34V9", null, "Department", "DEPARTMENT" },
                    { "01H6N7NV1YTMCV8YPZC7QQGGG7", null, "Lecturer", "LECTURER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FavouriteColor", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01H6N7NV2P1KCVKY7F6EJH0FAF", 0, "cf69eed6-ac77-4979-9452-9e10e807a71c", "admin@viko.lt", true, "Red", false, null, "ADMIN@VIKO.LT", "ADMIN@VIKO.LT", "AQAAAAIAAYagAAAAEHJNcSUm3igslMLPfx7bEcZjEjj0Sa+ZMgTYLAKu404YDO/ncJC+Lr7dNg4laDfIlA==", null, false, "5c946b96-e231-4605-8d6d-1c05669617da", false, "admin@viko.lt" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8W2TVJE5V3GDVGQ1WE23Y8G", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8W2TVJE72Z6K5BACB4PH73G", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8W2TVJEABBPVAGDFB5C8F91", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8W2TVJEDB419ZWVQA18E0A1", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8W2TVJEE2EP44S0FKVB9CT3", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J8W2TVJEFB80SD0ZQKAFZ293", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8W2TVJEMFR77BG4RS58X63Z", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8W2TVJETN84GR18CQ60FR35", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8W2TVJEVQJXGY1VJG6TASZT", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8W2TVJEZ6RXY9149FWEMAB5", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J8W2TVJEEFM1PPND0VYFZ68Q", "Asitentas mokslininkas 460 val.", "Asistentas", 9.6999999999999993 },
                    { "01J8W2TVJESVNWGJ82ATQ52PFE", "Lektorius 760 val.", "Lektorius", 8.6999999999999993 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "01H6N7NV1KTPB9QDZ7FYDJ3HHK", "01H6N7NV2P1KCVKY7F6EJH0FAF" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8W2TVJE15DPDWHDM94SPF5Y", "j.zailskas@eif.viko.lt", "01J8W2TVJEMFR77BG4RS58X63Z", "Programinės įrangos katedra", "PĮK" },
                    { "01J8W2TVJEQ20DCNB1SCYC4ETY", "t.liogiene@eif.viko.lt", "01J8W2TVJEMFR77BG4RS58X63Z", "Informacinių sistemų katedra", "ISK" },
                    { "01J8W2TVJEXR4D3EQRJ84FGAW4", "a.kirdeikiene@eif.viko.lt", "01J8W2TVJEMFR77BG4RS58X63Z", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8W2TVJE1R10SF27MQ69T1ZY", "01J8W2TVJE15DPDWHDM94SPF5Y", "Programų sistemos", 3 },
                    { "01J8W2TVJE2ZNJE3T33MZJNPXZ", "01J8W2TVJE15DPDWHDM94SPF5Y", "Programų sistemos", 1 },
                    { "01J8W2TVJE3F47K4N9N4XFMGFE", "01J8W2TVJE15DPDWHDM94SPF5Y", "Programų sistemos", 4 },
                    { "01J8W2TVJE3JVG0EXTP88TWS8N", "01J8W2TVJEXR4D3EQRJ84FGAW4", "Elektronikos inžinerija", 1 },
                    { "01J8W2TVJE89KE2X65EFDHVDDW", "01J8W2TVJEXR4D3EQRJ84FGAW4", "Kompiuterių inžinerija", 1 },
                    { "01J8W2TVJE92M0XWVVACEGQD1P", "01J8W2TVJEXR4D3EQRJ84FGAW4", "Kompiuterių inžinerija", 2 },
                    { "01J8W2TVJEA1HKBBNFJRR411A8", "01J8W2TVJE15DPDWHDM94SPF5Y", "Programinės įrangos testavimas", 1 },
                    { "01J8W2TVJENY5C2BRW0QSEB8HD", "01J8W2TVJEQ20DCNB1SCYC4ETY", "Informacijos sistemos", 2 },
                    { "01J8W2TVJEPF67KY2E08ZMMA9B", "01J8W2TVJEXR4D3EQRJ84FGAW4", "Elektronikos inžinerija", 2 },
                    { "01J8W2TVJEPT9546YQGPD14A69", "01J8W2TVJEQ20DCNB1SCYC4ETY", "Informacijos sistemos", 3 },
                    { "01J8W2TVJEQ06N16FBFPW72KRC", "01J8W2TVJE15DPDWHDM94SPF5Y", "Programų sistemos", 2 },
                    { "01J8W2TVJESJKASAFHZYXX728G", "01J8W2TVJEQ20DCNB1SCYC4ETY", "Informacijos sistemos", 1 }
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
