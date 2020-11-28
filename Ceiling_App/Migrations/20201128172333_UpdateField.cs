using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ceiling_App.Migrations
{
    public partial class UpdateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientClientId",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Clients",
                type: "datetimeoffset",
                nullable: false,
                defaultValueSql: "(getdate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "ClientClientId");
        }
    }
}
