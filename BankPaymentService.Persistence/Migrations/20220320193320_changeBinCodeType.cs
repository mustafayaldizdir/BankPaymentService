using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankPaymentService.Persistence.Migrations
{
    public partial class changeBinCodeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BinCode",
                table: "CcBinCodes",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "BinCode",
                value: "404591");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 2,
                column: "BinCode",
                value: "407814");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 3,
                column: "BinCode",
                value: "413226");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 4,
                column: "BinCode",
                value: "434528");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 5,
                column: "BinCode",
                value: "434529");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 6,
                column: "BinCode",
                value: "439561");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 7,
                column: "BinCode",
                value: "444676");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "BinCode",
                value: "444677");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 9,
                column: "BinCode",
                value: "444678");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 10,
                column: "BinCode",
                value: "447504");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 11,
                column: "BinCode",
                value: "454671");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 12,
                column: "BinCode",
                value: "511885");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "BinCode",
                value: "487149");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "BinCode",
                value: "487148");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 15,
                column: "BinCode",
                value: "487147");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 16,
                column: "BinCode",
                value: "487146");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 17,
                column: "BinCode",
                value: "482465");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 18,
                column: "BinCode",
                value: "476619");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 19,
                column: "BinCode",
                value: "469884");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 20,
                column: "BinCode",
                value: "460952");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 21,
                column: "BinCode",
                value: "454674");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 22,
                column: "BinCode",
                value: "454673");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 23,
                column: "BinCode",
                value: "454672");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 24,
                column: "BinCode",
                value: "527682");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 25,
                column: "BinCode",
                value: "527737");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 26,
                column: "BinCode",
                value: "528208");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 27,
                column: "BinCode",
                value: "530905");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 28,
                column: "BinCode",
                value: "531102");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 29,
                column: "BinCode",
                value: "533154");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 30,
                column: "BinCode",
                value: "534981");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 31,
                column: "BinCode",
                value: "535735");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 32,
                column: "BinCode",
                value: "537470");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 33,
                column: "BinCode",
                value: "540130");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 34,
                column: "BinCode",
                value: "540134");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 35,
                column: "BinCode",
                value: "542374");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 36,
                column: "BinCode",
                value: "542941");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 37,
                column: "BinCode",
                value: "546957");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 38,
                column: "BinCode",
                value: "547287");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 39,
                column: "BinCode",
                value: "549449");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 40,
                column: "BinCode",
                value: "650083");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 41,
                column: "BinCode",
                value: "650268");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 42,
                column: "BinCode",
                value: "650273");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 43,
                column: "BinCode",
                value: "650274");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 44,
                column: "BinCode",
                value: "676123");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 45,
                column: "BinCode",
                value: "676124");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 46,
                column: "BinCode",
                value: "979217");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 47,
                column: "BinCode",
                value: "979280");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 48,
                column: "BinCode",
                value: "516932");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 49,
                column: "BinCode",
                value: "525329");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 50,
                column: "BinCode",
                value: "512440");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 51,
                column: "BinCode",
                value: "523529");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 52,
                column: "BinCode",
                value: "513662");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 53,
                column: "BinCode",
                value: "537500");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 54,
                column: "BinCode",
                value: "543081");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 55,
                column: "BinCode",
                value: "552879");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 56,
                column: "BinCode",
                value: "639001");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 57,
                column: "BinCode",
                value: "676258");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 58,
                column: "BinCode",
                value: "979210");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 59,
                column: "BinCode",
                value: "979212");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 60,
                column: "BinCode",
                value: "979238");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 61,
                column: "BinCode",
                value: "526290");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 62,
                column: "BinCode",
                value: "401049");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 63,
                column: "BinCode",
                value: "415514");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 64,
                column: "BinCode",
                value: "415515");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 65,
                column: "BinCode",
                value: "416607");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 66,
                column: "BinCode",
                value: "421030");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 67,
                column: "BinCode",
                value: "979245");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 68,
                column: "BinCode",
                value: "979244");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 69,
                column: "BinCode",
                value: "423480");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 70,
                column: "BinCode",
                value: "447505");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 71,
                column: "BinCode",
                value: "451454");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 72,
                column: "BinCode",
                value: "456944");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 73,
                column: "BinCode",
                value: "466260");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 74,
                column: "BinCode",
                value: "478551");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "BinCode",
                value: "492094");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 76,
                column: "BinCode",
                value: "492095");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 77,
                column: "BinCode",
                value: "498852");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 78,
                column: "BinCode",
                value: "499821");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 79,
                column: "BinCode",
                value: "510056");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 80,
                column: "BinCode",
                value: "521378");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 81,
                column: "BinCode",
                value: "526289");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 82,
                column: "BinCode",
                value: "527284");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 83,
                column: "BinCode",
                value: "535241");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 84,
                column: "BinCode",
                value: "536503");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 85,
                column: "BinCode",
                value: "540435");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 86,
                column: "BinCode",
                value: "415792");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 87,
                column: "BinCode",
                value: "416757");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 88,
                column: "BinCode",
                value: "423478");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 89,
                column: "BinCode",
                value: "428945");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 90,
                column: "BinCode",
                value: "434530");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 91,
                column: "BinCode",
                value: "434724");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 92,
                column: "BinCode",
                value: "442671");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 93,
                column: "BinCode",
                value: "459252");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 94,
                column: "BinCode",
                value: "479909");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 95,
                column: "BinCode",
                value: "483612");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 96,
                column: "BinCode",
                value: "491005");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 97,
                column: "BinCode",
                value: "493840");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 98,
                column: "BinCode",
                value: "493841");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "BinCode",
                value: "493846");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "BinCode",
                value: "520017");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 101,
                column: "BinCode",
                value: "522441");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 102,
                column: "BinCode",
                value: "531369");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 103,
                column: "BinCode",
                value: "535576");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 104,
                column: "BinCode",
                value: "535775");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 105,
                column: "BinCode",
                value: "540045");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 106,
                column: "BinCode",
                value: "540046");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "BinCode",
                value: "542119");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 108,
                column: "BinCode",
                value: "542798");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "BinCode",
                value: "979256");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 110,
                column: "BinCode",
                value: "979209");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 111,
                column: "BinCode",
                value: "650170");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 112,
                column: "BinCode",
                value: "650052");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 113,
                column: "BinCode",
                value: "589311");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "BinCode",
                value: "555467");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 115,
                column: "BinCode",
                value: "554548");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 116,
                column: "BinCode",
                value: "552101");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 117,
                column: "BinCode",
                value: "547244");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 118,
                column: "BinCode",
                value: "542804");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 119,
                column: "BinCode",
                value: "537504");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 120,
                column: "BinCode",
                value: "409084");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 121,
                column: "BinCode",
                value: "402940");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 122,
                column: "BinCode",
                value: "411724");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 123,
                column: "BinCode",
                value: "411942");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 124,
                column: "BinCode",
                value: "411943");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 125,
                column: "BinCode",
                value: "411944");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 126,
                column: "BinCode",
                value: "411979");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 127,
                column: "BinCode",
                value: "497022");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 128,
                column: "BinCode",
                value: "489495");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 129,
                column: "BinCode",
                value: "489494");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 130,
                column: "BinCode",
                value: "479227");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 131,
                column: "BinCode",
                value: "469188");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 132,
                column: "BinCode",
                value: "459026");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 133,
                column: "BinCode",
                value: "455645");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 134,
                column: "BinCode",
                value: "450918");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 135,
                column: "BinCode",
                value: "447503");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 136,
                column: "BinCode",
                value: "979264");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 137,
                column: "BinCode",
                value: "979223");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 138,
                column: "BinCode",
                value: "676578");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 139,
                column: "BinCode",
                value: "676406");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 140,
                column: "BinCode",
                value: "606329");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 141,
                column: "BinCode",
                value: "553090");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 142,
                column: "BinCode",
                value: "552207");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 143,
                column: "BinCode",
                value: "550449");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 144,
                column: "BinCode",
                value: "549998");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 145,
                column: "BinCode",
                value: "547985");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 146,
                column: "BinCode",
                value: "545148");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 147,
                column: "BinCode",
                value: "545124");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 148,
                column: "BinCode",
                value: "537537");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 149,
                column: "BinCode",
                value: "542259");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 150,
                column: "BinCode",
                value: "535217");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 151,
                column: "BinCode",
                value: "440293");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 152,
                column: "BinCode",
                value: "440273");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 153,
                column: "BinCode",
                value: "440247");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 154,
                column: "BinCode",
                value: "439845");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 155,
                column: "BinCode",
                value: "438040");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 156,
                column: "BinCode",
                value: "427707");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 157,
                column: "BinCode",
                value: "427308");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 158,
                column: "BinCode",
                value: "416563");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 159,
                column: "BinCode",
                value: "416350");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 160,
                column: "BinCode",
                value: "413528");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 161,
                column: "BinCode",
                value: "406015");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 162,
                column: "BinCode",
                value: "404350");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 163,
                column: "BinCode",
                value: "404315");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 164,
                column: "BinCode",
                value: "402459");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 165,
                column: "BinCode",
                value: "402458");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 166,
                column: "BinCode",
                value: "402142");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 167,
                column: "BinCode",
                value: "440274");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 168,
                column: "BinCode",
                value: "440294");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 169,
                column: "BinCode",
                value: "534538");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 170,
                column: "BinCode",
                value: "440295");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 171,
                column: "BinCode",
                value: "532581");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 172,
                column: "BinCode",
                value: "531531");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 173,
                column: "BinCode",
                value: "530853");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 174,
                column: "BinCode",
                value: "528926");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 175,
                column: "BinCode",
                value: "528920");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 176,
                column: "BinCode",
                value: "525314");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 177,
                column: "BinCode",
                value: "524840");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 178,
                column: "BinCode",
                value: "524839");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 179,
                column: "BinCode",
                value: "524346");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 180,
                column: "BinCode",
                value: "519780");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 181,
                column: "BinCode",
                value: "512803");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 182,
                column: "BinCode",
                value: "512753");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 183,
                column: "BinCode",
                value: "510221");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 184,
                column: "BinCode",
                value: "510139");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 185,
                column: "BinCode",
                value: "510138");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 186,
                column: "BinCode",
                value: "489496");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 187,
                column: "BinCode",
                value: "432071");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 188,
                column: "BinCode",
                value: "516840");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 189,
                column: "BinCode",
                value: "535280");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 190,
                column: "BinCode",
                value: "535449");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 191,
                column: "BinCode",
                value: "550383");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 192,
                column: "BinCode",
                value: "553056");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 193,
                column: "BinCode",
                value: "557113");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 194,
                column: "BinCode",
                value: "557829");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 195,
                column: "BinCode",
                value: "589004");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 196,
                column: "BinCode",
                value: "979206");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 197,
                column: "BinCode",
                value: "534253");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 198,
                column: "BinCode",
                value: "979207");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 199,
                column: "BinCode",
                value: "979208");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 200,
                column: "BinCode",
                value: "516841");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 201,
                column: "BinCode",
                value: "516643");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 202,
                column: "BinCode",
                value: "512754");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 203,
                column: "BinCode",
                value: "493837");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 204,
                column: "BinCode",
                value: "479681");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 205,
                column: "BinCode",
                value: "479680");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 206,
                column: "BinCode",
                value: "474854");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 207,
                column: "BinCode",
                value: "474853");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 208,
                column: "BinCode",
                value: "435509");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 209,
                column: "BinCode",
                value: "435508");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 210,
                column: "BinCode",
                value: "432072");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 211,
                column: "BinCode",
                value: "520932");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 212,
                column: "BinCode",
                value: "425669");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 213,
                column: "BinCode",
                value: "413252");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 214,
                column: "BinCode",
                value: "524347");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 215,
                column: "BinCode",
                value: "521942");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 216,
                column: "BinCode",
                value: "521807");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 217,
                column: "BinCode",
                value: "552608");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 218,
                column: "BinCode",
                value: "552609");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 219,
                column: "BinCode",
                value: "521394");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 220,
                column: "BinCode",
                value: "525404");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 221,
                column: "BinCode",
                value: "530866");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 222,
                column: "BinCode",
                value: "547311");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 223,
                column: "BinCode",
                value: "549208");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 224,
                column: "BinCode",
                value: "549394");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 225,
                column: "BinCode",
                value: "589713");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 226,
                column: "BinCode",
                value: "650175");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 227,
                column: "BinCode",
                value: "676832");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 228,
                column: "BinCode",
                value: "979211");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 229,
                column: "BinCode",
                value: "979268");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 230,
                column: "BinCode",
                value: "411156");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 231,
                column: "BinCode",
                value: "411158");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 232,
                column: "BinCode",
                value: "411159");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 233,
                column: "BinCode",
                value: "411160");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 234,
                column: "BinCode",
                value: "421086");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 235,
                column: "BinCode",
                value: "423833");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 236,
                column: "BinCode",
                value: "519753");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 237,
                column: "BinCode",
                value: "494064");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 238,
                column: "BinCode",
                value: "459068");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 239,
                column: "BinCode",
                value: "489401");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 240,
                column: "BinCode",
                value: "411157");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 241,
                column: "BinCode",
                value: "516846");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 242,
                column: "BinCode",
                value: "403836");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 243,
                column: "BinCode",
                value: "409622");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 244,
                column: "BinCode",
                value: "520988");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 245,
                column: "BinCode",
                value: "521824");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 246,
                column: "BinCode",
                value: "521825");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 247,
                column: "BinCode",
                value: "522204");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 248,
                column: "BinCode",
                value: "524659");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 249,
                column: "BinCode",
                value: "526955");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 250,
                column: "BinCode",
                value: "528939");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 251,
                column: "BinCode",
                value: "528956");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 252,
                column: "BinCode",
                value: "533169");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 253,
                column: "BinCode",
                value: "534261");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 254,
                column: "BinCode",
                value: "535429");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 255,
                column: "BinCode",
                value: "535488");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 256,
                column: "BinCode",
                value: "537829");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 257,
                column: "BinCode",
                value: "538121");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 258,
                column: "BinCode",
                value: "538124");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 259,
                column: "BinCode",
                value: "538139");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 260,
                column: "BinCode",
                value: "538196");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 261,
                column: "BinCode",
                value: "540036");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 262,
                column: "BinCode",
                value: "540037");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 263,
                column: "BinCode",
                value: "540118");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 264,
                column: "BinCode",
                value: "517042");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 265,
                column: "BinCode",
                value: "517041");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 266,
                column: "BinCode",
                value: "517040");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 267,
                column: "BinCode",
                value: "516961");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 268,
                column: "BinCode",
                value: "432954");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 269,
                column: "BinCode",
                value: "448472");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 270,
                column: "BinCode",
                value: "462274");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 271,
                column: "BinCode",
                value: "467293");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 272,
                column: "BinCode",
                value: "467294");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 273,
                column: "BinCode",
                value: "467295");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 274,
                column: "BinCode",
                value: "474151");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 275,
                column: "BinCode",
                value: "474215");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 276,
                column: "BinCode",
                value: "479682");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 277,
                column: "BinCode",
                value: "479660");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 278,
                column: "BinCode",
                value: "482489");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 279,
                column: "BinCode",
                value: "482491");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 280,
                column: "BinCode",
                value: "487074");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 281,
                column: "BinCode",
                value: "487075");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 282,
                column: "BinCode",
                value: "489455");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 283,
                column: "BinCode",
                value: "489478");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 284,
                column: "BinCode",
                value: "479661");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 285,
                column: "BinCode",
                value: "622403");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 286,
                column: "BinCode",
                value: "542030");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 287,
                column: "BinCode",
                value: "541865");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 288,
                column: "BinCode",
                value: "540709");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 289,
                column: "BinCode",
                value: "540669");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 290,
                column: "BinCode",
                value: "377137");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 291,
                column: "BinCode",
                value: "377596");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 292,
                column: "BinCode",
                value: "377597");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 293,
                column: "BinCode",
                value: "377598");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 294,
                column: "BinCode",
                value: "377599");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 295,
                column: "BinCode",
                value: "401738");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 296,
                column: "BinCode",
                value: "403280");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 297,
                column: "BinCode",
                value: "403666");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 298,
                column: "BinCode",
                value: "404308");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 299,
                column: "BinCode",
                value: "405051");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 300,
                column: "BinCode",
                value: "405090");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 301,
                column: "BinCode",
                value: "406665");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 302,
                column: "BinCode",
                value: "406666");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 303,
                column: "BinCode",
                value: "409219");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 304,
                column: "BinCode",
                value: "410141");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 305,
                column: "BinCode",
                value: "413836");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 306,
                column: "BinCode",
                value: "420557");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 307,
                column: "BinCode",
                value: "426886");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 308,
                column: "BinCode",
                value: "426887");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 309,
                column: "BinCode",
                value: "426888");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 310,
                column: "BinCode",
                value: "426889");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 311,
                column: "BinCode",
                value: "427314");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 312,
                column: "BinCode",
                value: "427315");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 313,
                column: "BinCode",
                value: "428220");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 314,
                column: "BinCode",
                value: "428221");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 315,
                column: "BinCode",
                value: "375631");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 316,
                column: "BinCode",
                value: "432154");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 317,
                column: "BinCode",
                value: "375630");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 318,
                column: "BinCode",
                value: "375628");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 319,
                column: "BinCode",
                value: "374421");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 320,
                column: "BinCode",
                value: "374422");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 321,
                column: "BinCode",
                value: "374423");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 322,
                column: "BinCode",
                value: "374424");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 323,
                column: "BinCode",
                value: "374425");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 324,
                column: "BinCode",
                value: "374426");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 325,
                column: "BinCode",
                value: "374427");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 326,
                column: "BinCode",
                value: "374428");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 327,
                column: "BinCode",
                value: "375622");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 328,
                column: "BinCode",
                value: "375623");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 329,
                column: "BinCode",
                value: "375624");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 330,
                column: "BinCode",
                value: "375625");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 331,
                column: "BinCode",
                value: "375626");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 332,
                column: "BinCode",
                value: "375627");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 333,
                column: "BinCode",
                value: "375629");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 334,
                column: "BinCode",
                value: "432951");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 335,
                column: "BinCode",
                value: "432952");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 336,
                column: "BinCode",
                value: "432953");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 337,
                column: "BinCode",
                value: "517048");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 338,
                column: "BinCode",
                value: "517049");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 339,
                column: "BinCode",
                value: "520097");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 340,
                column: "BinCode",
                value: "520922");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 341,
                column: "BinCode",
                value: "520940");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 342,
                column: "BinCode",
                value: "479662");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 343,
                column: "BinCode",
                value: "979236");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 344,
                column: "BinCode",
                value: "979205");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 345,
                column: "BinCode",
                value: "685800");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 346,
                column: "BinCode",
                value: "676827");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 347,
                column: "BinCode",
                value: "676651");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 348,
                column: "BinCode",
                value: "676283");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 349,
                column: "BinCode",
                value: "482490");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 350,
                column: "BinCode",
                value: "516943");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 351,
                column: "BinCode",
                value: "514915");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 352,
                column: "BinCode",
                value: "493845");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 353,
                column: "BinCode",
                value: "492193");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 354,
                column: "BinCode",
                value: "492187");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 355,
                column: "BinCode",
                value: "492186");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 356,
                column: "BinCode",
                value: "490175");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 357,
                column: "BinCode",
                value: "676255");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 358,
                column: "BinCode",
                value: "670606");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 359,
                column: "BinCode",
                value: "638888");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 360,
                column: "BinCode",
                value: "589318");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 361,
                column: "BinCode",
                value: "558699");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 362,
                column: "BinCode",
                value: "557023");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 363,
                column: "BinCode",
                value: "554960");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 364,
                column: "BinCode",
                value: "554254");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 365,
                column: "BinCode",
                value: "554253");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 366,
                column: "BinCode",
                value: "553130");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 367,
                column: "BinCode",
                value: "549997");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 368,
                column: "BinCode",
                value: "548935");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 369,
                column: "BinCode",
                value: "544078");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 370,
                column: "BinCode",
                value: "543738");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 371,
                column: "BinCode",
                value: "418342");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 372,
                column: "BinCode",
                value: "403998");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 373,
                column: "BinCode",
                value: "535514");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 374,
                column: "BinCode",
                value: "535279");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 375,
                column: "BinCode",
                value: "534653");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 376,
                column: "BinCode",
                value: "533803");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 377,
                column: "BinCode",
                value: "525382");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 378,
                column: "BinCode",
                value: "510152");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 379,
                column: "BinCode",
                value: "489375");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 380,
                column: "BinCode",
                value: "483602");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 381,
                column: "BinCode",
                value: "479610");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 382,
                column: "BinCode",
                value: "473998");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 383,
                column: "BinCode",
                value: "418345");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 384,
                column: "BinCode",
                value: "438331");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 385,
                column: "BinCode",
                value: "540668");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 386,
                column: "BinCode",
                value: "441075");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 387,
                column: "BinCode",
                value: "540667");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 388,
                column: "BinCode",
                value: "537567");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 389,
                column: "BinCode",
                value: "537548");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 390,
                column: "BinCode",
                value: "473957");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 391,
                column: "BinCode",
                value: "979233");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 392,
                column: "BinCode",
                value: "979204");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 393,
                column: "BinCode",
                value: "537475");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 394,
                column: "BinCode",
                value: "650990");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 395,
                column: "BinCode",
                value: "650987");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 396,
                column: "BinCode",
                value: "650456");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 397,
                column: "BinCode",
                value: "650173");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 398,
                column: "BinCode",
                value: "650092");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 399,
                column: "BinCode",
                value: "650082");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 400,
                column: "BinCode",
                value: "589283");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 401,
                column: "BinCode",
                value: "559289");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 402,
                column: "BinCode",
                value: "553058");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 403,
                column: "BinCode",
                value: "552096");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 404,
                column: "BinCode",
                value: "545254");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 405,
                column: "BinCode",
                value: "548237");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 406,
                column: "BinCode",
                value: "543771");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 407,
                column: "BinCode",
                value: "420556");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 408,
                column: "BinCode",
                value: "441076");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 409,
                column: "BinCode",
                value: "441077");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 410,
                column: "BinCode",
                value: "450803");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 411,
                column: "BinCode",
                value: "454314");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 412,
                column: "BinCode",
                value: "454318");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 413,
                column: "BinCode",
                value: "454358");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 414,
                column: "BinCode",
                value: "454359");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 415,
                column: "BinCode",
                value: "454360");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 416,
                column: "BinCode",
                value: "460925");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 417,
                column: "BinCode",
                value: "473956");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 418,
                column: "BinCode",
                value: "418344");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 419,
                column: "BinCode",
                value: "418343");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 420,
                column: "BinCode",
                value: "552645");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 421,
                column: "BinCode",
                value: "639004");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 422,
                column: "BinCode",
                value: "650161");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 423,
                column: "BinCode",
                value: "657366");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 424,
                column: "BinCode",
                value: "657998");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 425,
                column: "BinCode",
                value: "676166");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 426,
                column: "BinCode",
                value: "979215");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 427,
                column: "BinCode",
                value: "979241");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 428,
                column: "BinCode",
                value: "979263");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 429,
                column: "BinCode",
                value: "603797");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 430,
                column: "BinCode",
                value: "554422");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 431,
                column: "BinCode",
                value: "552659");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 432,
                column: "BinCode",
                value: "479794");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 433,
                column: "BinCode",
                value: "479795");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 434,
                column: "BinCode",
                value: "490983");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 435,
                column: "BinCode",
                value: "491205");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 436,
                column: "BinCode",
                value: "491206");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 437,
                column: "BinCode",
                value: "492128");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 438,
                column: "BinCode",
                value: "492130");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 439,
                column: "BinCode",
                value: "492131");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 440,
                column: "BinCode",
                value: "494314");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 441,
                column: "BinCode",
                value: "523034");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 442,
                column: "BinCode",
                value: "525864");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 443,
                column: "BinCode",
                value: "533913");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 444,
                column: "BinCode",
                value: "535435");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 445,
                column: "BinCode",
                value: "535601");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 446,
                column: "BinCode",
                value: "535602");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 447,
                column: "BinCode",
                value: "537518");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 448,
                column: "BinCode",
                value: "537833");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 449,
                column: "BinCode",
                value: "540061");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 450,
                column: "BinCode",
                value: "540062");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 451,
                column: "BinCode",
                value: "540063");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 452,
                column: "BinCode",
                value: "540122");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 453,
                column: "BinCode",
                value: "540129");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 454,
                column: "BinCode",
                value: "542117");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 455,
                column: "BinCode",
                value: "545103");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 456,
                column: "BinCode",
                value: "549624");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 457,
                column: "BinCode",
                value: "479620");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 458,
                column: "BinCode",
                value: "479612");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 459,
                column: "BinCode",
                value: "455359");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 460,
                column: "BinCode",
                value: "401622");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 461,
                column: "BinCode",
                value: "404809");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 462,
                column: "BinCode",
                value: "406281");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 463,
                column: "BinCode",
                value: "413382");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 464,
                column: "BinCode",
                value: "414392");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 465,
                column: "BinCode",
                value: "420342");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 466,
                column: "BinCode",
                value: "420343");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 467,
                column: "BinCode",
                value: "434728");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 468,
                column: "BinCode",
                value: "434742");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 469,
                column: "BinCode",
                value: "434839");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 470,
                column: "BinCode",
                value: "442106");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 471,
                column: "BinCode",
                value: "446212");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 472,
                column: "BinCode",
                value: "450634");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 473,
                column: "BinCode",
                value: "477959");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 474,
                column: "BinCode",
                value: "437897");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 475,
                column: "BinCode",
                value: "555087");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 476,
                column: "BinCode",
                value: "553493");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 477,
                column: "BinCode",
                value: "471509");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 478,
                column: "BinCode",
                value: "558030");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 479,
                column: "BinCode",
                value: "552098");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 480,
                column: "BinCode",
                value: "589288");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 481,
                column: "BinCode",
                value: "529939");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 482,
                column: "BinCode",
                value: "677522");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 483,
                column: "BinCode",
                value: "518599");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 484,
                column: "BinCode",
                value: "419389");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 485,
                column: "BinCode",
                value: "455571");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 486,
                column: "BinCode",
                value: "554297");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 487,
                column: "BinCode",
                value: "479632");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 488,
                column: "BinCode",
                value: "550478");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 489,
                column: "BinCode",
                value: "550074");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 490,
                column: "BinCode",
                value: "548819");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 491,
                column: "BinCode",
                value: "547765");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 492,
                column: "BinCode",
                value: "542967");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 493,
                column: "BinCode",
                value: "542965");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 494,
                column: "BinCode",
                value: "542605");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 495,
                column: "BinCode",
                value: "542029");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 496,
                column: "BinCode",
                value: "540025");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 497,
                column: "BinCode",
                value: "540024");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 498,
                column: "BinCode",
                value: "676402");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 499,
                column: "BinCode",
                value: "979224");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 500,
                column: "BinCode",
                value: "979242");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 501,
                column: "BinCode",
                value: "535270");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 502,
                column: "BinCode",
                value: "535137");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 503,
                column: "BinCode",
                value: "532443");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 504,
                column: "BinCode",
                value: "531401");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 505,
                column: "BinCode",
                value: "526975");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 506,
                column: "BinCode",
                value: "526973");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 507,
                column: "BinCode",
                value: "517946");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 508,
                column: "BinCode",
                value: "514140");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 509,
                column: "BinCode",
                value: "603322");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 510,
                column: "BinCode",
                value: "510151");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 511,
                column: "BinCode",
                value: "490808");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 512,
                column: "BinCode",
                value: "490807");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 513,
                column: "BinCode",
                value: "490806");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 514,
                column: "BinCode",
                value: "490805");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 515,
                column: "BinCode",
                value: "479633");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 516,
                column: "BinCode",
                value: "480296");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 517,
                column: "BinCode",
                value: "400684");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 518,
                column: "BinCode",
                value: "408579");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 519,
                column: "BinCode",
                value: "408581");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 520,
                column: "BinCode",
                value: "414070");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 521,
                column: "BinCode",
                value: "420322");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 522,
                column: "BinCode",
                value: "420323");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 523,
                column: "BinCode",
                value: "423091");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 524,
                column: "BinCode",
                value: "554570");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 525,
                column: "BinCode",
                value: "676366");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 526,
                column: "BinCode",
                value: "420324");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 527,
                column: "BinCode",
                value: "671217");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 528,
                column: "BinCode",
                value: "979225");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 529,
                column: "BinCode",
                value: "603343");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 530,
                column: "BinCode",
                value: "559056");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 531,
                column: "BinCode",
                value: "557374");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 532,
                column: "BinCode",
                value: "543624");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 533,
                column: "BinCode",
                value: "527765");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 534,
                column: "BinCode",
                value: "527192");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 535,
                column: "BinCode",
                value: "527149");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 536,
                column: "BinCode",
                value: "522576");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 537,
                column: "BinCode",
                value: "522566");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 538,
                column: "BinCode",
                value: "522075");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 539,
                column: "BinCode",
                value: "517601");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 540,
                column: "BinCode",
                value: "468973");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 541,
                column: "BinCode",
                value: "434909");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 542,
                column: "BinCode",
                value: "423495");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 543,
                column: "BinCode",
                value: "603005");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 544,
                column: "BinCode",
                value: "979231");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 545,
                column: "BinCode",
                value: "676429");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 546,
                column: "BinCode",
                value: "545769");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 547,
                column: "BinCode",
                value: "527080");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 548,
                column: "BinCode",
                value: "456057");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 549,
                column: "BinCode",
                value: "521875");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 550,
                column: "BinCode",
                value: "514025");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 551,
                column: "BinCode",
                value: "445988");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 552,
                column: "BinCode",
                value: "413972");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 553,
                column: "BinCode",
                value: "413729");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 554,
                column: "BinCode",
                value: "979239");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 555,
                column: "BinCode",
                value: "589416");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 556,
                column: "BinCode",
                value: "456059");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 557,
                column: "BinCode",
                value: "558634");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 558,
                column: "BinCode",
                value: "545770");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 559,
                column: "BinCode",
                value: "547772");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 560,
                column: "BinCode",
                value: "479679");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 561,
                column: "BinCode",
                value: "547567");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 562,
                column: "BinCode",
                value: "545847");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 563,
                column: "BinCode",
                value: "545616");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 564,
                column: "BinCode",
                value: "979203");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 565,
                column: "BinCode",
                value: "677238");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 566,
                column: "BinCode",
                value: "499851");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 567,
                column: "BinCode",
                value: "499852");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 568,
                column: "BinCode",
                value: "499853");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 569,
                column: "BinCode",
                value: "516789");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 570,
                column: "BinCode",
                value: "516835");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 571,
                column: "BinCode",
                value: "516843");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 572,
                column: "BinCode",
                value: "519324");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 573,
                column: "BinCode",
                value: "521022");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 574,
                column: "BinCode",
                value: "521836");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 575,
                column: "BinCode",
                value: "526911");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 576,
                column: "BinCode",
                value: "529572");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 577,
                column: "BinCode",
                value: "530818");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 578,
                column: "BinCode",
                value: "531157");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 579,
                column: "BinCode",
                value: "545120");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 580,
                column: "BinCode",
                value: "542404");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 581,
                column: "BinCode",
                value: "539957");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 582,
                column: "BinCode",
                value: "537058");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 583,
                column: "BinCode",
                value: "535177");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 584,
                column: "BinCode",
                value: "414388");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 585,
                column: "BinCode",
                value: "420092");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 586,
                column: "BinCode",
                value: "415956");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 587,
                column: "BinCode",
                value: "415565");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 588,
                column: "BinCode",
                value: "498749");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 589,
                column: "BinCode",
                value: "459333");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 590,
                column: "BinCode",
                value: "422376");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 591,
                column: "BinCode",
                value: "427311");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 592,
                column: "BinCode",
                value: "410147");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 593,
                column: "BinCode",
                value: "409364");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 594,
                column: "BinCode",
                value: "431379");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 595,
                column: "BinCode",
                value: "406386");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 596,
                column: "BinCode",
                value: "403082");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 597,
                column: "BinCode",
                value: "402563");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 598,
                column: "BinCode",
                value: "402278");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 599,
                column: "BinCode",
                value: "435653");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 600,
                column: "BinCode",
                value: "439757");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 601,
                column: "BinCode",
                value: "441007");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 602,
                column: "BinCode",
                value: "442395");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 603,
                column: "BinCode",
                value: "499850");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 604,
                column: "BinCode",
                value: "979202");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 605,
                column: "BinCode",
                value: "601050");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 606,
                column: "BinCode",
                value: "559096");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 607,
                column: "BinCode",
                value: "547800");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 608,
                column: "BinCode",
                value: "402277");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 609,
                column: "BinCode",
                value: "401072");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 610,
                column: "BinCode",
                value: "556030");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 611,
                column: "BinCode",
                value: "677193");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 612,
                column: "BinCode",
                value: "405913");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 613,
                column: "BinCode",
                value: "405917");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 614,
                column: "BinCode",
                value: "405918");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 615,
                column: "BinCode",
                value: "405919");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 616,
                column: "BinCode",
                value: "408969");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 617,
                column: "BinCode",
                value: "409071");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 618,
                column: "BinCode",
                value: "422629");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 619,
                column: "BinCode",
                value: "424909");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 620,
                column: "BinCode",
                value: "428240");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 621,
                column: "BinCode",
                value: "496019");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 622,
                column: "BinCode",
                value: "510005");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 623,
                column: "BinCode",
                value: "512651");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 624,
                column: "BinCode",
                value: "519399");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 625,
                column: "BinCode",
                value: "525413");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 626,
                column: "BinCode",
                value: "525795");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 627,
                column: "BinCode",
                value: "540643");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 628,
                column: "BinCode",
                value: "542254");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 629,
                column: "BinCode",
                value: "545183");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 630,
                column: "BinCode",
                value: "550472");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 631,
                column: "BinCode",
                value: "550473");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 632,
                column: "BinCode",
                value: "552143");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 633,
                column: "BinCode",
                value: "979214");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 634,
                column: "BinCode",
                value: "556031");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 635,
                column: "BinCode",
                value: "556033");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 636,
                column: "BinCode",
                value: "556034");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 637,
                column: "BinCode",
                value: "405903");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 638,
                column: "BinCode",
                value: "556665");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 639,
                column: "BinCode",
                value: "676401");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 640,
                column: "BinCode",
                value: "365773");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 641,
                column: "BinCode",
                value: "365772");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 642,
                column: "BinCode",
                value: "365771");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 643,
                column: "BinCode",
                value: "365770");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 644,
                column: "BinCode",
                value: "979228");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 645,
                column: "BinCode",
                value: "670670");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 646,
                column: "BinCode",
                value: "654997");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 647,
                column: "BinCode",
                value: "558485");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 648,
                column: "BinCode",
                value: "544836");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 649,
                column: "BinCode",
                value: "522221");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 650,
                column: "BinCode",
                value: "516458");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 651,
                column: "BinCode",
                value: "516308");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 652,
                column: "BinCode",
                value: "512618");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 653,
                column: "BinCode",
                value: "466284");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 654,
                column: "BinCode",
                value: "466283");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 655,
                column: "BinCode",
                value: "466282");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 656,
                column: "BinCode",
                value: "466280");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 657,
                column: "BinCode",
                value: "416394");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 658,
                column: "BinCode",
                value: "545863");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 659,
                column: "BinCode",
                value: "535806");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 660,
                column: "BinCode",
                value: "491373");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 661,
                column: "BinCode",
                value: "414941");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 662,
                column: "BinCode",
                value: "543943");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 663,
                column: "BinCode",
                value: "424360");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 664,
                column: "BinCode",
                value: "979243");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 665,
                column: "BinCode",
                value: "979220");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 666,
                column: "BinCode",
                value: "677047");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 667,
                column: "BinCode",
                value: "670640");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 668,
                column: "BinCode",
                value: "670610");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 669,
                column: "BinCode",
                value: "601912");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 670,
                column: "BinCode",
                value: "558514");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 671,
                column: "BinCode",
                value: "558460");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 672,
                column: "BinCode",
                value: "558448");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 673,
                column: "BinCode",
                value: "558446");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 674,
                column: "BinCode",
                value: "558443");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 675,
                column: "BinCode",
                value: "555660");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 676,
                column: "BinCode",
                value: "555636");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 677,
                column: "BinCode",
                value: "555574");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 678,
                column: "BinCode",
                value: "552679");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 679,
                column: "BinCode",
                value: "549839");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 680,
                column: "BinCode",
                value: "546764");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 681,
                column: "BinCode",
                value: "543427");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 682,
                column: "BinCode",
                value: "543358");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 683,
                column: "BinCode",
                value: "408625");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 684,
                column: "BinCode",
                value: "403134");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 685,
                column: "BinCode",
                value: "409070");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 686,
                column: "BinCode",
                value: "424361");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 687,
                column: "BinCode",
                value: "460345");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 688,
                column: "BinCode",
                value: "533330");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 689,
                column: "BinCode",
                value: "533293");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 690,
                column: "BinCode",
                value: "529876");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 691,
                column: "BinCode",
                value: "529545");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 692,
                column: "BinCode",
                value: "523515");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 693,
                column: "BinCode",
                value: "520303");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 694,
                column: "BinCode",
                value: "520019");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 695,
                column: "BinCode",
                value: "517047");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 696,
                column: "BinCode",
                value: "516914");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 697,
                column: "BinCode",
                value: "516741");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 698,
                column: "BinCode",
                value: "516740");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 699,
                column: "BinCode",
                value: "516731");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 700,
                column: "BinCode",
                value: "514924");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 701,
                column: "BinCode",
                value: "512117");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 702,
                column: "BinCode",
                value: "512017");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 703,
                column: "BinCode",
                value: "510119");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 704,
                column: "BinCode",
                value: "510118");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 705,
                column: "BinCode",
                value: "510063");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 706,
                column: "BinCode",
                value: "508129");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 707,
                column: "BinCode",
                value: "489458");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 708,
                column: "BinCode",
                value: "489456");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 709,
                column: "BinCode",
                value: "472915");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 710,
                column: "BinCode",
                value: "472914");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 711,
                column: "BinCode",
                value: "460347");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 712,
                column: "BinCode",
                value: "460346");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 713,
                column: "BinCode",
                value: "425846");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 714,
                column: "BinCode",
                value: "425847");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 715,
                column: "BinCode",
                value: "425848");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 716,
                column: "BinCode",
                value: "558593");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 717,
                column: "BinCode",
                value: "554301");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 718,
                column: "BinCode",
                value: "535881");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 719,
                column: "BinCode",
                value: "522241");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 720,
                column: "BinCode",
                value: "522240");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 721,
                column: "BinCode",
                value: "441341");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 722,
                column: "BinCode",
                value: "425849");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 723,
                column: "BinCode",
                value: "979240");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 724,
                column: "BinCode",
                value: "979252");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 725,
                column: "BinCode",
                value: "676460");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 726,
                column: "BinCode",
                value: "517343");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 727,
                column: "BinCode",
                value: "528246");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 728,
                column: "BinCode",
                value: "532813");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 729,
                column: "BinCode",
                value: "534563");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 730,
                column: "BinCode",
                value: "534565");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 731,
                column: "BinCode",
                value: "534567");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 732,
                column: "BinCode",
                value: "453146");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 733,
                column: "BinCode",
                value: "453145");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 734,
                column: "BinCode",
                value: "453148");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 735,
                column: "BinCode",
                value: "453144");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 736,
                column: "BinCode",
                value: "535843");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 737,
                column: "BinCode",
                value: "504166");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 738,
                column: "BinCode",
                value: "549539");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 739,
                column: "BinCode",
                value: "453147");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 740,
                column: "BinCode",
                value: "515456");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 741,
                column: "BinCode",
                value: "453149");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 742,
                column: "BinCode",
                value: "581877");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 743,
                column: "BinCode",
                value: "671121");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 744,
                column: "BinCode",
                value: "671155");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 745,
                column: "BinCode",
                value: "979213");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 746,
                column: "BinCode",
                value: "979246");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 747,
                column: "BinCode",
                value: "670868");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 748,
                column: "BinCode",
                value: "526952");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 749,
                column: "BinCode",
                value: "524677");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 750,
                column: "BinCode",
                value: "522362");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 751,
                column: "BinCode",
                value: "522356");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 752,
                column: "BinCode",
                value: "522347");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 753,
                column: "BinCode",
                value: "519261");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 754,
                column: "BinCode",
                value: "516944");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 755,
                column: "BinCode",
                value: "469181");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 756,
                column: "BinCode",
                value: "469180");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 757,
                column: "BinCode",
                value: "527369");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 758,
                column: "BinCode",
                value: "979219");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 759,
                column: "BinCode",
                value: "536255");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 760,
                column: "BinCode",
                value: "468797");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 761,
                column: "BinCode",
                value: "468796");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 762,
                column: "BinCode",
                value: "468795");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 763,
                column: "BinCode",
                value: "468794");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 764,
                column: "BinCode",
                value: "468793");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 765,
                column: "BinCode",
                value: "468791");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 766,
                column: "BinCode",
                value: "528064");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 767,
                column: "BinCode",
                value: "527396");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 768,
                column: "BinCode",
                value: "527383");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 769,
                column: "BinCode",
                value: "474265");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 770,
                column: "BinCode",
                value: "547402");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 771,
                column: "BinCode",
                value: "536180");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 772,
                column: "BinCode",
                value: "432285");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 773,
                column: "BinCode",
                value: "434524");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 774,
                column: "BinCode",
                value: "434572");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 775,
                column: "BinCode",
                value: "463359");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 776,
                column: "BinCode",
                value: "479671");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 777,
                column: "BinCode",
                value: "534264");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 778,
                column: "BinCode",
                value: "533973");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 779,
                column: "BinCode",
                value: "533796");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 780,
                column: "BinCode",
                value: "511583");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 781,
                column: "BinCode",
                value: "547234");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 782,
                column: "BinCode",
                value: "417715");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 783,
                column: "BinCode",
                value: "417716");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 784,
                column: "BinCode",
                value: "423002");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 785,
                column: "BinCode",
                value: "424935");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 786,
                column: "BinCode",
                value: "548232");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 787,
                column: "BinCode",
                value: "432284");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 788,
                column: "BinCode",
                value: "627510");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 789,
                column: "BinCode",
                value: "979226");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 790,
                column: "BinCode",
                value: "677397");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 791,
                column: "BinCode",
                value: "979227");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 792,
                column: "BinCode",
                value: "677055");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 793,
                column: "BinCode",
                value: "979267");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 794,
                column: "BinCode",
                value: "557370");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 795,
                column: "BinCode",
                value: "547564");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 796,
                column: "BinCode",
                value: "539803");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 797,
                column: "BinCode",
                value: "535748");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 798,
                column: "BinCode",
                value: "439848");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 799,
                column: "BinCode",
                value: "402592");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 800,
                column: "BinCode",
                value: "403360");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 801,
                column: "BinCode",
                value: "431024");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 802,
                column: "BinCode",
                value: "439847");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 803,
                column: "BinCode",
                value: "525312");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 804,
                column: "BinCode",
                value: "520180");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 805,
                column: "BinCode",
                value: "518896");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 806,
                column: "BinCode",
                value: "512595");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 807,
                column: "BinCode",
                value: "511660");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 808,
                column: "BinCode",
                value: "483674");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 809,
                column: "BinCode",
                value: "483673");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 810,
                column: "BinCode",
                value: "439849");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 811,
                column: "BinCode",
                value: "402589");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 812,
                column: "BinCode",
                value: "402590");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 813,
                column: "BinCode",
                value: "402591");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 814,
                column: "BinCode",
                value: "527083");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 815,
                column: "BinCode",
                value: "527327");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 816,
                column: "BinCode",
                value: "528133");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 817,
                column: "BinCode",
                value: "979216");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 818,
                column: "BinCode",
                value: "518358");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 819,
                column: "BinCode",
                value: "512360");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 820,
                column: "BinCode",
                value: "511783");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 821,
                column: "BinCode",
                value: "511758");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 822,
                column: "BinCode",
                value: "498725");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 823,
                column: "BinCode",
                value: "498724");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 824,
                column: "BinCode",
                value: "485061");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 825,
                column: "BinCode",
                value: "479917");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 826,
                column: "BinCode",
                value: "479916");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 827,
                column: "BinCode",
                value: "479915");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 828,
                column: "BinCode",
                value: "979218");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 829,
                column: "BinCode",
                value: "677451");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 830,
                column: "BinCode",
                value: "606043");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 831,
                column: "BinCode",
                value: "552610");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 832,
                column: "BinCode",
                value: "549294");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 833,
                column: "BinCode",
                value: "400742");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 834,
                column: "BinCode",
                value: "404952");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 835,
                column: "BinCode",
                value: "411685");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 836,
                column: "BinCode",
                value: "416275");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 837,
                column: "BinCode",
                value: "424927");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 838,
                column: "BinCode",
                value: "428462");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 839,
                column: "BinCode",
                value: "435627");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 840,
                column: "BinCode",
                value: "435628");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 841,
                column: "BinCode",
                value: "435629");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 842,
                column: "BinCode",
                value: "441206");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 843,
                column: "BinCode",
                value: "470954");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 844,
                column: "BinCode",
                value: "521848");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 845,
                column: "BinCode",
                value: "537719");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 846,
                column: "BinCode",
                value: "541786");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 847,
                column: "BinCode",
                value: "528293");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 848,
                column: "BinCode",
                value: "519015");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 849,
                column: "BinCode",
                value: "539134");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 850,
                column: "BinCode",
                value: "535248");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 851,
                column: "BinCode",
                value: "979221");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 852,
                column: "BinCode",
                value: "527749");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 853,
                column: "BinCode",
                value: "557844");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 854,
                column: "BinCode",
                value: "525339");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 855,
                column: "BinCode",
                value: "416283");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 856,
                column: "BinCode",
                value: "670586");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 857,
                column: "BinCode",
                value: "535355");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 858,
                column: "BinCode",
                value: "558215");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 859,
                column: "BinCode",
                value: "670544");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 860,
                column: "BinCode",
                value: "979230");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 861,
                column: "BinCode",
                value: "979250");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 862,
                column: "BinCode",
                value: "483703");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 863,
                column: "BinCode",
                value: "483704");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 864,
                column: "BinCode",
                value: "547980");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 865,
                column: "BinCode",
                value: "979261");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 866,
                column: "BinCode",
                value: "498597");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 867,
                column: "BinCode",
                value: "535805");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 868,
                column: "BinCode",
                value: "534060");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 869,
                column: "BinCode",
                value: "439573");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 870,
                column: "BinCode",
                value: "439575");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 871,
                column: "BinCode",
                value: "528825");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 872,
                column: "BinCode",
                value: "520909");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 873,
                column: "BinCode",
                value: "516742");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 874,
                column: "BinCode",
                value: "515895");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 875,
                column: "BinCode",
                value: "515865");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 876,
                column: "BinCode",
                value: "512446");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 877,
                column: "BinCode",
                value: "492192");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 878,
                column: "BinCode",
                value: "476662");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 879,
                column: "BinCode",
                value: "404990");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 880,
                column: "BinCode",
                value: "474823");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 881,
                column: "BinCode",
                value: "539605");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 882,
                column: "BinCode",
                value: "521584");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 883,
                column: "BinCode",
                value: "979248");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 884,
                column: "BinCode",
                value: "979257");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 885,
                column: "BinCode",
                value: "439562");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 886,
                column: "BinCode",
                value: "439563");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 887,
                column: "BinCode",
                value: "478592");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 888,
                column: "BinCode",
                value: "478593");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 889,
                column: "BinCode",
                value: "478594");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 890,
                column: "BinCode",
                value: "531325");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 891,
                column: "BinCode",
                value: "535616");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 892,
                column: "BinCode",
                value: "538841");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 893,
                column: "BinCode",
                value: "542415");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 894,
                column: "BinCode",
                value: "559964");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 895,
                column: "BinCode",
                value: "650457");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 896,
                column: "BinCode",
                value: "979235");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 897,
                column: "BinCode",
                value: "460959");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 898,
                column: "BinCode",
                value: "548793");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 899,
                column: "BinCode",
                value: "539374");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 900,
                column: "BinCode",
                value: "531389");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 901,
                column: "BinCode",
                value: "529799");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 902,
                column: "BinCode",
                value: "460957");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 903,
                column: "BinCode",
                value: "460958");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 904,
                column: "BinCode",
                value: "535925");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 905,
                column: "BinCode",
                value: "536696");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 906,
                column: "BinCode",
                value: "533207");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 907,
                column: "BinCode",
                value: "979278");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 908,
                column: "BinCode",
                value: "979277");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 909,
                column: "BinCode",
                value: "979259");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 910,
                column: "BinCode",
                value: "979254");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 911,
                column: "BinCode",
                value: "979249");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 912,
                column: "BinCode",
                value: "671200");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 913,
                column: "BinCode",
                value: "537608");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 914,
                column: "BinCode",
                value: "434914");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 915,
                column: "BinCode",
                value: "434913");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 916,
                column: "BinCode",
                value: "979266");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 917,
                column: "BinCode",
                value: "473945");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 918,
                column: "BinCode",
                value: "478500");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 919,
                column: "BinCode",
                value: "555518");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 920,
                column: "BinCode",
                value: "463367");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 921,
                column: "BinCode",
                value: "460962");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 922,
                column: "BinCode",
                value: "439748");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 923,
                column: "BinCode",
                value: "471688");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 924,
                column: "BinCode",
                value: "434727");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 925,
                column: "BinCode",
                value: "535434");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 926,
                column: "BinCode",
                value: "439683");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 927,
                column: "BinCode",
                value: "979260");

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 928,
                column: "BinCode",
                value: "439724");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BinCode",
                table: "CcBinCodes",
                type: "integer",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(6)",
                oldMaxLength: 6);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 1,
                column: "BinCode",
                value: 404591);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 2,
                column: "BinCode",
                value: 407814);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 3,
                column: "BinCode",
                value: 413226);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 4,
                column: "BinCode",
                value: 434528);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 5,
                column: "BinCode",
                value: 434529);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 6,
                column: "BinCode",
                value: 439561);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 7,
                column: "BinCode",
                value: 444676);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 8,
                column: "BinCode",
                value: 444677);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 9,
                column: "BinCode",
                value: 444678);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 10,
                column: "BinCode",
                value: 447504);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 11,
                column: "BinCode",
                value: 454671);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 12,
                column: "BinCode",
                value: 511885);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 13,
                column: "BinCode",
                value: 487149);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 14,
                column: "BinCode",
                value: 487148);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 15,
                column: "BinCode",
                value: 487147);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 16,
                column: "BinCode",
                value: 487146);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 17,
                column: "BinCode",
                value: 482465);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 18,
                column: "BinCode",
                value: 476619);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 19,
                column: "BinCode",
                value: 469884);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 20,
                column: "BinCode",
                value: 460952);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 21,
                column: "BinCode",
                value: 454674);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 22,
                column: "BinCode",
                value: 454673);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 23,
                column: "BinCode",
                value: 454672);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 24,
                column: "BinCode",
                value: 527682);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 25,
                column: "BinCode",
                value: 527737);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 26,
                column: "BinCode",
                value: 528208);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 27,
                column: "BinCode",
                value: 530905);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 28,
                column: "BinCode",
                value: 531102);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 29,
                column: "BinCode",
                value: 533154);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 30,
                column: "BinCode",
                value: 534981);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 31,
                column: "BinCode",
                value: 535735);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 32,
                column: "BinCode",
                value: 537470);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 33,
                column: "BinCode",
                value: 540130);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 34,
                column: "BinCode",
                value: 540134);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 35,
                column: "BinCode",
                value: 542374);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 36,
                column: "BinCode",
                value: 542941);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 37,
                column: "BinCode",
                value: 546957);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 38,
                column: "BinCode",
                value: 547287);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 39,
                column: "BinCode",
                value: 549449);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 40,
                column: "BinCode",
                value: 650083);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 41,
                column: "BinCode",
                value: 650268);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 42,
                column: "BinCode",
                value: 650273);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 43,
                column: "BinCode",
                value: 650274);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 44,
                column: "BinCode",
                value: 676123);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 45,
                column: "BinCode",
                value: 676124);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 46,
                column: "BinCode",
                value: 979217);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 47,
                column: "BinCode",
                value: 979280);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 48,
                column: "BinCode",
                value: 516932);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 49,
                column: "BinCode",
                value: 525329);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 50,
                column: "BinCode",
                value: 512440);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 51,
                column: "BinCode",
                value: 523529);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 52,
                column: "BinCode",
                value: 513662);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 53,
                column: "BinCode",
                value: 537500);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 54,
                column: "BinCode",
                value: 543081);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 55,
                column: "BinCode",
                value: 552879);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 56,
                column: "BinCode",
                value: 639001);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 57,
                column: "BinCode",
                value: 676258);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 58,
                column: "BinCode",
                value: 979210);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 59,
                column: "BinCode",
                value: 979212);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 60,
                column: "BinCode",
                value: 979238);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 61,
                column: "BinCode",
                value: 526290);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 62,
                column: "BinCode",
                value: 401049);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 63,
                column: "BinCode",
                value: 415514);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 64,
                column: "BinCode",
                value: 415515);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 65,
                column: "BinCode",
                value: 416607);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 66,
                column: "BinCode",
                value: 421030);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 67,
                column: "BinCode",
                value: 979245);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 68,
                column: "BinCode",
                value: 979244);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 69,
                column: "BinCode",
                value: 423480);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 70,
                column: "BinCode",
                value: 447505);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 71,
                column: "BinCode",
                value: 451454);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 72,
                column: "BinCode",
                value: 456944);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 73,
                column: "BinCode",
                value: 466260);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 74,
                column: "BinCode",
                value: 478551);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 75,
                column: "BinCode",
                value: 492094);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 76,
                column: "BinCode",
                value: 492095);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 77,
                column: "BinCode",
                value: 498852);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 78,
                column: "BinCode",
                value: 499821);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 79,
                column: "BinCode",
                value: 510056);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 80,
                column: "BinCode",
                value: 521378);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 81,
                column: "BinCode",
                value: 526289);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 82,
                column: "BinCode",
                value: 527284);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 83,
                column: "BinCode",
                value: 535241);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 84,
                column: "BinCode",
                value: 536503);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 85,
                column: "BinCode",
                value: 540435);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 86,
                column: "BinCode",
                value: 415792);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 87,
                column: "BinCode",
                value: 416757);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 88,
                column: "BinCode",
                value: 423478);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 89,
                column: "BinCode",
                value: 428945);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 90,
                column: "BinCode",
                value: 434530);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 91,
                column: "BinCode",
                value: 434724);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 92,
                column: "BinCode",
                value: 442671);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 93,
                column: "BinCode",
                value: 459252);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 94,
                column: "BinCode",
                value: 479909);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 95,
                column: "BinCode",
                value: 483612);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 96,
                column: "BinCode",
                value: 491005);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 97,
                column: "BinCode",
                value: 493840);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 98,
                column: "BinCode",
                value: 493841);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 99,
                column: "BinCode",
                value: 493846);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 100,
                column: "BinCode",
                value: 520017);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 101,
                column: "BinCode",
                value: 522441);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 102,
                column: "BinCode",
                value: 531369);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 103,
                column: "BinCode",
                value: 535576);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 104,
                column: "BinCode",
                value: 535775);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 105,
                column: "BinCode",
                value: 540045);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 106,
                column: "BinCode",
                value: 540046);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 107,
                column: "BinCode",
                value: 542119);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 108,
                column: "BinCode",
                value: 542798);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 109,
                column: "BinCode",
                value: 979256);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 110,
                column: "BinCode",
                value: 979209);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 111,
                column: "BinCode",
                value: 650170);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 112,
                column: "BinCode",
                value: 650052);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 113,
                column: "BinCode",
                value: 589311);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 114,
                column: "BinCode",
                value: 555467);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 115,
                column: "BinCode",
                value: 554548);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 116,
                column: "BinCode",
                value: 552101);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 117,
                column: "BinCode",
                value: 547244);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 118,
                column: "BinCode",
                value: 542804);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 119,
                column: "BinCode",
                value: 537504);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 120,
                column: "BinCode",
                value: 409084);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 121,
                column: "BinCode",
                value: 402940);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 122,
                column: "BinCode",
                value: 411724);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 123,
                column: "BinCode",
                value: 411942);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 124,
                column: "BinCode",
                value: 411943);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 125,
                column: "BinCode",
                value: 411944);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 126,
                column: "BinCode",
                value: 411979);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 127,
                column: "BinCode",
                value: 497022);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 128,
                column: "BinCode",
                value: 489495);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 129,
                column: "BinCode",
                value: 489494);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 130,
                column: "BinCode",
                value: 479227);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 131,
                column: "BinCode",
                value: 469188);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 132,
                column: "BinCode",
                value: 459026);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 133,
                column: "BinCode",
                value: 455645);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 134,
                column: "BinCode",
                value: 450918);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 135,
                column: "BinCode",
                value: 447503);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 136,
                column: "BinCode",
                value: 979264);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 137,
                column: "BinCode",
                value: 979223);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 138,
                column: "BinCode",
                value: 676578);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 139,
                column: "BinCode",
                value: 676406);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 140,
                column: "BinCode",
                value: 606329);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 141,
                column: "BinCode",
                value: 553090);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 142,
                column: "BinCode",
                value: 552207);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 143,
                column: "BinCode",
                value: 550449);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 144,
                column: "BinCode",
                value: 549998);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 145,
                column: "BinCode",
                value: 547985);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 146,
                column: "BinCode",
                value: 545148);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 147,
                column: "BinCode",
                value: 545124);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 148,
                column: "BinCode",
                value: 537537);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 149,
                column: "BinCode",
                value: 542259);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 150,
                column: "BinCode",
                value: 535217);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 151,
                column: "BinCode",
                value: 440293);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 152,
                column: "BinCode",
                value: 440273);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 153,
                column: "BinCode",
                value: 440247);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 154,
                column: "BinCode",
                value: 439845);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 155,
                column: "BinCode",
                value: 438040);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 156,
                column: "BinCode",
                value: 427707);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 157,
                column: "BinCode",
                value: 427308);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 158,
                column: "BinCode",
                value: 416563);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 159,
                column: "BinCode",
                value: 416350);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 160,
                column: "BinCode",
                value: 413528);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 161,
                column: "BinCode",
                value: 406015);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 162,
                column: "BinCode",
                value: 404350);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 163,
                column: "BinCode",
                value: 404315);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 164,
                column: "BinCode",
                value: 402459);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 165,
                column: "BinCode",
                value: 402458);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 166,
                column: "BinCode",
                value: 402142);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 167,
                column: "BinCode",
                value: 440274);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 168,
                column: "BinCode",
                value: 440294);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 169,
                column: "BinCode",
                value: 534538);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 170,
                column: "BinCode",
                value: 440295);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 171,
                column: "BinCode",
                value: 532581);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 172,
                column: "BinCode",
                value: 531531);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 173,
                column: "BinCode",
                value: 530853);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 174,
                column: "BinCode",
                value: 528926);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 175,
                column: "BinCode",
                value: 528920);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 176,
                column: "BinCode",
                value: 525314);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 177,
                column: "BinCode",
                value: 524840);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 178,
                column: "BinCode",
                value: 524839);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 179,
                column: "BinCode",
                value: 524346);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 180,
                column: "BinCode",
                value: 519780);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 181,
                column: "BinCode",
                value: 512803);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 182,
                column: "BinCode",
                value: 512753);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 183,
                column: "BinCode",
                value: 510221);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 184,
                column: "BinCode",
                value: 510139);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 185,
                column: "BinCode",
                value: 510138);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 186,
                column: "BinCode",
                value: 489496);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 187,
                column: "BinCode",
                value: 432071);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 188,
                column: "BinCode",
                value: 516840);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 189,
                column: "BinCode",
                value: 535280);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 190,
                column: "BinCode",
                value: 535449);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 191,
                column: "BinCode",
                value: 550383);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 192,
                column: "BinCode",
                value: 553056);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 193,
                column: "BinCode",
                value: 557113);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 194,
                column: "BinCode",
                value: 557829);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 195,
                column: "BinCode",
                value: 589004);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 196,
                column: "BinCode",
                value: 979206);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 197,
                column: "BinCode",
                value: 534253);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 198,
                column: "BinCode",
                value: 979207);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 199,
                column: "BinCode",
                value: 979208);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 200,
                column: "BinCode",
                value: 516841);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 201,
                column: "BinCode",
                value: 516643);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 202,
                column: "BinCode",
                value: 512754);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 203,
                column: "BinCode",
                value: 493837);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 204,
                column: "BinCode",
                value: 479681);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 205,
                column: "BinCode",
                value: 479680);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 206,
                column: "BinCode",
                value: 474854);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 207,
                column: "BinCode",
                value: 474853);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 208,
                column: "BinCode",
                value: 435509);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 209,
                column: "BinCode",
                value: 435508);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 210,
                column: "BinCode",
                value: 432072);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 211,
                column: "BinCode",
                value: 520932);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 212,
                column: "BinCode",
                value: 425669);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 213,
                column: "BinCode",
                value: 413252);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 214,
                column: "BinCode",
                value: 524347);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 215,
                column: "BinCode",
                value: 521942);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 216,
                column: "BinCode",
                value: 521807);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 217,
                column: "BinCode",
                value: 552608);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 218,
                column: "BinCode",
                value: 552609);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 219,
                column: "BinCode",
                value: 521394);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 220,
                column: "BinCode",
                value: 525404);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 221,
                column: "BinCode",
                value: 530866);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 222,
                column: "BinCode",
                value: 547311);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 223,
                column: "BinCode",
                value: 549208);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 224,
                column: "BinCode",
                value: 549394);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 225,
                column: "BinCode",
                value: 589713);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 226,
                column: "BinCode",
                value: 650175);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 227,
                column: "BinCode",
                value: 676832);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 228,
                column: "BinCode",
                value: 979211);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 229,
                column: "BinCode",
                value: 979268);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 230,
                column: "BinCode",
                value: 411156);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 231,
                column: "BinCode",
                value: 411158);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 232,
                column: "BinCode",
                value: 411159);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 233,
                column: "BinCode",
                value: 411160);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 234,
                column: "BinCode",
                value: 421086);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 235,
                column: "BinCode",
                value: 423833);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 236,
                column: "BinCode",
                value: 519753);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 237,
                column: "BinCode",
                value: 494064);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 238,
                column: "BinCode",
                value: 459068);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 239,
                column: "BinCode",
                value: 489401);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 240,
                column: "BinCode",
                value: 411157);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 241,
                column: "BinCode",
                value: 516846);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 242,
                column: "BinCode",
                value: 403836);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 243,
                column: "BinCode",
                value: 409622);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 244,
                column: "BinCode",
                value: 520988);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 245,
                column: "BinCode",
                value: 521824);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 246,
                column: "BinCode",
                value: 521825);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 247,
                column: "BinCode",
                value: 522204);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 248,
                column: "BinCode",
                value: 524659);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 249,
                column: "BinCode",
                value: 526955);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 250,
                column: "BinCode",
                value: 528939);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 251,
                column: "BinCode",
                value: 528956);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 252,
                column: "BinCode",
                value: 533169);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 253,
                column: "BinCode",
                value: 534261);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 254,
                column: "BinCode",
                value: 535429);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 255,
                column: "BinCode",
                value: 535488);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 256,
                column: "BinCode",
                value: 537829);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 257,
                column: "BinCode",
                value: 538121);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 258,
                column: "BinCode",
                value: 538124);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 259,
                column: "BinCode",
                value: 538139);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 260,
                column: "BinCode",
                value: 538196);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 261,
                column: "BinCode",
                value: 540036);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 262,
                column: "BinCode",
                value: 540037);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 263,
                column: "BinCode",
                value: 540118);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 264,
                column: "BinCode",
                value: 517042);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 265,
                column: "BinCode",
                value: 517041);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 266,
                column: "BinCode",
                value: 517040);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 267,
                column: "BinCode",
                value: 516961);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 268,
                column: "BinCode",
                value: 432954);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 269,
                column: "BinCode",
                value: 448472);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 270,
                column: "BinCode",
                value: 462274);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 271,
                column: "BinCode",
                value: 467293);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 272,
                column: "BinCode",
                value: 467294);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 273,
                column: "BinCode",
                value: 467295);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 274,
                column: "BinCode",
                value: 474151);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 275,
                column: "BinCode",
                value: 474215);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 276,
                column: "BinCode",
                value: 479682);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 277,
                column: "BinCode",
                value: 479660);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 278,
                column: "BinCode",
                value: 482489);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 279,
                column: "BinCode",
                value: 482491);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 280,
                column: "BinCode",
                value: 487074);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 281,
                column: "BinCode",
                value: 487075);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 282,
                column: "BinCode",
                value: 489455);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 283,
                column: "BinCode",
                value: 489478);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 284,
                column: "BinCode",
                value: 479661);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 285,
                column: "BinCode",
                value: 622403);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 286,
                column: "BinCode",
                value: 542030);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 287,
                column: "BinCode",
                value: 541865);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 288,
                column: "BinCode",
                value: 540709);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 289,
                column: "BinCode",
                value: 540669);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 290,
                column: "BinCode",
                value: 377137);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 291,
                column: "BinCode",
                value: 377596);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 292,
                column: "BinCode",
                value: 377597);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 293,
                column: "BinCode",
                value: 377598);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 294,
                column: "BinCode",
                value: 377599);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 295,
                column: "BinCode",
                value: 401738);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 296,
                column: "BinCode",
                value: 403280);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 297,
                column: "BinCode",
                value: 403666);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 298,
                column: "BinCode",
                value: 404308);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 299,
                column: "BinCode",
                value: 405051);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 300,
                column: "BinCode",
                value: 405090);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 301,
                column: "BinCode",
                value: 406665);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 302,
                column: "BinCode",
                value: 406666);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 303,
                column: "BinCode",
                value: 409219);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 304,
                column: "BinCode",
                value: 410141);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 305,
                column: "BinCode",
                value: 413836);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 306,
                column: "BinCode",
                value: 420557);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 307,
                column: "BinCode",
                value: 426886);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 308,
                column: "BinCode",
                value: 426887);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 309,
                column: "BinCode",
                value: 426888);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 310,
                column: "BinCode",
                value: 426889);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 311,
                column: "BinCode",
                value: 427314);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 312,
                column: "BinCode",
                value: 427315);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 313,
                column: "BinCode",
                value: 428220);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 314,
                column: "BinCode",
                value: 428221);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 315,
                column: "BinCode",
                value: 375631);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 316,
                column: "BinCode",
                value: 432154);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 317,
                column: "BinCode",
                value: 375630);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 318,
                column: "BinCode",
                value: 375628);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 319,
                column: "BinCode",
                value: 374421);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 320,
                column: "BinCode",
                value: 374422);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 321,
                column: "BinCode",
                value: 374423);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 322,
                column: "BinCode",
                value: 374424);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 323,
                column: "BinCode",
                value: 374425);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 324,
                column: "BinCode",
                value: 374426);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 325,
                column: "BinCode",
                value: 374427);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 326,
                column: "BinCode",
                value: 374428);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 327,
                column: "BinCode",
                value: 375622);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 328,
                column: "BinCode",
                value: 375623);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 329,
                column: "BinCode",
                value: 375624);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 330,
                column: "BinCode",
                value: 375625);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 331,
                column: "BinCode",
                value: 375626);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 332,
                column: "BinCode",
                value: 375627);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 333,
                column: "BinCode",
                value: 375629);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 334,
                column: "BinCode",
                value: 432951);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 335,
                column: "BinCode",
                value: 432952);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 336,
                column: "BinCode",
                value: 432953);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 337,
                column: "BinCode",
                value: 517048);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 338,
                column: "BinCode",
                value: 517049);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 339,
                column: "BinCode",
                value: 520097);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 340,
                column: "BinCode",
                value: 520922);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 341,
                column: "BinCode",
                value: 520940);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 342,
                column: "BinCode",
                value: 479662);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 343,
                column: "BinCode",
                value: 979236);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 344,
                column: "BinCode",
                value: 979205);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 345,
                column: "BinCode",
                value: 685800);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 346,
                column: "BinCode",
                value: 676827);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 347,
                column: "BinCode",
                value: 676651);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 348,
                column: "BinCode",
                value: 676283);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 349,
                column: "BinCode",
                value: 482490);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 350,
                column: "BinCode",
                value: 516943);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 351,
                column: "BinCode",
                value: 514915);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 352,
                column: "BinCode",
                value: 493845);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 353,
                column: "BinCode",
                value: 492193);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 354,
                column: "BinCode",
                value: 492187);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 355,
                column: "BinCode",
                value: 492186);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 356,
                column: "BinCode",
                value: 490175);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 357,
                column: "BinCode",
                value: 676255);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 358,
                column: "BinCode",
                value: 670606);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 359,
                column: "BinCode",
                value: 638888);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 360,
                column: "BinCode",
                value: 589318);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 361,
                column: "BinCode",
                value: 558699);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 362,
                column: "BinCode",
                value: 557023);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 363,
                column: "BinCode",
                value: 554960);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 364,
                column: "BinCode",
                value: 554254);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 365,
                column: "BinCode",
                value: 554253);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 366,
                column: "BinCode",
                value: 553130);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 367,
                column: "BinCode",
                value: 549997);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 368,
                column: "BinCode",
                value: 548935);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 369,
                column: "BinCode",
                value: 544078);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 370,
                column: "BinCode",
                value: 543738);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 371,
                column: "BinCode",
                value: 418342);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 372,
                column: "BinCode",
                value: 403998);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 373,
                column: "BinCode",
                value: 535514);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 374,
                column: "BinCode",
                value: 535279);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 375,
                column: "BinCode",
                value: 534653);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 376,
                column: "BinCode",
                value: 533803);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 377,
                column: "BinCode",
                value: 525382);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 378,
                column: "BinCode",
                value: 510152);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 379,
                column: "BinCode",
                value: 489375);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 380,
                column: "BinCode",
                value: 483602);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 381,
                column: "BinCode",
                value: 479610);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 382,
                column: "BinCode",
                value: 473998);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 383,
                column: "BinCode",
                value: 418345);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 384,
                column: "BinCode",
                value: 438331);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 385,
                column: "BinCode",
                value: 540668);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 386,
                column: "BinCode",
                value: 441075);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 387,
                column: "BinCode",
                value: 540667);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 388,
                column: "BinCode",
                value: 537567);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 389,
                column: "BinCode",
                value: 537548);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 390,
                column: "BinCode",
                value: 473957);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 391,
                column: "BinCode",
                value: 979233);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 392,
                column: "BinCode",
                value: 979204);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 393,
                column: "BinCode",
                value: 537475);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 394,
                column: "BinCode",
                value: 650990);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 395,
                column: "BinCode",
                value: 650987);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 396,
                column: "BinCode",
                value: 650456);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 397,
                column: "BinCode",
                value: 650173);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 398,
                column: "BinCode",
                value: 650092);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 399,
                column: "BinCode",
                value: 650082);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 400,
                column: "BinCode",
                value: 589283);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 401,
                column: "BinCode",
                value: 559289);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 402,
                column: "BinCode",
                value: 553058);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 403,
                column: "BinCode",
                value: 552096);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 404,
                column: "BinCode",
                value: 545254);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 405,
                column: "BinCode",
                value: 548237);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 406,
                column: "BinCode",
                value: 543771);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 407,
                column: "BinCode",
                value: 420556);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 408,
                column: "BinCode",
                value: 441076);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 409,
                column: "BinCode",
                value: 441077);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 410,
                column: "BinCode",
                value: 450803);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 411,
                column: "BinCode",
                value: 454314);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 412,
                column: "BinCode",
                value: 454318);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 413,
                column: "BinCode",
                value: 454358);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 414,
                column: "BinCode",
                value: 454359);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 415,
                column: "BinCode",
                value: 454360);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 416,
                column: "BinCode",
                value: 460925);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 417,
                column: "BinCode",
                value: 473956);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 418,
                column: "BinCode",
                value: 418344);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 419,
                column: "BinCode",
                value: 418343);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 420,
                column: "BinCode",
                value: 552645);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 421,
                column: "BinCode",
                value: 639004);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 422,
                column: "BinCode",
                value: 650161);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 423,
                column: "BinCode",
                value: 657366);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 424,
                column: "BinCode",
                value: 657998);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 425,
                column: "BinCode",
                value: 676166);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 426,
                column: "BinCode",
                value: 979215);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 427,
                column: "BinCode",
                value: 979241);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 428,
                column: "BinCode",
                value: 979263);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 429,
                column: "BinCode",
                value: 603797);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 430,
                column: "BinCode",
                value: 554422);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 431,
                column: "BinCode",
                value: 552659);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 432,
                column: "BinCode",
                value: 479794);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 433,
                column: "BinCode",
                value: 479795);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 434,
                column: "BinCode",
                value: 490983);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 435,
                column: "BinCode",
                value: 491205);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 436,
                column: "BinCode",
                value: 491206);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 437,
                column: "BinCode",
                value: 492128);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 438,
                column: "BinCode",
                value: 492130);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 439,
                column: "BinCode",
                value: 492131);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 440,
                column: "BinCode",
                value: 494314);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 441,
                column: "BinCode",
                value: 523034);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 442,
                column: "BinCode",
                value: 525864);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 443,
                column: "BinCode",
                value: 533913);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 444,
                column: "BinCode",
                value: 535435);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 445,
                column: "BinCode",
                value: 535601);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 446,
                column: "BinCode",
                value: 535602);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 447,
                column: "BinCode",
                value: 537518);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 448,
                column: "BinCode",
                value: 537833);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 449,
                column: "BinCode",
                value: 540061);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 450,
                column: "BinCode",
                value: 540062);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 451,
                column: "BinCode",
                value: 540063);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 452,
                column: "BinCode",
                value: 540122);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 453,
                column: "BinCode",
                value: 540129);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 454,
                column: "BinCode",
                value: 542117);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 455,
                column: "BinCode",
                value: 545103);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 456,
                column: "BinCode",
                value: 549624);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 457,
                column: "BinCode",
                value: 479620);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 458,
                column: "BinCode",
                value: 479612);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 459,
                column: "BinCode",
                value: 455359);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 460,
                column: "BinCode",
                value: 401622);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 461,
                column: "BinCode",
                value: 404809);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 462,
                column: "BinCode",
                value: 406281);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 463,
                column: "BinCode",
                value: 413382);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 464,
                column: "BinCode",
                value: 414392);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 465,
                column: "BinCode",
                value: 420342);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 466,
                column: "BinCode",
                value: 420343);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 467,
                column: "BinCode",
                value: 434728);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 468,
                column: "BinCode",
                value: 434742);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 469,
                column: "BinCode",
                value: 434839);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 470,
                column: "BinCode",
                value: 442106);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 471,
                column: "BinCode",
                value: 446212);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 472,
                column: "BinCode",
                value: 450634);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 473,
                column: "BinCode",
                value: 477959);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 474,
                column: "BinCode",
                value: 437897);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 475,
                column: "BinCode",
                value: 555087);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 476,
                column: "BinCode",
                value: 553493);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 477,
                column: "BinCode",
                value: 471509);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 478,
                column: "BinCode",
                value: 558030);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 479,
                column: "BinCode",
                value: 552098);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 480,
                column: "BinCode",
                value: 589288);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 481,
                column: "BinCode",
                value: 529939);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 482,
                column: "BinCode",
                value: 677522);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 483,
                column: "BinCode",
                value: 518599);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 484,
                column: "BinCode",
                value: 419389);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 485,
                column: "BinCode",
                value: 455571);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 486,
                column: "BinCode",
                value: 554297);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 487,
                column: "BinCode",
                value: 479632);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 488,
                column: "BinCode",
                value: 550478);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 489,
                column: "BinCode",
                value: 550074);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 490,
                column: "BinCode",
                value: 548819);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 491,
                column: "BinCode",
                value: 547765);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 492,
                column: "BinCode",
                value: 542967);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 493,
                column: "BinCode",
                value: 542965);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 494,
                column: "BinCode",
                value: 542605);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 495,
                column: "BinCode",
                value: 542029);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 496,
                column: "BinCode",
                value: 540025);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 497,
                column: "BinCode",
                value: 540024);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 498,
                column: "BinCode",
                value: 676402);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 499,
                column: "BinCode",
                value: 979224);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 500,
                column: "BinCode",
                value: 979242);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 501,
                column: "BinCode",
                value: 535270);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 502,
                column: "BinCode",
                value: 535137);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 503,
                column: "BinCode",
                value: 532443);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 504,
                column: "BinCode",
                value: 531401);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 505,
                column: "BinCode",
                value: 526975);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 506,
                column: "BinCode",
                value: 526973);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 507,
                column: "BinCode",
                value: 517946);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 508,
                column: "BinCode",
                value: 514140);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 509,
                column: "BinCode",
                value: 603322);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 510,
                column: "BinCode",
                value: 510151);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 511,
                column: "BinCode",
                value: 490808);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 512,
                column: "BinCode",
                value: 490807);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 513,
                column: "BinCode",
                value: 490806);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 514,
                column: "BinCode",
                value: 490805);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 515,
                column: "BinCode",
                value: 479633);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 516,
                column: "BinCode",
                value: 480296);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 517,
                column: "BinCode",
                value: 400684);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 518,
                column: "BinCode",
                value: 408579);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 519,
                column: "BinCode",
                value: 408581);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 520,
                column: "BinCode",
                value: 414070);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 521,
                column: "BinCode",
                value: 420322);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 522,
                column: "BinCode",
                value: 420323);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 523,
                column: "BinCode",
                value: 423091);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 524,
                column: "BinCode",
                value: 554570);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 525,
                column: "BinCode",
                value: 676366);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 526,
                column: "BinCode",
                value: 420324);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 527,
                column: "BinCode",
                value: 671217);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 528,
                column: "BinCode",
                value: 979225);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 529,
                column: "BinCode",
                value: 603343);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 530,
                column: "BinCode",
                value: 559056);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 531,
                column: "BinCode",
                value: 557374);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 532,
                column: "BinCode",
                value: 543624);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 533,
                column: "BinCode",
                value: 527765);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 534,
                column: "BinCode",
                value: 527192);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 535,
                column: "BinCode",
                value: 527149);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 536,
                column: "BinCode",
                value: 522576);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 537,
                column: "BinCode",
                value: 522566);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 538,
                column: "BinCode",
                value: 522075);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 539,
                column: "BinCode",
                value: 517601);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 540,
                column: "BinCode",
                value: 468973);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 541,
                column: "BinCode",
                value: 434909);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 542,
                column: "BinCode",
                value: 423495);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 543,
                column: "BinCode",
                value: 603005);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 544,
                column: "BinCode",
                value: 979231);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 545,
                column: "BinCode",
                value: 676429);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 546,
                column: "BinCode",
                value: 545769);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 547,
                column: "BinCode",
                value: 527080);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 548,
                column: "BinCode",
                value: 456057);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 549,
                column: "BinCode",
                value: 521875);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 550,
                column: "BinCode",
                value: 514025);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 551,
                column: "BinCode",
                value: 445988);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 552,
                column: "BinCode",
                value: 413972);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 553,
                column: "BinCode",
                value: 413729);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 554,
                column: "BinCode",
                value: 979239);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 555,
                column: "BinCode",
                value: 589416);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 556,
                column: "BinCode",
                value: 456059);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 557,
                column: "BinCode",
                value: 558634);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 558,
                column: "BinCode",
                value: 545770);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 559,
                column: "BinCode",
                value: 547772);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 560,
                column: "BinCode",
                value: 479679);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 561,
                column: "BinCode",
                value: 547567);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 562,
                column: "BinCode",
                value: 545847);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 563,
                column: "BinCode",
                value: 545616);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 564,
                column: "BinCode",
                value: 979203);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 565,
                column: "BinCode",
                value: 677238);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 566,
                column: "BinCode",
                value: 499851);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 567,
                column: "BinCode",
                value: 499852);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 568,
                column: "BinCode",
                value: 499853);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 569,
                column: "BinCode",
                value: 516789);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 570,
                column: "BinCode",
                value: 516835);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 571,
                column: "BinCode",
                value: 516843);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 572,
                column: "BinCode",
                value: 519324);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 573,
                column: "BinCode",
                value: 521022);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 574,
                column: "BinCode",
                value: 521836);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 575,
                column: "BinCode",
                value: 526911);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 576,
                column: "BinCode",
                value: 529572);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 577,
                column: "BinCode",
                value: 530818);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 578,
                column: "BinCode",
                value: 531157);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 579,
                column: "BinCode",
                value: 545120);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 580,
                column: "BinCode",
                value: 542404);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 581,
                column: "BinCode",
                value: 539957);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 582,
                column: "BinCode",
                value: 537058);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 583,
                column: "BinCode",
                value: 535177);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 584,
                column: "BinCode",
                value: 414388);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 585,
                column: "BinCode",
                value: 420092);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 586,
                column: "BinCode",
                value: 415956);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 587,
                column: "BinCode",
                value: 415565);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 588,
                column: "BinCode",
                value: 498749);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 589,
                column: "BinCode",
                value: 459333);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 590,
                column: "BinCode",
                value: 422376);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 591,
                column: "BinCode",
                value: 427311);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 592,
                column: "BinCode",
                value: 410147);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 593,
                column: "BinCode",
                value: 409364);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 594,
                column: "BinCode",
                value: 431379);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 595,
                column: "BinCode",
                value: 406386);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 596,
                column: "BinCode",
                value: 403082);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 597,
                column: "BinCode",
                value: 402563);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 598,
                column: "BinCode",
                value: 402278);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 599,
                column: "BinCode",
                value: 435653);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 600,
                column: "BinCode",
                value: 439757);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 601,
                column: "BinCode",
                value: 441007);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 602,
                column: "BinCode",
                value: 442395);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 603,
                column: "BinCode",
                value: 499850);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 604,
                column: "BinCode",
                value: 979202);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 605,
                column: "BinCode",
                value: 601050);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 606,
                column: "BinCode",
                value: 559096);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 607,
                column: "BinCode",
                value: 547800);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 608,
                column: "BinCode",
                value: 402277);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 609,
                column: "BinCode",
                value: 401072);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 610,
                column: "BinCode",
                value: 556030);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 611,
                column: "BinCode",
                value: 677193);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 612,
                column: "BinCode",
                value: 405913);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 613,
                column: "BinCode",
                value: 405917);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 614,
                column: "BinCode",
                value: 405918);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 615,
                column: "BinCode",
                value: 405919);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 616,
                column: "BinCode",
                value: 408969);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 617,
                column: "BinCode",
                value: 409071);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 618,
                column: "BinCode",
                value: 422629);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 619,
                column: "BinCode",
                value: 424909);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 620,
                column: "BinCode",
                value: 428240);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 621,
                column: "BinCode",
                value: 496019);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 622,
                column: "BinCode",
                value: 510005);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 623,
                column: "BinCode",
                value: 512651);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 624,
                column: "BinCode",
                value: 519399);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 625,
                column: "BinCode",
                value: 525413);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 626,
                column: "BinCode",
                value: 525795);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 627,
                column: "BinCode",
                value: 540643);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 628,
                column: "BinCode",
                value: 542254);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 629,
                column: "BinCode",
                value: 545183);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 630,
                column: "BinCode",
                value: 550472);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 631,
                column: "BinCode",
                value: 550473);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 632,
                column: "BinCode",
                value: 552143);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 633,
                column: "BinCode",
                value: 979214);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 634,
                column: "BinCode",
                value: 556031);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 635,
                column: "BinCode",
                value: 556033);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 636,
                column: "BinCode",
                value: 556034);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 637,
                column: "BinCode",
                value: 405903);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 638,
                column: "BinCode",
                value: 556665);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 639,
                column: "BinCode",
                value: 676401);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 640,
                column: "BinCode",
                value: 365773);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 641,
                column: "BinCode",
                value: 365772);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 642,
                column: "BinCode",
                value: 365771);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 643,
                column: "BinCode",
                value: 365770);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 644,
                column: "BinCode",
                value: 979228);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 645,
                column: "BinCode",
                value: 670670);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 646,
                column: "BinCode",
                value: 654997);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 647,
                column: "BinCode",
                value: 558485);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 648,
                column: "BinCode",
                value: 544836);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 649,
                column: "BinCode",
                value: 522221);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 650,
                column: "BinCode",
                value: 516458);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 651,
                column: "BinCode",
                value: 516308);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 652,
                column: "BinCode",
                value: 512618);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 653,
                column: "BinCode",
                value: 466284);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 654,
                column: "BinCode",
                value: 466283);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 655,
                column: "BinCode",
                value: 466282);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 656,
                column: "BinCode",
                value: 466280);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 657,
                column: "BinCode",
                value: 416394);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 658,
                column: "BinCode",
                value: 545863);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 659,
                column: "BinCode",
                value: 535806);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 660,
                column: "BinCode",
                value: 491373);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 661,
                column: "BinCode",
                value: 414941);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 662,
                column: "BinCode",
                value: 543943);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 663,
                column: "BinCode",
                value: 424360);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 664,
                column: "BinCode",
                value: 979243);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 665,
                column: "BinCode",
                value: 979220);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 666,
                column: "BinCode",
                value: 677047);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 667,
                column: "BinCode",
                value: 670640);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 668,
                column: "BinCode",
                value: 670610);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 669,
                column: "BinCode",
                value: 601912);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 670,
                column: "BinCode",
                value: 558514);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 671,
                column: "BinCode",
                value: 558460);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 672,
                column: "BinCode",
                value: 558448);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 673,
                column: "BinCode",
                value: 558446);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 674,
                column: "BinCode",
                value: 558443);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 675,
                column: "BinCode",
                value: 555660);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 676,
                column: "BinCode",
                value: 555636);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 677,
                column: "BinCode",
                value: 555574);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 678,
                column: "BinCode",
                value: 552679);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 679,
                column: "BinCode",
                value: 549839);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 680,
                column: "BinCode",
                value: 546764);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 681,
                column: "BinCode",
                value: 543427);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 682,
                column: "BinCode",
                value: 543358);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 683,
                column: "BinCode",
                value: 408625);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 684,
                column: "BinCode",
                value: 403134);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 685,
                column: "BinCode",
                value: 409070);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 686,
                column: "BinCode",
                value: 424361);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 687,
                column: "BinCode",
                value: 460345);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 688,
                column: "BinCode",
                value: 533330);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 689,
                column: "BinCode",
                value: 533293);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 690,
                column: "BinCode",
                value: 529876);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 691,
                column: "BinCode",
                value: 529545);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 692,
                column: "BinCode",
                value: 523515);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 693,
                column: "BinCode",
                value: 520303);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 694,
                column: "BinCode",
                value: 520019);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 695,
                column: "BinCode",
                value: 517047);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 696,
                column: "BinCode",
                value: 516914);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 697,
                column: "BinCode",
                value: 516741);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 698,
                column: "BinCode",
                value: 516740);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 699,
                column: "BinCode",
                value: 516731);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 700,
                column: "BinCode",
                value: 514924);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 701,
                column: "BinCode",
                value: 512117);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 702,
                column: "BinCode",
                value: 512017);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 703,
                column: "BinCode",
                value: 510119);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 704,
                column: "BinCode",
                value: 510118);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 705,
                column: "BinCode",
                value: 510063);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 706,
                column: "BinCode",
                value: 508129);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 707,
                column: "BinCode",
                value: 489458);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 708,
                column: "BinCode",
                value: 489456);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 709,
                column: "BinCode",
                value: 472915);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 710,
                column: "BinCode",
                value: 472914);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 711,
                column: "BinCode",
                value: 460347);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 712,
                column: "BinCode",
                value: 460346);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 713,
                column: "BinCode",
                value: 425846);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 714,
                column: "BinCode",
                value: 425847);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 715,
                column: "BinCode",
                value: 425848);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 716,
                column: "BinCode",
                value: 558593);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 717,
                column: "BinCode",
                value: 554301);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 718,
                column: "BinCode",
                value: 535881);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 719,
                column: "BinCode",
                value: 522241);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 720,
                column: "BinCode",
                value: 522240);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 721,
                column: "BinCode",
                value: 441341);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 722,
                column: "BinCode",
                value: 425849);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 723,
                column: "BinCode",
                value: 979240);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 724,
                column: "BinCode",
                value: 979252);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 725,
                column: "BinCode",
                value: 676460);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 726,
                column: "BinCode",
                value: 517343);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 727,
                column: "BinCode",
                value: 528246);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 728,
                column: "BinCode",
                value: 532813);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 729,
                column: "BinCode",
                value: 534563);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 730,
                column: "BinCode",
                value: 534565);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 731,
                column: "BinCode",
                value: 534567);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 732,
                column: "BinCode",
                value: 453146);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 733,
                column: "BinCode",
                value: 453145);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 734,
                column: "BinCode",
                value: 453148);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 735,
                column: "BinCode",
                value: 453144);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 736,
                column: "BinCode",
                value: 535843);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 737,
                column: "BinCode",
                value: 504166);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 738,
                column: "BinCode",
                value: 549539);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 739,
                column: "BinCode",
                value: 453147);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 740,
                column: "BinCode",
                value: 515456);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 741,
                column: "BinCode",
                value: 453149);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 742,
                column: "BinCode",
                value: 581877);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 743,
                column: "BinCode",
                value: 671121);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 744,
                column: "BinCode",
                value: 671155);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 745,
                column: "BinCode",
                value: 979213);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 746,
                column: "BinCode",
                value: 979246);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 747,
                column: "BinCode",
                value: 670868);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 748,
                column: "BinCode",
                value: 526952);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 749,
                column: "BinCode",
                value: 524677);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 750,
                column: "BinCode",
                value: 522362);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 751,
                column: "BinCode",
                value: 522356);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 752,
                column: "BinCode",
                value: 522347);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 753,
                column: "BinCode",
                value: 519261);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 754,
                column: "BinCode",
                value: 516944);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 755,
                column: "BinCode",
                value: 469181);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 756,
                column: "BinCode",
                value: 469180);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 757,
                column: "BinCode",
                value: 527369);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 758,
                column: "BinCode",
                value: 979219);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 759,
                column: "BinCode",
                value: 536255);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 760,
                column: "BinCode",
                value: 468797);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 761,
                column: "BinCode",
                value: 468796);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 762,
                column: "BinCode",
                value: 468795);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 763,
                column: "BinCode",
                value: 468794);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 764,
                column: "BinCode",
                value: 468793);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 765,
                column: "BinCode",
                value: 468791);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 766,
                column: "BinCode",
                value: 528064);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 767,
                column: "BinCode",
                value: 527396);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 768,
                column: "BinCode",
                value: 527383);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 769,
                column: "BinCode",
                value: 474265);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 770,
                column: "BinCode",
                value: 547402);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 771,
                column: "BinCode",
                value: 536180);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 772,
                column: "BinCode",
                value: 432285);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 773,
                column: "BinCode",
                value: 434524);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 774,
                column: "BinCode",
                value: 434572);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 775,
                column: "BinCode",
                value: 463359);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 776,
                column: "BinCode",
                value: 479671);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 777,
                column: "BinCode",
                value: 534264);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 778,
                column: "BinCode",
                value: 533973);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 779,
                column: "BinCode",
                value: 533796);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 780,
                column: "BinCode",
                value: 511583);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 781,
                column: "BinCode",
                value: 547234);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 782,
                column: "BinCode",
                value: 417715);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 783,
                column: "BinCode",
                value: 417716);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 784,
                column: "BinCode",
                value: 423002);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 785,
                column: "BinCode",
                value: 424935);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 786,
                column: "BinCode",
                value: 548232);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 787,
                column: "BinCode",
                value: 432284);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 788,
                column: "BinCode",
                value: 627510);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 789,
                column: "BinCode",
                value: 979226);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 790,
                column: "BinCode",
                value: 677397);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 791,
                column: "BinCode",
                value: 979227);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 792,
                column: "BinCode",
                value: 677055);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 793,
                column: "BinCode",
                value: 979267);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 794,
                column: "BinCode",
                value: 557370);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 795,
                column: "BinCode",
                value: 547564);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 796,
                column: "BinCode",
                value: 539803);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 797,
                column: "BinCode",
                value: 535748);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 798,
                column: "BinCode",
                value: 439848);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 799,
                column: "BinCode",
                value: 402592);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 800,
                column: "BinCode",
                value: 403360);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 801,
                column: "BinCode",
                value: 431024);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 802,
                column: "BinCode",
                value: 439847);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 803,
                column: "BinCode",
                value: 525312);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 804,
                column: "BinCode",
                value: 520180);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 805,
                column: "BinCode",
                value: 518896);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 806,
                column: "BinCode",
                value: 512595);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 807,
                column: "BinCode",
                value: 511660);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 808,
                column: "BinCode",
                value: 483674);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 809,
                column: "BinCode",
                value: 483673);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 810,
                column: "BinCode",
                value: 439849);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 811,
                column: "BinCode",
                value: 402589);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 812,
                column: "BinCode",
                value: 402590);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 813,
                column: "BinCode",
                value: 402591);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 814,
                column: "BinCode",
                value: 527083);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 815,
                column: "BinCode",
                value: 527327);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 816,
                column: "BinCode",
                value: 528133);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 817,
                column: "BinCode",
                value: 979216);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 818,
                column: "BinCode",
                value: 518358);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 819,
                column: "BinCode",
                value: 512360);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 820,
                column: "BinCode",
                value: 511783);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 821,
                column: "BinCode",
                value: 511758);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 822,
                column: "BinCode",
                value: 498725);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 823,
                column: "BinCode",
                value: 498724);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 824,
                column: "BinCode",
                value: 485061);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 825,
                column: "BinCode",
                value: 479917);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 826,
                column: "BinCode",
                value: 479916);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 827,
                column: "BinCode",
                value: 479915);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 828,
                column: "BinCode",
                value: 979218);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 829,
                column: "BinCode",
                value: 677451);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 830,
                column: "BinCode",
                value: 606043);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 831,
                column: "BinCode",
                value: 552610);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 832,
                column: "BinCode",
                value: 549294);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 833,
                column: "BinCode",
                value: 400742);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 834,
                column: "BinCode",
                value: 404952);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 835,
                column: "BinCode",
                value: 411685);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 836,
                column: "BinCode",
                value: 416275);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 837,
                column: "BinCode",
                value: 424927);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 838,
                column: "BinCode",
                value: 428462);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 839,
                column: "BinCode",
                value: 435627);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 840,
                column: "BinCode",
                value: 435628);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 841,
                column: "BinCode",
                value: 435629);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 842,
                column: "BinCode",
                value: 441206);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 843,
                column: "BinCode",
                value: 470954);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 844,
                column: "BinCode",
                value: 521848);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 845,
                column: "BinCode",
                value: 537719);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 846,
                column: "BinCode",
                value: 541786);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 847,
                column: "BinCode",
                value: 528293);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 848,
                column: "BinCode",
                value: 519015);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 849,
                column: "BinCode",
                value: 539134);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 850,
                column: "BinCode",
                value: 535248);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 851,
                column: "BinCode",
                value: 979221);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 852,
                column: "BinCode",
                value: 527749);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 853,
                column: "BinCode",
                value: 557844);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 854,
                column: "BinCode",
                value: 525339);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 855,
                column: "BinCode",
                value: 416283);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 856,
                column: "BinCode",
                value: 670586);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 857,
                column: "BinCode",
                value: 535355);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 858,
                column: "BinCode",
                value: 558215);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 859,
                column: "BinCode",
                value: 670544);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 860,
                column: "BinCode",
                value: 979230);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 861,
                column: "BinCode",
                value: 979250);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 862,
                column: "BinCode",
                value: 483703);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 863,
                column: "BinCode",
                value: 483704);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 864,
                column: "BinCode",
                value: 547980);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 865,
                column: "BinCode",
                value: 979261);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 866,
                column: "BinCode",
                value: 498597);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 867,
                column: "BinCode",
                value: 535805);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 868,
                column: "BinCode",
                value: 534060);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 869,
                column: "BinCode",
                value: 439573);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 870,
                column: "BinCode",
                value: 439575);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 871,
                column: "BinCode",
                value: 528825);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 872,
                column: "BinCode",
                value: 520909);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 873,
                column: "BinCode",
                value: 516742);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 874,
                column: "BinCode",
                value: 515895);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 875,
                column: "BinCode",
                value: 515865);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 876,
                column: "BinCode",
                value: 512446);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 877,
                column: "BinCode",
                value: 492192);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 878,
                column: "BinCode",
                value: 476662);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 879,
                column: "BinCode",
                value: 404990);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 880,
                column: "BinCode",
                value: 474823);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 881,
                column: "BinCode",
                value: 539605);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 882,
                column: "BinCode",
                value: 521584);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 883,
                column: "BinCode",
                value: 979248);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 884,
                column: "BinCode",
                value: 979257);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 885,
                column: "BinCode",
                value: 439562);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 886,
                column: "BinCode",
                value: 439563);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 887,
                column: "BinCode",
                value: 478592);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 888,
                column: "BinCode",
                value: 478593);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 889,
                column: "BinCode",
                value: 478594);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 890,
                column: "BinCode",
                value: 531325);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 891,
                column: "BinCode",
                value: 535616);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 892,
                column: "BinCode",
                value: 538841);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 893,
                column: "BinCode",
                value: 542415);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 894,
                column: "BinCode",
                value: 559964);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 895,
                column: "BinCode",
                value: 650457);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 896,
                column: "BinCode",
                value: 979235);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 897,
                column: "BinCode",
                value: 460959);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 898,
                column: "BinCode",
                value: 548793);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 899,
                column: "BinCode",
                value: 539374);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 900,
                column: "BinCode",
                value: 531389);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 901,
                column: "BinCode",
                value: 529799);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 902,
                column: "BinCode",
                value: 460957);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 903,
                column: "BinCode",
                value: 460958);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 904,
                column: "BinCode",
                value: 535925);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 905,
                column: "BinCode",
                value: 536696);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 906,
                column: "BinCode",
                value: 533207);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 907,
                column: "BinCode",
                value: 979278);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 908,
                column: "BinCode",
                value: 979277);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 909,
                column: "BinCode",
                value: 979259);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 910,
                column: "BinCode",
                value: 979254);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 911,
                column: "BinCode",
                value: 979249);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 912,
                column: "BinCode",
                value: 671200);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 913,
                column: "BinCode",
                value: 537608);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 914,
                column: "BinCode",
                value: 434914);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 915,
                column: "BinCode",
                value: 434913);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 916,
                column: "BinCode",
                value: 979266);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 917,
                column: "BinCode",
                value: 473945);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 918,
                column: "BinCode",
                value: 478500);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 919,
                column: "BinCode",
                value: 555518);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 920,
                column: "BinCode",
                value: 463367);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 921,
                column: "BinCode",
                value: 460962);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 922,
                column: "BinCode",
                value: 439748);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 923,
                column: "BinCode",
                value: 471688);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 924,
                column: "BinCode",
                value: 434727);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 925,
                column: "BinCode",
                value: 535434);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 926,
                column: "BinCode",
                value: 439683);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 927,
                column: "BinCode",
                value: 979260);

            migrationBuilder.UpdateData(
                table: "CcBinCodes",
                keyColumn: "Id",
                keyValue: 928,
                column: "BinCode",
                value: 439724);
        }
    }
}
