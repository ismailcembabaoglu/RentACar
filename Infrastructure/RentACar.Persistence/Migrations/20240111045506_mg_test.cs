using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OptionCount",
                table: "CarOptions",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptionCount",
                table: "CarOptions");
        }
    }
}
