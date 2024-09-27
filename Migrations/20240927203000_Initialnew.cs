using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyPlannerSoft.Migrations
{
    /// <inheritdoc />
    public partial class Initialnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KN2G190AGQABB7AKMW");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KN6EP6J5QEQBCYSRH1");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNB004XT48DQFFHX1S");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNCCCFFRX3S5ESEHTZ");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNF388XPFC3ZBT9KNE");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNFCRVTVRK128MQ3W5");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNG7FCWMT4Y7965RHN");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNM6HSHK77C0ET3B1F");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNWD3VGJJGC4AQRSNX");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KN1RNXGZHBHNGYH9Q8");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KN2DAZVT19P7M0ARD4");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KN388X90J3Z17NVHP1");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KN4CRB6EYSMEVKJA4N");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KN95NTXK5AZCCT499P");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNGE5JDQCMNZWX9AV2");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNHS7WNB1149HY3H8H");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNQH5ZCR83C0QD3YNW");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNV2RQC8EYHRPS7H5B");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNWFJ2K88K40A78FV8");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNX5FKSK7BK626EMSE");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8FT59KNX6HW5PXAWARPEZDG");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8FT59KN56MKEC8H4XQJ4G00");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8FT59KNQDPP7SSBBSXZQB16");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8FT59KNS2XAEKPF5KPJMZ04");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8FT59KNCNHGTPWS257NSRT7");

            migrationBuilder.DropColumn(
                name: "EvaluationFormShort",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectTypeCategoryDescription",
                table: "Subjects");

            migrationBuilder.AlterColumn<double>(
                name: "OtherNonContactCount",
                table: "Subjects",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "OtherContactHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "GradingHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Subjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "Subjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CourseWorkHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExamHours",
                table: "Subjects",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HomeworkHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PracticeReportHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RemoteTeachingHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8TJT5031ZMFHPX215ENRK6X", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8TJT5033YCH8CB075M42TZ0", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8TJT5034Y7EKPPWZ8Q7N332", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8TJT5038239783RARNNVM29", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8TJT5038Y9NZ4DSMETJWVX6", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8TJT503943HGF79CRYC6AR5", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8TJT503CZYM0FVHVG9SZ3KP", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8TJT503DD053D6HF2HPSN6M", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8TJT503G05PBDJE3ZZYFXPH", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8TJT503QVVENTA07PC5P0VN", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8TJT50332NCPBJ795KDYJCS", "j.zailskas@eif.viko.lt", "01J8TJT503CZYM0FVHVG9SZ3KP", "Programinės įrangos katedra", "PĮK" },
                    { "01J8TJT503SFQ0XAYSFM1EDJF1", "t.liogiene@eif.viko.lt", "01J8TJT503CZYM0FVHVG9SZ3KP", "Informacinių sistemų katedra", "ISK" },
                    { "01J8TJT503ZRN595B9KQ7B0TDA", "a.kirdeikiene@eif.viko.lt", "01J8TJT503CZYM0FVHVG9SZ3KP", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8TJT5031DE2EQWX9XA6N3ZC", "01J8TJT503SFQ0XAYSFM1EDJF1", "Informacijos sistemos", 1 },
                    { "01J8TJT5031JH5WHPGJA3BNZCM", "01J8TJT503ZRN595B9KQ7B0TDA", "Kompiuterių inžinerija", 1 },
                    { "01J8TJT5036GRA3M99AKTEAAZZ", "01J8TJT503ZRN595B9KQ7B0TDA", "Elektronikos inžinerija", 2 },
                    { "01J8TJT503B0YD1E38CQFEE5S0", "01J8TJT50332NCPBJ795KDYJCS", "Programinės įrangos testavimas", 1 },
                    { "01J8TJT503F9BRZ1Q2FRCGYTD6", "01J8TJT50332NCPBJ795KDYJCS", "Programų sistemos", 3 },
                    { "01J8TJT503HWDY3S6X7RV2H3V5", "01J8TJT50332NCPBJ795KDYJCS", "Programų sistemos", 4 },
                    { "01J8TJT503Q8593MDX7VHKM3SQ", "01J8TJT50332NCPBJ795KDYJCS", "Programų sistemos", 2 },
                    { "01J8TJT503SRAFFW37R8B28AV6", "01J8TJT503SFQ0XAYSFM1EDJF1", "Informacijos sistemos", 3 },
                    { "01J8TJT503VPVB3C8RBPPJFZ5G", "01J8TJT503ZRN595B9KQ7B0TDA", "Kompiuterių inžinerija", 2 },
                    { "01J8TJT503VV8M2S2SDETBWF0Y", "01J8TJT50332NCPBJ795KDYJCS", "Programų sistemos", 1 },
                    { "01J8TJT503XAKW7981Q6AKJNM9", "01J8TJT503ZRN595B9KQ7B0TDA", "Elektronikos inžinerija", 1 },
                    { "01J8TJT503Y7F24Z8G0QDJ22E7", "01J8TJT503SFQ0XAYSFM1EDJF1", "Informacijos sistemos", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT5031ZMFHPX215ENRK6X");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT5033YCH8CB075M42TZ0");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT5034Y7EKPPWZ8Q7N332");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT5038239783RARNNVM29");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT5038Y9NZ4DSMETJWVX6");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT503943HGF79CRYC6AR5");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT503DD053D6HF2HPSN6M");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT503G05PBDJE3ZZYFXPH");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT503QVVENTA07PC5P0VN");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT5031DE2EQWX9XA6N3ZC");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT5031JH5WHPGJA3BNZCM");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT5036GRA3M99AKTEAAZZ");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503B0YD1E38CQFEE5S0");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503F9BRZ1Q2FRCGYTD6");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503HWDY3S6X7RV2H3V5");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503Q8593MDX7VHKM3SQ");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503SRAFFW37R8B28AV6");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503VPVB3C8RBPPJFZ5G");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503VV8M2S2SDETBWF0Y");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503XAKW7981Q6AKJNM9");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8TJT503Y7F24Z8G0QDJ22E7");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8TJT50332NCPBJ795KDYJCS");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8TJT503SFQ0XAYSFM1EDJF1");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8TJT503ZRN595B9KQ7B0TDA");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8TJT503CZYM0FVHVG9SZ3KP");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CourseWorkHoursCount",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ExamHours",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "HomeworkHoursCount",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "PracticeReportHoursCount",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "RemoteTeachingHoursCount",
                table: "Subjects");

            migrationBuilder.AlterColumn<double>(
                name: "OtherNonContactCount",
                table: "Subjects",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "OtherContactHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GradingHoursCount",
                table: "Subjects",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationFormShort",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubjectTypeCategoryDescription",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8FT59KN2G190AGQABB7AKMW", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8FT59KN6EP6J5QEQBCYSRH1", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8FT59KNB004XT48DQFFHX1S", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J8FT59KNCCCFFRX3S5ESEHTZ", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8FT59KNCNHGTPWS257NSRT7", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8FT59KNF388XPFC3ZBT9KNE", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8FT59KNFCRVTVRK128MQ3W5", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8FT59KNG7FCWMT4Y7965RHN", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8FT59KNM6HSHK77C0ET3B1F", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8FT59KNWD3VGJJGC4AQRSNX", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8FT59KN56MKEC8H4XQJ4G00", "j.zailskas@eif.viko.lt", "01J8FT59KNCNHGTPWS257NSRT7", "Programinės įrangos katedra", "PĮK" },
                    { "01J8FT59KNQDPP7SSBBSXZQB16", "a.kirdeikiene@eif.viko.lt", "01J8FT59KNCNHGTPWS257NSRT7", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" },
                    { "01J8FT59KNS2XAEKPF5KPJMZ04", "t.liogiene@eif.viko.lt", "01J8FT59KNCNHGTPWS257NSRT7", "Informacinių sistemų katedra", "ISK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8FT59KN1RNXGZHBHNGYH9Q8", "01J8FT59KN56MKEC8H4XQJ4G00", "Programų sistemos", 4 },
                    { "01J8FT59KN2DAZVT19P7M0ARD4", "01J8FT59KNQDPP7SSBBSXZQB16", "Kompiuterių inžinerija", 2 },
                    { "01J8FT59KN388X90J3Z17NVHP1", "01J8FT59KNS2XAEKPF5KPJMZ04", "Informacijos sistemos", 3 },
                    { "01J8FT59KN4CRB6EYSMEVKJA4N", "01J8FT59KN56MKEC8H4XQJ4G00", "Programų sistemos", 1 },
                    { "01J8FT59KN95NTXK5AZCCT499P", "01J8FT59KNQDPP7SSBBSXZQB16", "Kompiuterių inžinerija", 1 },
                    { "01J8FT59KNGE5JDQCMNZWX9AV2", "01J8FT59KNQDPP7SSBBSXZQB16", "Elektronikos inžinerija", 2 },
                    { "01J8FT59KNHS7WNB1149HY3H8H", "01J8FT59KN56MKEC8H4XQJ4G00", "Programų sistemos", 2 },
                    { "01J8FT59KNQH5ZCR83C0QD3YNW", "01J8FT59KN56MKEC8H4XQJ4G00", "Programų sistemos", 3 },
                    { "01J8FT59KNV2RQC8EYHRPS7H5B", "01J8FT59KN56MKEC8H4XQJ4G00", "Programinės įrangos testavimas", 1 },
                    { "01J8FT59KNWFJ2K88K40A78FV8", "01J8FT59KNS2XAEKPF5KPJMZ04", "Informacijos sistemos", 1 },
                    { "01J8FT59KNX5FKSK7BK626EMSE", "01J8FT59KNQDPP7SSBBSXZQB16", "Elektronikos inžinerija", 1 },
                    { "01J8FT59KNX6HW5PXAWARPEZDG", "01J8FT59KNS2XAEKPF5KPJMZ04", "Informacijos sistemos", 2 }
                });
        }
    }
}
