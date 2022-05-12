using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bokhandel.Migrations
{
    public partial class addedbookurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookUrl",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "BookUrl",
                value: "https://media.bonnierforlagen.se/bokbilder/tif/9789100127473.jpg?timestamp=20160307042105");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "BookUrl",
                value: "https://media.bonnierforlagen.se/bokbilder/tif/9789100182496.jpg?timestamp=20200511074633");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "BookUrl",
                value: "https://image.bokus.com/images/9789129723953_200x_harry-potter-och-fangen-fran-azkaban");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "BookUrl",
                value: "https://donateanybook.com/wp-content/uploads/2020/06/the-da-vinci-code-589f9cee3df78c4758a2d9e7.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "BookUrl",
                value: "https://d3525k1ryd2155.cloudfront.net/h/525/436/535436525.0.m.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "BookUrl",
                value: "https://kbimages1-a.akamaihd.net/d33e35b8-5e64-42ce-a67e-102f934788d7/1200/1200/False/life-of-pi.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "BookUrl",
                value: "https://images-na.ssl-images-amazon.com/images/I/71nV-ZcSeAL.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookUrl",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 24, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(5388), new DateTime(2022, 4, 24, 12, 6, 51, 839, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 26, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 5, 1, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 9, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 4, 29, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 30, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6034), new DateTime(2022, 4, 26, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 25, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 5, 3, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6052), new DateTime(2022, 4, 19, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 18, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6059), new DateTime(2022, 4, 28, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 20, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6066), new DateTime(2022, 4, 28, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 21, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6073), new DateTime(2022, 4, 21, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 23, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6081), new DateTime(2022, 4, 27, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 20, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 5, 2, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 5, 17, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6095), new DateTime(2022, 4, 29, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6092) });
        }
    }
}
