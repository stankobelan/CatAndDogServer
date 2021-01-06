using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatAndDogServer.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 12A", 1, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 23A", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat A15", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 15A", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 118A", 5, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 135A", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat A1558", 6, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat 1651A", 8, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { "Cat A15", 7, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat A115", 9, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat Acd", 9, 1 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat daA", 10, 2 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat cdsaA", 11, 2 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat csaA", 12, 2 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cat Acs", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog xY", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog xY", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2013, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog 5Y", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog x6", 10, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog 4Y", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog 8Y", 5, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog 9Y", 7, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog x7", 8, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog 1Y", 9, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2011, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog a12BS", 10, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2012, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog aa56S", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2013, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog aa45S", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog aa12S", 5, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog aaB35", 8, 3 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2014, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dog aa458", 7, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetMaciatok" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DatumNarodenia", "Name", "PocetKrmeni", "PocetUhriznuti" },
                values: new object[] { new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });
        }
    }
}
