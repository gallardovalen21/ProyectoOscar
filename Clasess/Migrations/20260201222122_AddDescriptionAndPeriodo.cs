using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clasess.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionAndPeriodo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subscriptions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Periodo",
                table: "Subscriptions",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Periodo",
                table: "Subscriptions");
        }
    }
}
