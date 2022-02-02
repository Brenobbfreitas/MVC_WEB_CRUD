using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MatrixCRUDTech.Migrations
{
    public partial class ColunaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "IndicadorProgramas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "IndicadorProgramas");
        }
    }
}
