using Microsoft.EntityFrameworkCore.Migrations;

namespace DbOutOfNames.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    First = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Email", "First", "Last", "Password" },
                values: new object[,]
                {
                    { "CoffeeNotCode@yahoo.com", "Sam", "Relational", "R0CKYOu99999999" },
                    { "3MonsterEnergy@MoreRedbull.com", "Jackie", "Nonrelational", "PlainText4ThatWin" },
                    { "Java>SQL@truestatement.net", "Selma", "Crowsfoot", "S3lmaCrowsf00t" },
                    { "NoMoDb@ThatNastyDB.com", "Senor", "Casablanca", "" },
                    { "ItsBrokenAgain@Shocker.com", "Trevor", "Lastelick", "C4ntH4ckM3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
