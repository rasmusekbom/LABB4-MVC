using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bokhandel.Migrations
{
    public partial class smallfixesdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "BookUrl",
                value: "https://cdna.artstation.com/p/assets/images/images/010/777/898/large/alan-vilalte-prisonerofazkaban.jpg?1526182197");

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 30, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(3785), new DateTime(2022, 4, 30, 10, 25, 33, 144, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 1, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4405), new DateTime(2022, 5, 7, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 15, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4423), new DateTime(2022, 5, 5, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 6, 5, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4428), new DateTime(2022, 5, 2, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 31, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4434), new DateTime(2022, 5, 9, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4442), new DateTime(2022, 4, 25, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4448), new DateTime(2022, 5, 4, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4454), new DateTime(2022, 5, 4, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 27, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4459), new DateTime(2022, 4, 27, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 29, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4466), new DateTime(2022, 5, 3, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4472), new DateTime(2022, 5, 8, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4477), new DateTime(2022, 5, 5, 10, 25, 33, 146, DateTimeKind.Local).AddTicks(4475) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "BookUrl",
                value: "https://image.bokus.com/images/9789129723953_200x_harry-potter-och-fangen-fran-azkaban");

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(6212), new DateTime(2022, 4, 24, 13, 8, 32, 558, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7023), new DateTime(2022, 5, 1, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7044), new DateTime(2022, 4, 29, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 30, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 4, 26, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7105), new DateTime(2022, 5, 3, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7117), new DateTime(2022, 4, 19, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 18, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7124), new DateTime(2022, 4, 28, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 20, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 4, 28, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 21, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 4, 21, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 4, 27, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 20, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7153), new DateTime(2022, 5, 2, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 17, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 29, 13, 8, 32, 560, DateTimeKind.Local).AddTicks(7157) });
        }
    }
}
