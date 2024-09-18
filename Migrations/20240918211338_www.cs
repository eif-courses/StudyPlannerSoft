using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyPlannerSoft.Migrations
{
    /// <inheritdoc />
    public partial class www : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRB6KVG5CQ8SYKXAYXT");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBC00KH92RRASMG7Q7");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBCJYY7QJZ8NMTAFVF");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBGVSHWWT3G1GHQMJ9");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBKENTHS4GJFFNPRER");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBPWTW1BZ55TRF2AHM");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBVDNSGJQZDACZB0KE");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBWPXM2BVFQCNJT399");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRBWXBFBZMQZCCDGGM0");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRB04K94BEEKGDPDWKD");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRB3XE3DVW4R5BJDST6");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRB5F9GGKS8RBCC26DH");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRB88BHJE27KQGRND7B");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBG41A0QZB27P7VDF0");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBHJFJ17BY44TJ5BWG");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBMP2RXKFHR1ZRHG62");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBSDP4ZM0N8C0SJJSK");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBW9B73838P92HKZK2");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBWWQ4J9ZTY486K5YX");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBXBPYC2874Z4T09JN");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J834XSRBZ116E33W5F2H73QB");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J834XSRB7WRPGXYG8HKS95KG");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J834XSRBFJF2RTCB4KKEF3Y0");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J834XSRBH6V718AYH0R3026V");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J834XSRB6YRE5ZWN7NPEPM0Y");

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Email", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J83FQKCK06BRM6DMD0Q59SK5", "administracija@mtf.viko.lt", "Menų ir kūrybinių technologijų fakultetas", "MTF" },
                    { "01J83FQKCK13JVHBWYEATSP7XA", "administracija@pdf.viko.lt", "Pedagogikos fakultetas", "PDF" },
                    { "01J83FQKCK24E1Q68GJ5DKPT41", "info@eif.viko.lt", "Elektronikos ir informatikos fakultetas", "EIF" },
                    { "01J83FQKCK5AHV3K0WC781HS06", "administracija@atf.viko.lt", "Agrotechnologijų fakultetas", "ATF" },
                    { "01J83FQKCK5MDPPDRNB3ER9BSG", "administracija@tef.viko.lt", "Technikos fakultetas", "TEF" },
                    { "01J83FQKCK7DVMWRCAR08Q6Z03", "info@spf.viko.lt", "Sveikatos priežiūros fakultetas", "SPF" },
                    { "01J83FQKCKFCMK2P0NAAHR1QGX", "administracija@dif.viko.lt", "Dizaino fakultetas", "DIF" },
                    { "01J83FQKCKJ6XEHD4H03R7SE42", "administracija@ekf.viko.lt", "Ekonomikos fakultetas", "EKF" },
                    { "01J83FQKCKNB2J5WKS46Z2C568", "administracija@vvf.viko.lt", "Verslo vadybos fakultetas", "VVF" },
                    { "01J83FQKCKWJ01TGJP3MW34ZYN", "administracija@stf.viko.lt", "Statybos fakultetas", "STF" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Email", "FacultyId", "Name", "ShortName" },
                values: new object[,]
                {
                    { "01J83FQKCK72EKGH7F7XZJMPDM", "t.liogiene@eif.viko.lt", "01J83FQKCK24E1Q68GJ5DKPT41", "Informacinių sistemų katedra", "ISK" },
                    { "01J83FQKCKJHZ8WZW0AWTXNNER", "j.zailskas@eif.viko.lt", "01J83FQKCK24E1Q68GJ5DKPT41", "Programinės įrangos katedra", "PĮK" },
                    { "01J83FQKCKMQXK32TR3WW0XJGD", "a.kirdeikiene@eif.viko.lt", "01J83FQKCK24E1Q68GJ5DKPT41", "Elektronikos ir kompiuterių inžinerijos katedra", "EKIK" }
                });

            migrationBuilder.InsertData(
                table: "StudyPrograms",
                columns: new[] { "Id", "DepartmentId", "Name", "StudyType" },
                values: new object[,]
                {
                    { "01J83FQKCK0YMH5KGVC9MMMPX9", "01J83FQKCKMQXK32TR3WW0XJGD", "Kompiuterių inžinerija", 1 },
                    { "01J83FQKCK32K4T5Y03DX9Z2JK", "01J83FQKCKJHZ8WZW0AWTXNNER", "Programinės įrangos testavimas", 1 },
                    { "01J83FQKCK7VQGCAQ6TF7RKSZ3", "01J83FQKCK72EKGH7F7XZJMPDM", "Informacijos sistemos", 3 },
                    { "01J83FQKCKD05FENFXC4KKYH8Z", "01J83FQKCKMQXK32TR3WW0XJGD", "Kompiuterių inžinerija", 2 },
                    { "01J83FQKCKDCQTDSHGS0BWPF37", "01J83FQKCKJHZ8WZW0AWTXNNER", "Programų sistemos", 3 },
                    { "01J83FQKCKFK0W72ZZ4JXQGSV4", "01J83FQKCKMQXK32TR3WW0XJGD", "Elektronikos inžinerija", 1 },
                    { "01J83FQKCKFMCTWH5Y6GVWMR07", "01J83FQKCK72EKGH7F7XZJMPDM", "Informacijos sistemos", 2 },
                    { "01J83FQKCKPKR63CKFRZZXHMWF", "01J83FQKCKJHZ8WZW0AWTXNNER", "Programų sistemos", 1 },
                    { "01J83FQKCKXDHT1SXFYEXJH0YF", "01J83FQKCK72EKGH7F7XZJMPDM", "Informacijos sistemos", 1 },
                    { "01J83FQKCKY75PHQTVA1EJHFA9", "01J83FQKCKJHZ8WZW0AWTXNNER", "Programų sistemos", 4 },
                    { "01J83FQKCKZ7XQMDWSH662Q3VB", "01J83FQKCKMQXK32TR3WW0XJGD", "Elektronikos inžinerija", 2 },
                    { "01J83FQKCKZQDYZJW6S70V15R7", "01J83FQKCKJHZ8WZW0AWTXNNER", "Programų sistemos", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK06BRM6DMD0Q59SK5");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK13JVHBWYEATSP7XA");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK5AHV3K0WC781HS06");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK5MDPPDRNB3ER9BSG");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK7DVMWRCAR08Q6Z03");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCKFCMK2P0NAAHR1QGX");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCKJ6XEHD4H03R7SE42");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCKNB2J5WKS46Z2C568");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCKWJ01TGJP3MW34ZYN");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCK0YMH5KGVC9MMMPX9");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCK32K4T5Y03DX9Z2JK");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCK7VQGCAQ6TF7RKSZ3");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKD05FENFXC4KKYH8Z");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKDCQTDSHGS0BWPF37");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKFK0W72ZZ4JXQGSV4");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKFMCTWH5Y6GVWMR07");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKPKR63CKFRZZXHMWF");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKXDHT1SXFYEXJH0YF");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKY75PHQTVA1EJHFA9");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKZ7XQMDWSH662Q3VB");

            migrationBuilder.DeleteData(
                table: "StudyPrograms",
                keyColumn: "Id",
                keyValue: "01J83FQKCKZQDYZJW6S70V15R7");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J83FQKCK72EKGH7F7XZJMPDM");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J83FQKCKJHZ8WZW0AWTXNNER");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: "01J83FQKCKMQXK32TR3WW0XJGD");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: "01J83FQKCK24E1Q68GJ5DKPT41");

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
        }
    }
}
