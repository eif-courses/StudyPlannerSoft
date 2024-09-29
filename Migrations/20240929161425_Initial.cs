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
                name: "PlannedGroups",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Semester = table.Column<int>(type: "integer", nullable: false),
                    Vf = table.Column<int>(type: "integer", nullable: true),
                    Vnf = table.Column<int>(type: "integer", nullable: true),
                    OtherType = table.Column<int>(type: "integer", nullable: true),
                    LabelName = table.Column<string>(type: "text", nullable: true),
                    StudyProgramId = table.Column<string>(type: "text", nullable: false),
                    LecturerId = table.Column<string>(type: "text", nullable: false),
                    SubGroupCount = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, defaultValue: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedGroups_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlannedGroups_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
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
                values: new object[] { "01H6N7NV2P1KCVKY7F6EJH0FAF", 0, "e91835f5-d69a-47da-8db5-fd70a04e0a39", "admin@viko.lt", true, "Red", false, null, "ADMIN@VIKO.LT", "ADMIN@VIKO.LT", "AQAAAAIAAYagAAAAECkz8EQq83ElXWyhdfnFjv/GleD38Z6SejzlhocdxmDcPMAdcmTl9t+OKfzR8atQiw==", null, false, "5d9e1ac4-7ae4-4e6e-9751-9f4bed898c23", false, "admin@viko.lt" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8Z8ZKFF0H626YY5HXZZSAJ2", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8Z8ZKFF47RH28PWDH1QAZWN", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8Z8ZKFF4X08W81T3HD82H8K", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8Z8ZKFF8PBXY7ZF78R8NJZN", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8Z8ZKFFAEBWS60A6YDRKEHE", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8Z8ZKFFKNFNA2KATHDMB4SR", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8Z8ZKFFPFEV3Z1FG1Q2EMMG", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8Z8ZKFFQQSEQ1CCAP81M1AZ", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8Z8ZKFFTSB4G3ZEJVHY0DZR", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8Z8ZKFFWD67VRYT3R3R37HQ", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J8Z8ZKFF45AM7VV0MV3NBYAV", "Kviestinis profesorius", "Profesorius_Kv_24", 2.4199999999999999 },
                    { "01J8Z8ZKFF45HXHJBRR2M8M0ZB", "Asistento, turinčio bakalauro arba profesinio bakalauro laipsnį", "Asistentas_23 (bak.)", 1.3100000000000001 },
                    { "01J8Z8ZKFF4AZKA7Z37SJZQPNS", "Dėstytojas praktikas", "Dėstytojas praktikas_24", 1.72 },
                    { "01J8Z8ZKFF4Y26RYA99GZ1KPVS", "Profesorius", "Profesorius_23", 2.4199999999999999 },
                    { "01J8Z8ZKFF79695J0NH540RVZ9", "Vyresnysis lektorius", "Vyresnysis lektorius_24", 1.72 },
                    { "01J8Z8ZKFFBHQKR98NPTRD80RD", "Profesorius", "Profesorius_24", 2.4199999999999999 },
                    { "01J8Z8ZKFFBZH3J7EVF4Y5GVCY", "Kviestinis docentas", "Docentas_Kv_24", 2.02 },
                    { "01J8Z8ZKFFFHK5063NGHP1VXGJ", "Docentas", "Docentas_24", 2.02 },
                    { "01J8Z8ZKFFG5VXMH036VAHDMXA", "Lektoriaus, turinčio mokslo daktaro laipsnį", "Lektorius dr._23", 1.72 },
                    { "01J8Z8ZKFFJ6AFYVQ24YYYPY9W", "Jaunesnysis asistentas", "Jaunesnysis asistentas_24", 1.78 },
                    { "01J8Z8ZKFFKTRT2C5HCPN22QCX", "Docento, pripažinto menininko, o taip pat AT pritarimu vieneriems metams priimamam asmeniui, turinčiam didelę praktinę patirtį dėstomo dalyko srityje ir magistro kvalifikacinį laipsnį ar jam prilygintą aukštojo mokslo kvalifikaciją", "Docentas_menininkas_23", 1.77 },
                    { "01J8Z8ZKFFNZZKPE8KNY5AJJNN", "Lektorius", "Lektorius_24", 1.6000000000000001 },
                    { "01J8Z8ZKFFPZT611JZ5H5Z0Y09", "Asistentas", "Asistentas_24", 1.8400000000000001 },
                    { "01J8Z8ZKFFW6VM4SMEEM96VVS5", "Docento, turinčio mokslo daktaro laipsnį", "Docentas_23", 2.02 },
                    { "01J8Z8ZKFFWPZ07FZKTNY14326", "Lektorius", "Lektorius_23 (m)", 1.4299999999999999 },
                    { "01J8Z8ZKFFWZ9BFTM5341JQJFQ", "Lektorius", "Lektorius_23 (d)", 1.6000000000000001 },
                    { "01J8Z8ZKFFZJ1M5EJENP2ESWCR", "Asistento, turinčio magistro laipsnį", "Asistentas_23 (mag.)", 1.3300000000000001 }
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
                    { "01J8Z8ZKFF7Y9VJ32FK1VC0260", "t.liogiene@eif.viko.lt", "01J8Z8ZKFFTSB4G3ZEJVHY0DZR", "Informacinių sistemų katedra", "ISK" },
                    { "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "j.zailskas@eif.viko.lt", "01J8Z8ZKFFTSB4G3ZEJVHY0DZR", "Programinės įrangos katedra", "PĮK" },
                    { "01J8Z8ZKFFJNC9S2BDEZ6PHCCF", "a.kirdeikiene@eif.viko.lt", "01J8Z8ZKFFTSB4G3ZEJVHY0DZR", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8Z8ZKFF0SP33DD3T5BDYPWX", "01J8Z8ZKFF7Y9VJ32FK1VC0260", "Informacijos sistemos", 1 },
                    { "01J8Z8ZKFF72KJB0N5WQ0VPQZJ", "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "Programinės įrangos testavimas", 1 },
                    { "01J8Z8ZKFF79S8VGGPRHWXSK6J", "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "Programų sistemos", 1 },
                    { "01J8Z8ZKFFBKRQ6YB307Q8WH9J", "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "Programų sistemos", 3 },
                    { "01J8Z8ZKFFBYP9WRZJQKXTYKVE", "01J8Z8ZKFFJNC9S2BDEZ6PHCCF", "Elektronikos inžinerija", 2 },
                    { "01J8Z8ZKFFCWXJ743FXDBSDJG6", "01J8Z8ZKFFJNC9S2BDEZ6PHCCF", "Elektronikos inžinerija", 1 },
                    { "01J8Z8ZKFFDQ5172KSZPVE9TDF", "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "Programų sistemos", 2 },
                    { "01J8Z8ZKFFGGEAQGFYY21N0MZ7", "01J8Z8ZKFFJ6T6Y6QR09GDM3E1", "Programų sistemos", 4 },
                    { "01J8Z8ZKFFJBB5VZZQGMM1H44Q", "01J8Z8ZKFFJNC9S2BDEZ6PHCCF", "Kompiuterių inžinerija", 2 },
                    { "01J8Z8ZKFFNGSXX4FDAW18B9MV", "01J8Z8ZKFF7Y9VJ32FK1VC0260", "Informacijos sistemos", 3 },
                    { "01J8Z8ZKFFR93H355WFTQ4CTVJ", "01J8Z8ZKFF7Y9VJ32FK1VC0260", "Informacijos sistemos", 2 },
                    { "01J8Z8ZKFFW8FHBX8DDHVCHX7R", "01J8Z8ZKFFJNC9S2BDEZ6PHCCF", "Kompiuterių inžinerija", 1 }
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
                name: "IX_PlannedGroups_LecturerId",
                table: "PlannedGroups",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlannedGroups_StudyProgramId",
                table: "PlannedGroups",
                column: "StudyProgramId");

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
                name: "PlannedGroups");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "StudyPrograms");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
