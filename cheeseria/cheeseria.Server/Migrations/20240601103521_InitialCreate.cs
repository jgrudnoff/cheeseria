using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cheeseria.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cheeses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerKilo = table.Column<float>(type: "real", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheeses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cheeses",
                columns: new[] { "Id", "Colour", "CreatedDate", "ModifiedDate", "Name", "PricePerKilo" },
                values: new object[,]
                {
                    { 1, "Light Yellow", new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2371), new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2381), "Cheddar", 7f },
                    { 2, "White", new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2383), "Feta", 50f },
                    { 3, "White with Blue Pigment", new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2384), new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2384), "Gorgonzola", 21f },
                    { 4, "Light Yellow", new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2385), new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2385), "Gouda", 3f },
                    { 5, "White", new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2386), new DateTime(2024, 6, 1, 20, 35, 21, 207, DateTimeKind.Local).AddTicks(2387), "Aarenwasser", 8f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cheeses");
        }
    }
}
