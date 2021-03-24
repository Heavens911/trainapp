using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationForCeiling.Migrations
{
    public partial class updateorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Angle",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lustra",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "P",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Pipe",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "S",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Spot",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Angle",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Lustra",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "P",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Pipe",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "S",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Spot",
                table: "Orders");
        }
    }
}
