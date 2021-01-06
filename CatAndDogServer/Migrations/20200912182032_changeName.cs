using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAndDogServer.Migrations
{
    public partial class changeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "PetOwners");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PetOwners",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PetOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Chovna stanica");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PetOwners");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "PetOwners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PetOwners",
                keyColumn: "Id",
                keyValue: 1,
                column: "FullName",
                value: "Chovna stanica");
        }
    }
}
