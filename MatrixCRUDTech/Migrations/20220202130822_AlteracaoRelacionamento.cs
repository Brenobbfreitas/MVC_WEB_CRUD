using Microsoft.EntityFrameworkCore.Migrations;

namespace MatrixCRUDTech.Migrations
{
    public partial class AlteracaoRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndicadorProgramas_Programa_ProgramaCodigo",
                table: "IndicadorProgramas");

            migrationBuilder.DropIndex(
                name: "IX_IndicadorProgramas_ProgramaCodigo",
                table: "IndicadorProgramas");

            migrationBuilder.DropColumn(
                name: "ProgramaCodigo",
                table: "IndicadorProgramas");

            migrationBuilder.AddColumn<int>(
                name: "ProgramaID",
                table: "IndicadorProgramas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndicadorProgramas_ProgramaID",
                table: "IndicadorProgramas",
                column: "ProgramaID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IndicadorProgramas_Programa_ProgramaID",
                table: "IndicadorProgramas",
                column: "ProgramaID",
                principalTable: "Programa",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndicadorProgramas_Programa_ProgramaID",
                table: "IndicadorProgramas");

            migrationBuilder.DropIndex(
                name: "IX_IndicadorProgramas_ProgramaID",
                table: "IndicadorProgramas");

            migrationBuilder.DropColumn(
                name: "ProgramaID",
                table: "IndicadorProgramas");

            migrationBuilder.AddColumn<int>(
                name: "ProgramaCodigo",
                table: "IndicadorProgramas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndicadorProgramas_ProgramaCodigo",
                table: "IndicadorProgramas",
                column: "ProgramaCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_IndicadorProgramas_Programa_ProgramaCodigo",
                table: "IndicadorProgramas",
                column: "ProgramaCodigo",
                principalTable: "Programa",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
