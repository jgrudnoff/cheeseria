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
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheeses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cheeses",
                columns: new[] { "Id", "Colour", "Name", "PricePerKilo" },
                values: new object[,]
                {
                    { 1, "Light Yellow", "Cheddar", 1f },
                    { 2, "White", "Feta", 1f },
                    { 3, "White with Blue Pigment", "Gorgonzola", 1f },
                    { 4, "Light Yellow", "Gouda", 1f },
                    { 5, "White", "Aarenwasser", 8f }
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
