using Microsoft.EntityFrameworkCore.Migrations;

namespace DbOutOfNames.Migrations
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "Persons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.CountryId);
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { "C", "Canada" },
                    { "D", "Dominican Republic" },
                    { "E", "Ecaudor" },
                    { "M", "Mexico" },
                    { "U", "United States" }
                });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Email",
                keyValue: "3MonsterEnergy@MoreRedbull.com",
                column: "CountryId",
                value: "D");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Email",
                keyValue: "CoffeeNotCode@yahoo.com",
                column: "CountryId",
                value: "C");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Email",
                keyValue: "ItsBrokenAgain@Shocker.com",
                column: "CountryId",
                value: "U");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Email",
                keyValue: "Java>SQL@truestatement.net",
                column: "CountryId",
                value: "E");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Email",
                keyValue: "NoMoDb@ThatNastyDB.com",
                column: "CountryId",
                value: "M");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Countrys_CountryId",
                table: "Persons",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Countrys_CountryId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CountryId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Persons");
        }
    }
}
