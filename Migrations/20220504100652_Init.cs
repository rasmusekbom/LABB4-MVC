using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bokhandel.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 70, nullable: false),
                    Author = table.Column<string>(maxLength: 35, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNr = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBooks",
                columns: table => new
                {
                    CustomerBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsReturned = table.Column<bool>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBooks", x => x.CustomerBookId);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Sigge Eklund", "Bla bla bla", "In i labyrinten" },
                    { 2, "Alexander Schulman", "Bla bla bla", "The Survivors" },
                    { 3, "J.K Rowling", "Bla bla bla", "Harry Potter & The Prisoner From Azkaban" },
                    { 4, "Dan Brown", "Bla bla bla", "The Da Vinci Code" },
                    { 5, "Dan Brown", "Bla bla bla", "Angels and Demons" },
                    { 6, "Yann Martel", "Bla bla bla", "Life of Pi" },
                    { 7, "Sebastian Faulks", "Bla bla bla", "Birdsong" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "Name", "PhoneNr" },
                values: new object[,]
                {
                    { 1, "Olnirsvägen 50B", "rasmusekbom97@gmail.com", "Rasmus Ekbom", 768016461 },
                    { 2, "Olnirsvägen 50A", "anitrangoen@gmail.com", "Anitra Ngoensuwan", 768142421 },
                    { 3, "Freddegatan 1B", "fredrikolsson@gmail.com", "Fredrik Olsson", 761535155 },
                    { 4, "Kimgatan 13A", "kimtikkanen@gmail.com", "Kim Tikkanen", 767257257 },
                    { 5, "Sveddegatan 36B", "fredrikdsvedin@gmail.com", "Fredrik Svedin", 761351355 },
                    { 6, "Backböjen 4", "danielekbom@gmail.com", "Daniel Ekbom", 767646737 },
                    { 7, "Grothgatan 3B", "angroth@gmail.com", "An Groth", 768368388 },
                    { 8, "Umeågatan 74A", "albinandersson@gmail.com", "Albin Andersson", 761351355 }
                });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "EndDate", "IsReturned", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 5, 24, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(5388), false, new DateTime(2022, 4, 24, 12, 6, 51, 839, DateTimeKind.Local).AddTicks(7382) },
                    { 9, 2, 1, new DateTime(2022, 5, 21, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6073), false, new DateTime(2022, 4, 21, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6069) },
                    { 2, 2, 2, new DateTime(2022, 5, 26, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6005), true, new DateTime(2022, 5, 1, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(5984) },
                    { 10, 3, 2, new DateTime(2022, 5, 23, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6081), false, new DateTime(2022, 4, 27, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6078) },
                    { 3, 3, 3, new DateTime(2022, 5, 9, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6026), false, new DateTime(2022, 4, 29, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6022) },
                    { 11, 4, 3, new DateTime(2022, 5, 20, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6088), true, new DateTime(2022, 5, 2, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6085) },
                    { 4, 4, 4, new DateTime(2022, 5, 30, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6034), true, new DateTime(2022, 4, 26, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6031) },
                    { 12, 5, 4, new DateTime(2022, 5, 17, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6095), false, new DateTime(2022, 4, 29, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6092) },
                    { 5, 5, 5, new DateTime(2022, 5, 25, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6041), true, new DateTime(2022, 5, 3, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6038) },
                    { 6, 6, 6, new DateTime(2022, 5, 17, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6052), false, new DateTime(2022, 4, 19, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6048) },
                    { 7, 7, 7, new DateTime(2022, 5, 18, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6059), true, new DateTime(2022, 4, 28, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6055) },
                    { 8, 3, 8, new DateTime(2022, 5, 20, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6066), false, new DateTime(2022, 4, 28, 12, 6, 51, 841, DateTimeKind.Local).AddTicks(6062) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_BookId",
                table: "CustomerBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_CustomerId",
                table: "CustomerBooks",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
