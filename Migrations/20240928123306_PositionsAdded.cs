using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyPlannerSoft.Migrations
{
    /// <inheritdoc />
    public partial class PositionsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE5V3GDVGQ1WE23Y8G");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE72Z6K5BACB4PH73G");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEABBPVAGDFB5C8F91");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEDB419ZWVQA18E0A1");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEE2EP44S0FKVB9CT3");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEFB80SD0ZQKAFZ293");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJETN84GR18CQ60FR35");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEVQJXGY1VJG6TASZT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEZ6RXY9149FWEMAB5");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEEFM1PPND0VYFZ68Q");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W2TVJESVNWGJ82ATQ52PFE");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE1R10SF27MQ69T1ZY");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE2ZNJE3T33MZJNPXZ");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE3F47K4N9N4XFMGFE");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE3JVG0EXTP88TWS8N");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE89KE2X65EFDHVDDW");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE92M0XWVVACEGQD1P");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEA1HKBBNFJRR411A8");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJENY5C2BRW0QSEB8HD");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEPF67KY2E08ZMMA9B");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEPT9546YQGPD14A69");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEQ06N16FBFPW72KRC");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W2TVJESJKASAFHZYXX728G");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W2TVJE15DPDWHDM94SPF5Y");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEQ20DCNB1SCYC4ETY");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEXR4D3EQRJ84FGAW4");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W2TVJEMFR77BG4RS58X63Z");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01H6N7NV2P1KCVKY7F6EJH0FAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f33e6a0f-bea2-4915-a790-880211f25a10", "AQAAAAIAAYagAAAAEDWMbXxKv1MztljkplF3pnHtkgZ6Lrq4p6JBlA/ZaCKrgbJe3X6fNJKTsd3JUGyEig==", "97fcad78-ad33-42a9-a5f7-bceb30d756aa" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8W9XMWJ0VTKTD04PGMYB348", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J8W9XMWJ4NGXSZV0GMQAA9ZR", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8W9XMWJ4P2JW7ZZKQXXJG96", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8W9XMWJAJF0WMCAQCPM1W9B", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J8W9XMWJD6J2229K0N5V8Q3G", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8W9XMWJDARAH2CNJP5YNFTH", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8W9XMWJDQ19FE1TB9AA5HAA", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8W9XMWJDS0DBH99V57BRN98", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8W9XMWJN0JN0PG13DCP8QW2", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8W9XMWJRB59FBYX5BANQHJ7", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J8W9XMWJ0D52D4AY34K3VBVM", "Lektorius", "Lektorius_23 (m)", 1.4299999999999999 },
                    { "01J8W9XMWJ4CTZ33QXV1R8BA38", "Profesorius", "Profesorius_24", 2.4199999999999999 },
                    { "01J8W9XMWJ4XS1E74K28BZ17K3", "Lektoriaus, turinčio mokslo daktaro laipsnį", "Lektorius dr._23", 1.72 },
                    { "01J8W9XMWJ9XRJ8K8FZ3X91006", "Asistento, turinčio magistro laipsnį", "Asistentas_23 (mag.)", 1.3300000000000001 },
                    { "01J8W9XMWJA2J9CBWDEB06SDN0", "Asistento, turinčio bakalauro arba profesinio bakalauro laipsnį", "Asistentas_23 (bak.)", 1.3100000000000001 },
                    { "01J8W9XMWJCAWACKTXMQY3K1A5", "Jaunesnysis asistentas", "Jaunesnysis asistentas_24", 1.78 },
                    { "01J8W9XMWJCMY65RHDB2BNG36Z", "Docento, pripažinto menininko, o taip pat AT pritarimu vieneriems metams priimamam asmeniui, turinčiam didelę praktinę patirtį dėstomo dalyko srityje ir magistro kvalifikacinį laipsnį ar jam prilygintą aukštojo mokslo kvalifikaciją", "Docentas_menininkas_23", 1.77 },
                    { "01J8W9XMWJF7H9C25DREXVHRFZ", "Dėstytojas praktikas", "Dėstytojas praktikas_24", 1.72 },
                    { "01J8W9XMWJGHR9TAK45PBWHVRH", "Profesorius", "Profesorius_23", 2.4199999999999999 },
                    { "01J8W9XMWJM9ZZBSX8ZSWPEE41", "Kviestinis profesorius", "Profesorius_Kv_24", 2.4199999999999999 },
                    { "01J8W9XMWJPFGEY3DA3N6PJZ4S", "Vyresnysis lektorius", "Vyresnysis lektorius_24", 1.72 },
                    { "01J8W9XMWJR7V8MH2PXFBCQ1TR", "Docento, turinčio mokslo daktaro laipsnį", "Docentas_23", 2.02 },
                    { "01J8W9XMWJRPPA5F96D7Z0B2TE", "Lektorius", "Lektorius_24", 1.6000000000000001 },
                    { "01J8W9XMWJRSTRT3D1CDPS1KBR", "Lektorius", "Lektorius_23 (d)", 1.6000000000000001 },
                    { "01J8W9XMWJS66QV4TJVYJS4MQB", "Docentas", "Docentas_24", 2.02 },
                    { "01J8W9XMWJS9TG5SK22E2D3KH3", "Asistentas", "Asistentas_24", 1.8400000000000001 },
                    { "01J8W9XMWJVXVD6D97YJ7VMK4B", "Kviestinis docentas", "Docentas_Kv_24", 2.02 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8W9XMWJ9MED13FWS15SA5QZ", "j.zailskas@eif.viko.lt", "01J8W9XMWJ0VTKTD04PGMYB348", "Programinės įrangos katedra", "PĮK" },
                    { "01J8W9XMWJGXNN75CBGXPWJJC5", "t.liogiene@eif.viko.lt", "01J8W9XMWJ0VTKTD04PGMYB348", "Informacinių sistemų katedra", "ISK" },
                    { "01J8W9XMWJJM5ZB7JG176YE8EA", "a.kirdeikiene@eif.viko.lt", "01J8W9XMWJ0VTKTD04PGMYB348", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8W9XMWJ0PACW5MGAA58S1JM", "01J8W9XMWJGXNN75CBGXPWJJC5", "Informacijos sistemos", 1 },
                    { "01J8W9XMWJ54PQA5WPKNC26JVK", "01J8W9XMWJGXNN75CBGXPWJJC5", "Informacijos sistemos", 2 },
                    { "01J8W9XMWJ9R7HN72XT0CY0RH8", "01J8W9XMWJJM5ZB7JG176YE8EA", "Kompiuterių inžinerija", 1 },
                    { "01J8W9XMWJAGX5RHH00AKY382Q", "01J8W9XMWJGXNN75CBGXPWJJC5", "Informacijos sistemos", 3 },
                    { "01J8W9XMWJEWET9AB9V8KM5A11", "01J8W9XMWJ9MED13FWS15SA5QZ", "Programų sistemos", 2 },
                    { "01J8W9XMWJG7548N8MRZXZ5G5Y", "01J8W9XMWJ9MED13FWS15SA5QZ", "Programų sistemos", 1 },
                    { "01J8W9XMWJJ8TPS5SENAFE8G39", "01J8W9XMWJ9MED13FWS15SA5QZ", "Programinės įrangos testavimas", 1 },
                    { "01J8W9XMWJJAYEGVG6P8QX1XQ3", "01J8W9XMWJJM5ZB7JG176YE8EA", "Elektronikos inžinerija", 1 },
                    { "01J8W9XMWJJQF5Y6SBGX0491EW", "01J8W9XMWJ9MED13FWS15SA5QZ", "Programų sistemos", 4 },
                    { "01J8W9XMWJP1T2CQGT5CCWMXJK", "01J8W9XMWJJM5ZB7JG176YE8EA", "Kompiuterių inžinerija", 2 },
                    { "01J8W9XMWJVH2RJ3NKQWZ3Z066", "01J8W9XMWJ9MED13FWS15SA5QZ", "Programų sistemos", 3 },
                    { "01J8W9XMWJW045S0W50CF8CFZG", "01J8W9XMWJJM5ZB7JG176YE8EA", "Elektronikos inžinerija", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ4NGXSZV0GMQAA9ZR");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ4P2JW7ZZKQXXJG96");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJAJF0WMCAQCPM1W9B");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJD6J2229K0N5V8Q3G");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJDARAH2CNJP5YNFTH");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJDQ19FE1TB9AA5HAA");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJDS0DBH99V57BRN98");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJN0JN0PG13DCP8QW2");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJRB59FBYX5BANQHJ7");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ0D52D4AY34K3VBVM");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ4CTZ33QXV1R8BA38");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ4XS1E74K28BZ17K3");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ9XRJ8K8FZ3X91006");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJA2J9CBWDEB06SDN0");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJCAWACKTXMQY3K1A5");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJCMY65RHDB2BNG36Z");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJF7H9C25DREXVHRFZ");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJGHR9TAK45PBWHVRH");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJM9ZZBSX8ZSWPEE41");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJPFGEY3DA3N6PJZ4S");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJR7V8MH2PXFBCQ1TR");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJRPPA5F96D7Z0B2TE");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJRSTRT3D1CDPS1KBR");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJS66QV4TJVYJS4MQB");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJS9TG5SK22E2D3KH3");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJVXVD6D97YJ7VMK4B");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ0PACW5MGAA58S1JM");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ54PQA5WPKNC26JVK");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ9R7HN72XT0CY0RH8");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJAGX5RHH00AKY382Q");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJEWET9AB9V8KM5A11");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJG7548N8MRZXZ5G5Y");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJJ8TPS5SENAFE8G39");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJJAYEGVG6P8QX1XQ3");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJJQF5Y6SBGX0491EW");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJP1T2CQGT5CCWMXJK");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJVH2RJ3NKQWZ3Z066");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJW045S0W50CF8CFZG");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ9MED13FWS15SA5QZ");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJGXNN75CBGXPWJJC5");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJJM5ZB7JG176YE8EA");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8W9XMWJ0VTKTD04PGMYB348");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01H6N7NV2P1KCVKY7F6EJH0FAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf69eed6-ac77-4979-9452-9e10e807a71c", "AQAAAAIAAYagAAAAEHJNcSUm3igslMLPfx7bEcZjEjj0Sa+ZMgTYLAKu404YDO/ncJC+Lr7dNg4laDfIlA==", "5c946b96-e231-4605-8d6d-1c05669617da" });

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
        }
    }
}
