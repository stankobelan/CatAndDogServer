using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAndDogServer.Migrations
{
    public partial class AdNameToPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Dogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cats");
        }
    }
}
