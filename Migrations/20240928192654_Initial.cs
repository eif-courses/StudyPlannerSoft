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
                    SubGroupCount = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, defaultValue: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlannedGroups_StudyPrograms_StudyProgramId",
                        column: x => x.StudyProgramId,
                        principalTable: "StudyPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                values: new object[] { "01H6N7NV2P1KCVKY7F6EJH0FAF", 0, "b873b212-9428-43b2-995b-2ac547786a4c", "admin@viko.lt", true, "Red", false, null, "ADMIN@VIKO.LT", "ADMIN@VIKO.LT", "AQAAAAIAAYagAAAAEMJxJeC0xqu+zVdZPar5c5gx6JHiyajsWVWNSF5lHZH+v2JAdnx7oQJWTIpusahMGw==", null, false, "aaafb56d-9dc4-4ee6-9330-f1108f8932d9", false, "admin@viko.lt" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8X1KBN428W8N59FJQKSEVST", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8X1KBN4339KFM8DCRYM8TBR", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8X1KBN438MMGB0EX4B9FP8S", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8X1KBN448HBP2F6XH4WB5YW", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J8X1KBN45G1PCJR79V148SAG", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8X1KBN4728FWH3T8QZSGYJ2", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8X1KBN47HH85X9NXYQJNN2Z", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8X1KBN49G2DTX29D59B40J1", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8X1KBN4T3HXAEBYQSJH73PX", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8X1KBN4WCBS1C9DGTRB1JQV", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J8X1KBN40C1840N0J8RMSW1P", "Kviestinis profesorius", "Profesorius_Kv_24", 2.4199999999999999 },
                    { "01J8X1KBN40X32BMEQE919MN1C", "Lektorius", "Lektorius_23 (m)", 1.4299999999999999 },
                    { "01J8X1KBN41QFT2933X1BPMG9X", "Asistento, turinčio bakalauro arba profesinio bakalauro laipsnį", "Asistentas_23 (bak.)", 1.3100000000000001 },
                    { "01J8X1KBN423YTN294GEW2C8MQ", "Vyresnysis lektorius", "Vyresnysis lektorius_24", 1.72 },
                    { "01J8X1KBN42DB3RSTX9H3EGBCA", "Profesorius", "Profesorius_24", 2.4199999999999999 },
                    { "01J8X1KBN42XWYWBYZ48W64TR9", "Lektorius", "Lektorius_24", 1.6000000000000001 },
                    { "01J8X1KBN47CQA4DZ8DDGC6G1H", "Profesorius", "Profesorius_23", 2.4199999999999999 },
                    { "01J8X1KBN4A66M7335Q92A1QV8", "Dėstytojas praktikas", "Dėstytojas praktikas_24", 1.72 },
                    { "01J8X1KBN4C91HQGM8Z8VRXTZY", "Docento, pripažinto menininko, o taip pat AT pritarimu vieneriems metams priimamam asmeniui, turinčiam didelę praktinę patirtį dėstomo dalyko srityje ir magistro kvalifikacinį laipsnį ar jam prilygintą aukštojo mokslo kvalifikaciją", "Docentas_menininkas_23", 1.77 },
                    { "01J8X1KBN4DQXMPY58D37HC67W", "Kviestinis docentas", "Docentas_Kv_24", 2.02 },
                    { "01J8X1KBN4F7308MM5GB3SW763", "Lektoriaus, turinčio mokslo daktaro laipsnį", "Lektorius dr._23", 1.72 },
                    { "01J8X1KBN4G0BAQYGXZ2NFV5DY", "Asistentas", "Asistentas_24", 1.8400000000000001 },
                    { "01J8X1KBN4H5YNBBJ561PD83AD", "Docentas", "Docentas_24", 2.02 },
                    { "01J8X1KBN4JT9FMPSP36VH8WYF", "Lektorius", "Lektorius_23 (d)", 1.6000000000000001 },
                    { "01J8X1KBN4KY9V3P4XN0CEKTDB", "Docento, turinčio mokslo daktaro laipsnį", "Docentas_23", 2.02 },
                    { "01J8X1KBN4PB2KR2RY350CC153", "Jaunesnysis asistentas", "Jaunesnysis asistentas_24", 1.78 },
                    { "01J8X1KBN4X547E9KT08DPPG0G", "Asistento, turinčio magistro laipsnį", "Asistentas_23 (mag.)", 1.3300000000000001 }
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
                    { "01J8X1KBN4J24F0W9Y0VYJ20MY", "a.kirdeikiene@eif.viko.lt", "01J8X1KBN45G1PCJR79V148SAG", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" },
                    { "01J8X1KBN4P31VTJP709FK63D9", "j.zailskas@eif.viko.lt", "01J8X1KBN45G1PCJR79V148SAG", "Programinės įrangos katedra", "PĮK" },
                    { "01J8X1KBN4PG51SNTYRBPTBVHH", "t.liogiene@eif.viko.lt", "01J8X1KBN45G1PCJR79V148SAG", "Informacinių sistemų katedra", "ISK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8X1KBN43WV87VKAHAZZ6MX9", "01J8X1KBN4P31VTJP709FK63D9", "Programų sistemos", 1 },
                    { "01J8X1KBN45GHZD6B59W0XRFVP", "01J8X1KBN4P31VTJP709FK63D9", "Programų sistemos", 4 },
                    { "01J8X1KBN47WJA5NY43HGRZ3VV", "01J8X1KBN4J24F0W9Y0VYJ20MY", "Kompiuterių inžinerija", 2 },
                    { "01J8X1KBN49GHGXZCDZZ80GS1V", "01J8X1KBN4J24F0W9Y0VYJ20MY", "Kompiuterių inžinerija", 1 },
                    { "01J8X1KBN4A1Y7MT6G98T16ZNR", "01J8X1KBN4PG51SNTYRBPTBVHH", "Informacijos sistemos", 1 },
                    { "01J8X1KBN4A82C9F3GWTPNPBAE", "01J8X1KBN4J24F0W9Y0VYJ20MY", "Elektronikos inžinerija", 1 },
                    { "01J8X1KBN4DC4KAGKRFY02BG2X", "01J8X1KBN4J24F0W9Y0VYJ20MY", "Elektronikos inžinerija", 2 },
                    { "01J8X1KBN4M2A459YPTDPM75JY", "01J8X1KBN4P31VTJP709FK63D9", "Programų sistemos", 3 },
                    { "01J8X1KBN4Q913BSYZVGXZRPM9", "01J8X1KBN4PG51SNTYRBPTBVHH", "Informacijos sistemos", 3 },
                    { "01J8X1KBN4WA39JT8R57ZFM1GN", "01J8X1KBN4P31VTJP709FK63D9", "Programinės įrangos testavimas", 1 },
                    { "01J8X1KBN4WWK4TG26K4CH2NSG", "01J8X1KBN4P31VTJP709FK63D9", "Programų sistemos", 2 },
                    { "01J8X1KBN4XGFSHXRA2MJN36ED", "01J8X1KBN4PG51SNTYRBPTBVHH", "Informacijos sistemos", 2 }
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
