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
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Label = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
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
                    Notes = table.Column<string>(type: "text", nullable: true),
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
                    StudyProgramId = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subjects_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
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
                    DepartmentId = table.Column<string>(type: "text", nullable: false),
                    PlannedSubjectId = table.Column<string>(type: "text", nullable: true)
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
                name: "PlannedGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    Vf = table.Column<int>(type: "integer", nullable: true),
                    Vnf = table.Column<int>(type: "integer", nullable: true),
                    SubGroupCount = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, defaultValue: "1"),
                    OtherType = table.Column<int>(type: "integer", nullable: true),
                    LabelName = table.Column<string>(type: "text", nullable: true),
                    StudyProgramId = table.Column<string>(type: "text", nullable: false),
                    LecturerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedGroups_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedGroups_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectLecturers",
                columns: table => new
                {
                    LecturersId = table.Column<string>(type: "text", nullable: false),
                    SubjectsId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectLecturers", x => new { x.LecturersId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_SubjectLecturers_Lecturers_LecturersId",
                        column: x => x.LecturersId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectLecturers_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlannedSubjects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
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
                    Notes = table.Column<string>(type: "text", nullable: true),
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
                    StudyProgramId = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<string>(type: "text", nullable: true),
                    PlanId = table.Column<string>(type: "text", nullable: true),
                    PlannedGroupId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedSubjects_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSubjects_PlannedGroups_PlannedGroupId",
                        column: x => x.PlannedGroupId,
                        principalTable: "PlannedGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlannedSubjects_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannedSubjects_StudyPrograms_StudyProgramId",
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
                values: new object[] { "01H6N7NV2P1KCVKY7F6EJH0FAF", 0, "ca39ec9a-ad72-4d62-820c-d0c4a679cf91", "admin@viko.lt", true, "Red", false, null, "ADMIN@VIKO.LT", "ADMIN@VIKO.LT", "AQAAAAIAAYagAAAAEIFQHbX1k+rgmdLskDSnALLgaKsGSlgJ4Vumoc4L4R9Y6nbf6h9lgJwoCR/CusLhWw==", null, false, "ae80f2b8-34b2-4362-8ec1-e8b932e94697", false, "admin@viko.lt" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J9DYQEJX08106EXE70C2WBBE", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J9DYQEJX13K7KJMCYW8RPVW1", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J9DYQEJX3MXMET6Q5T83VJWQ", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J9DYQEJX3QZ6AT3WCTYQNVRB", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J9DYQEJXA3GQ894J67QC2EGQ", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J9DYQEJXBSHVG5K2FSCJK91V", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J9DYQEJXFDF4N2QDXDD29M45", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J9DYQEJXS1Z4BDXDEHS9CQZA", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J9DYQEJXSWQ6QCDAVEMRHPSY", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J9DYQEJXX5YTVB3011ZRJYY8", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J9DYQEJX2TEDTPKZHEPZ4551", "Lektoriaus, turinčio mokslo daktaro laipsnį", "Lektorius dr._23", 1.72 },
                    { "01J9DYQEJX310ZXFEBVZWYE3ZW", "Dėstytojas praktikas", "Dėstytojas praktikas_24", 1.72 },
                    { "01J9DYQEJX548AQC9B6Y81VR3K", "Asistento, turinčio magistro laipsnį", "Asistentas_23 (mag.)", 1.3300000000000001 },
                    { "01J9DYQEJX5KFGGB4CX5S39TY4", "Lektorius", "Lektorius_23 (m)", 1.4299999999999999 },
                    { "01J9DYQEJX8X0VC6MYVMMGSWMW", "Asistentas", "Asistentas_24", 1.8400000000000001 },
                    { "01J9DYQEJXB6QXHHNYH6FWHS8P", "Profesorius", "Profesorius_24", 2.4199999999999999 },
                    { "01J9DYQEJXCW47NR0S5RMNBWE5", "Docento, pripažinto menininko, o taip pat AT pritarimu vieneriems metams priimamam asmeniui, turinčiam didelę praktinę patirtį dėstomo dalyko srityje ir magistro kvalifikacinį laipsnį ar jam prilygintą aukštojo mokslo kvalifikaciją", "Docentas_menininkas_23", 1.77 },
                    { "01J9DYQEJXEGZKC667HYJWDCGW", "Profesorius", "Profesorius_23", 2.4199999999999999 },
                    { "01J9DYQEJXJ2C7HAZ0ZKBX6Z18", "Lektorius", "Lektorius_23 (d)", 1.6000000000000001 },
                    { "01J9DYQEJXJKTCQQCQFPX6QGGC", "Jaunesnysis asistentas", "Jaunesnysis asistentas_24", 1.78 },
                    { "01J9DYQEJXPDVA8CV13VXV9C4F", "Kviestinis docentas", "Docentas_Kv_24", 2.02 },
                    { "01J9DYQEJXPFBF9A2M4WHEQBFQ", "Kviestinis profesorius", "Profesorius_Kv_24", 2.4199999999999999 },
                    { "01J9DYQEJXR995PY06ZACP236R", "Docentas", "Docentas_24", 2.02 },
                    { "01J9DYQEJXRWCKNZ922ZYWMXYY", "Vyresnysis lektorius", "Vyresnysis lektorius_24", 1.72 },
                    { "01J9DYQEJXSRHTS6MGNF83K0AJ", "Docento, turinčio mokslo daktaro laipsnį", "Docentas_23", 2.02 },
                    { "01J9DYQEJXSRJTY310G1Y6QGAG", "Asistento, turinčio bakalauro arba profesinio bakalauro laipsnį", "Asistentas_23 (bak.)", 1.3100000000000001 },
                    { "01J9DYQEJXXWASW96HPZD26JHB", "Lektorius", "Lektorius_24", 1.6000000000000001 }
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
                    { "01J9DYQEJX63QCPHMYZEMTVQ0F", "t.liogiene@eif.viko.lt", "01J9DYQEJXBSHVG5K2FSCJK91V", "Informacinių sistemų katedra", "ISK" },
                    { "01J9DYQEJX68GAWTMJ58XA9MZ5", "a.kirdeikiene@eif.viko.lt", "01J9DYQEJXBSHVG5K2FSCJK91V", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" },
                    { "01J9DYQEJXV9YH477ZVSHXNAGW", "j.zailskas@eif.viko.lt", "01J9DYQEJXBSHVG5K2FSCJK91V", "Programinės įrangos katedra", "PĮK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J9DYQEJX1PCG4GRQV3HTBFDR", "01J9DYQEJX68GAWTMJ58XA9MZ5", "Elektronikos inžinerija", 2 },
                    { "01J9DYQEJX2H3Z4W2QFCDBMHCJ", "01J9DYQEJX68GAWTMJ58XA9MZ5", "Elektronikos inžinerija", 1 },
                    { "01J9DYQEJX44AP7MHAAWMBCM73", "01J9DYQEJXV9YH477ZVSHXNAGW", "Programų sistemos", 4 },
                    { "01J9DYQEJX9DHTHTPM9S02X94V", "01J9DYQEJXV9YH477ZVSHXNAGW", "Programų sistemos", 1 },
                    { "01J9DYQEJXJBMG4F2K0BE48RJH", "01J9DYQEJXV9YH477ZVSHXNAGW", "Programinės įrangos testavimas", 1 },
                    { "01J9DYQEJXKZFDFMJPA6BMGP0N", "01J9DYQEJXV9YH477ZVSHXNAGW", "Programų sistemos", 2 },
                    { "01J9DYQEJXSXBSET1Y0VBS77JJ", "01J9DYQEJX63QCPHMYZEMTVQ0F", "Informacijos sistemos", 3 },
                    { "01J9DYQEJXT7AWYWA72WH5WFN9", "01J9DYQEJXV9YH477ZVSHXNAGW", "Programų sistemos", 3 },
                    { "01J9DYQEJXV9EG5CJ4T3SX195G", "01J9DYQEJX63QCPHMYZEMTVQ0F", "Informacijos sistemos", 1 },
                    { "01J9DYQEJXWS07ZH806H3WZ46V", "01J9DYQEJX68GAWTMJ58XA9MZ5", "Kompiuterių inžinerija", 1 },
                    { "01J9DYQEJXX7MYFE4EH3K97RM2", "01J9DYQEJX63QCPHMYZEMTVQ0F", "Informacijos sistemos", 2 },
                    { "01J9DYQEJXY2CM0EC2BT8JBHRH", "01J9DYQEJX68GAWTMJ58XA9MZ5", "Kompiuterių inžinerija", 2 }
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
                name: "IX_Lecturers_PlannedSubjectId",
                table: "Lecturers",
                column: "PlannedSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_PositionId",
                table: "Lecturers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedGroups_LecturerId",
                table: "PlannedGroups",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedGroups_StudyProgramId",
                table: "PlannedGroups",
                column: "StudyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSubjects_DepartmentId",
                table: "PlannedSubjects",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSubjects_PlanId",
                table: "PlannedSubjects",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSubjects_PlannedGroupId",
                table: "PlannedSubjects",
                column: "PlannedGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedSubjects_StudyProgramId",
                table: "PlannedSubjects",
                column: "StudyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyPrograms_DepartmentId",
                table: "StudyPrograms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectLecturers_SubjectsId",
                table: "SubjectLecturers",
                column: "SubjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DepartmentId",
                table: "Subjects",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_StudyProgramId",
                table: "Subjects",
                column: "StudyProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_PlannedSubjects_PlannedSubjectId",
                table: "Lecturers",
                column: "PlannedSubjectId",
                principalTable: "PlannedSubjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Departments_DepartmentId",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_PlannedSubjects_Departments_DepartmentId",
                table: "PlannedSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_StudyPrograms_Departments_DepartmentId",
                table: "StudyPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_PlannedSubjects_PlannedSubjectId",
                table: "Lecturers");

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
                name: "SubjectLecturers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "PlannedSubjects");

            migrationBuilder.DropTable(
                name: "PlannedGroups");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "StudyPrograms");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
