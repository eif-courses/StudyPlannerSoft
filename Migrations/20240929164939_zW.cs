using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyPlannerSoft.Migrations
{
    /// <inheritdoc />
    public partial class zW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlannedGroups_Lecturers_LecturerId",
                table: "PlannedGroups");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF0H626YY5HXZZSAJ2");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF47RH28PWDH1QAZWN");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF4X08W81T3HD82H8K");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF8PBXY7ZF78R8NJZN");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFAEBWS60A6YDRKEHE");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFKNFNA2KATHDMB4SR");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFPFEV3Z1FG1Q2EMMG");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFQQSEQ1CCAP81M1AZ");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFWD67VRYT3R3R37HQ");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF45AM7VV0MV3NBYAV");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF45HXHJBRR2M8M0ZB");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF4AZKA7Z37SJZQPNS");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF4Y26RYA99GZ1KPVS");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF79695J0NH540RVZ9");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFBHQKR98NPTRD80RD");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFBZH3J7EVF4Y5GVCY");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFFHK5063NGHP1VXGJ");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFG5VXMH036VAHDMXA");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFJ6AFYVQ24YYYPY9W");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFKTRT2C5HCPN22QCX");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFNZZKPE8KNY5AJJNN");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFPZT611JZ5H5Z0Y09");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFW6VM4SMEEM96VVS5");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFWPZ07FZKTNY14326");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFWZ9BFTM5341JQJFQ");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFZJ1M5EJENP2ESWCR");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF0SP33DD3T5BDYPWX");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF72KJB0N5WQ0VPQZJ");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF79S8VGGPRHWXSK6J");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFBKRQ6YB307Q8WH9J");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFBYP9WRZJQKXTYKVE");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFCWXJ743FXDBSDJG6");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFDQ5172KSZPVE9TDF");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFGGEAQGFYY21N0MZ7");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFJBB5VZZQGMM1H44Q");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFNGSXX4FDAW18B9MV");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFR93H355WFTQ4CTVJ");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFW8FHBX8DDHVCHX7R");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFF7Y9VJ32FK1VC0260");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFJ6T6Y6QR09GDM3E1");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFJNC9S2BDEZ6PHCCF");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8Z8ZKFFTSB4G3ZEJVHY0DZR");

            migrationBuilder.AlterColumn<string>(
                name: "LecturerId",
                table: "PlannedGroups",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01H6N7NV2P1KCVKY7F6EJH0FAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69d7a5cd-e3f9-4f42-ad27-329bb054ce96", "AQAAAAIAAYagAAAAEMCGXDEA+BGwlF2v+IV2RVuaOPWBBMZKAhzYgdfZ8ciqm3rUu5jxxQ4wvqpt4dYQbA==", "0b3cad36-9a84-408d-954b-8dc03cbcdbdd" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8ZB03ZT022C4NQV1TZS8346", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J8ZB03ZT0WJN89NGVWEF26YY", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J8ZB03ZT3MDNF7KHKS2XP52E", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J8ZB03ZTH1CMDBP5H2698A5D", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J8ZB03ZTHQN5P86JJVM25KB9", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J8ZB03ZTN0YXRPC9N5DPPGJT", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" },
                    { "01J8ZB03ZTPDZP0YWBFVBDMMD8", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J8ZB03ZTTBEWG4WSWXKRXHGP", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J8ZB03ZTV6FP184B1V4QYCW3", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J8ZB03ZTVQP9SSRKVW0WZSG2", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name", "Pab" },
                values: new object[,]
                {
                    { "01J8ZB03ZT2P9HKVGZ3YGWVGJM", "Kviestinis profesorius", "Profesorius_Kv_24", 2.4199999999999999 },
                    { "01J8ZB03ZT3ZQEZJ6FT0W5CWYH", "Asistento, turinčio magistro laipsnį", "Asistentas_23 (mag.)", 1.3300000000000001 },
                    { "01J8ZB03ZT4130Q431KM5QDHV4", "Docento, turinčio mokslo daktaro laipsnį", "Docentas_23", 2.02 },
                    { "01J8ZB03ZTAJF8WHT5HEFSPP69", "Docentas", "Docentas_24", 2.02 },
                    { "01J8ZB03ZTB1WV529WW20X3FWY", "Jaunesnysis asistentas", "Jaunesnysis asistentas_24", 1.78 },
                    { "01J8ZB03ZTBJ6MT2B87SXD8NA8", "Lektorius", "Lektorius_23 (m)", 1.4299999999999999 },
                    { "01J8ZB03ZTC98D5EMN9G35QGTA", "Lektorius", "Lektorius_23 (d)", 1.6000000000000001 },
                    { "01J8ZB03ZTDPSYZW83QJTH52JD", "Profesorius", "Profesorius_23", 2.4199999999999999 },
                    { "01J8ZB03ZTFQ6W8ZNJ6ES1X06H", "Lektoriaus, turinčio mokslo daktaro laipsnį", "Lektorius dr._23", 1.72 },
                    { "01J8ZB03ZTGSC8Q03B4AMH4TA4", "Profesorius", "Profesorius_24", 2.4199999999999999 },
                    { "01J8ZB03ZTHFX59K8DGKQYFHR2", "Lektorius", "Lektorius_24", 1.6000000000000001 },
                    { "01J8ZB03ZTJK5S8J1WQ2VX83NR", "Vyresnysis lektorius", "Vyresnysis lektorius_24", 1.72 },
                    { "01J8ZB03ZTK8B3FWNG7FAVXDZK", "Dėstytojas praktikas", "Dėstytojas praktikas_24", 1.72 },
                    { "01J8ZB03ZTXB3B6CX8027A37PH", "Docento, pripažinto menininko, o taip pat AT pritarimu vieneriems metams priimamam asmeniui, turinčiam didelę praktinę patirtį dėstomo dalyko srityje ir magistro kvalifikacinį laipsnį ar jam prilygintą aukštojo mokslo kvalifikaciją", "Docentas_menininkas_23", 1.77 },
                    { "01J8ZB03ZTXD7VDWGYJMKBSC8Z", "Asistento, turinčio bakalauro arba profesinio bakalauro laipsnį", "Asistentas_23 (bak.)", 1.3100000000000001 },
                    { "01J8ZB03ZTZEPN6HH580ZJRKZM", "Asistentas", "Asistentas_24", 1.8400000000000001 },
                    { "01J8ZB03ZTZQAPGSTKQ0D453HD", "Kviestinis docentas", "Docentas_Kv_24", 2.02 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J8ZB03ZTJT0F6C8DTSS3SYEA", "t.liogiene@eif.viko.lt", "01J8ZB03ZTVQP9SSRKVW0WZSG2", "Informacinių sistemų katedra", "ISK" },
                    { "01J8ZB03ZTJY1775RDZ246GWX8", "j.zailskas@eif.viko.lt", "01J8ZB03ZTVQP9SSRKVW0WZSG2", "Programinės įrangos katedra", "PĮK" },
                    { "01J8ZB03ZTTHSSGM0GJ6MJGNR8", "a.kirdeikiene@eif.viko.lt", "01J8ZB03ZTVQP9SSRKVW0WZSG2", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J8ZB03ZT08V1KAK96BM5F889", "01J8ZB03ZTTHSSGM0GJ6MJGNR8", "Elektronikos inžinerija", 1 },
                    { "01J8ZB03ZT916VR0BKEA03N3C9", "01J8ZB03ZTJT0F6C8DTSS3SYEA", "Informacijos sistemos", 1 },
                    { "01J8ZB03ZTBTE8FERBHRRXZHYY", "01J8ZB03ZTJY1775RDZ246GWX8", "Programinės įrangos testavimas", 1 },
                    { "01J8ZB03ZTBX0JH5JVMTWDKF7G", "01J8ZB03ZTJY1775RDZ246GWX8", "Programų sistemos", 4 },
                    { "01J8ZB03ZTC00KH6FM24J7BA1Y", "01J8ZB03ZTJY1775RDZ246GWX8", "Programų sistemos", 2 },
                    { "01J8ZB03ZTCDXGCKF73B9PDN0N", "01J8ZB03ZTTHSSGM0GJ6MJGNR8", "Kompiuterių inžinerija", 1 },
                    { "01J8ZB03ZTH84YS05013AP2EPR", "01J8ZB03ZTTHSSGM0GJ6MJGNR8", "Kompiuterių inžinerija", 2 },
                    { "01J8ZB03ZTJY0K4RC2F9JX3GE0", "01J8ZB03ZTJT0F6C8DTSS3SYEA", "Informacijos sistemos", 2 },
                    { "01J8ZB03ZTM8K1KM7Q6EGKZBW2", "01J8ZB03ZTJT0F6C8DTSS3SYEA", "Informacijos sistemos", 3 },
                    { "01J8ZB03ZTN2S5PZH5T2E6RDXB", "01J8ZB03ZTJY1775RDZ246GWX8", "Programų sistemos", 1 },
                    { "01J8ZB03ZTQEW4JT681AZ33M3B", "01J8ZB03ZTTHSSGM0GJ6MJGNR8", "Elektronikos inžinerija", 2 },
                    { "01J8ZB03ZTTHDGRGRW8TDTX58M", "01J8ZB03ZTJY1775RDZ246GWX8", "Programų sistemos", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedGroups_Lecturers_LecturerId",
                table: "PlannedGroups",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlannedGroups_Lecturers_LecturerId",
                table: "PlannedGroups");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT022C4NQV1TZS8346");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT0WJN89NGVWEF26YY");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT3MDNF7KHKS2XP52E");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTH1CMDBP5H2698A5D");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTHQN5P86JJVM25KB9");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTN0YXRPC9N5DPPGJT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTPDZP0YWBFVBDMMD8");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTTBEWG4WSWXKRXHGP");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTV6FP184B1V4QYCW3");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT2P9HKVGZ3YGWVGJM");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT3ZQEZJ6FT0W5CWYH");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT4130Q431KM5QDHV4");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTAJF8WHT5HEFSPP69");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTB1WV529WW20X3FWY");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTBJ6MT2B87SXD8NA8");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTC98D5EMN9G35QGTA");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTDPSYZW83QJTH52JD");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTFQ6W8ZNJ6ES1X06H");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTGSC8Q03B4AMH4TA4");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTHFX59K8DGKQYFHR2");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTJK5S8J1WQ2VX83NR");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTK8B3FWNG7FAVXDZK");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTXB3B6CX8027A37PH");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTXD7VDWGYJMKBSC8Z");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTZEPN6HH580ZJRKZM");

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTZQAPGSTKQ0D453HD");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT08V1KAK96BM5F889");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZT916VR0BKEA03N3C9");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTBTE8FERBHRRXZHYY");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTBX0JH5JVMTWDKF7G");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTC00KH6FM24J7BA1Y");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTCDXGCKF73B9PDN0N");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTH84YS05013AP2EPR");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTJY0K4RC2F9JX3GE0");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTM8K1KM7Q6EGKZBW2");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTN2S5PZH5T2E6RDXB");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTQEW4JT681AZ33M3B");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTTHDGRGRW8TDTX58M");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTJT0F6C8DTSS3SYEA");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTJY1775RDZ246GWX8");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTTHSSGM0GJ6MJGNR8");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J8ZB03ZTVQP9SSRKVW0WZSG2");

            migrationBuilder.AlterColumn<string>(
                name: "LecturerId",
                table: "PlannedGroups",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01H6N7NV2P1KCVKY7F6EJH0FAF",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91835f5-d69a-47da-8db5-fd70a04e0a39", "AQAAAAIAAYagAAAAECkz8EQq83ElXWyhdfnFjv/GleD38Z6SejzlhocdxmDcPMAdcmTl9t+OKfzR8atQiw==", "5d9e1ac4-7ae4-4e6e-9751-9f4bed898c23" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_PlannedGroups_Lecturers_LecturerId",
                table: "PlannedGroups",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
