using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAndDogServer.Migrations
{
    public partial class PridanePocetUhriznuti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PocetUhriznuti",
                table: "Dogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PocetUhriznuti",
                table: "Dogs");
        }
    }
}
