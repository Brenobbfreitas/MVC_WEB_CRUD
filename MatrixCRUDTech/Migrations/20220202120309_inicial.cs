using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MatrixCRUDTech.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programa",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(70)", nullable: true),
                    PublicoAlvo = table.Column<string>(type: "varchar(70)", nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ObjMilenio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programa", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "IndicadorProgramas",
                columns: table => new
                {
                    IdIndicador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: true),
                    ProgramaCodigo = table.Column<int>(nullable: true),
                    UndMedida = table.Column<string>(type: "varchar(50)", nullable: true),
                    IndiceApuracao = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    IndiceDesejado = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicadorProgramas", x => x.IdIndicador);
                    table.ForeignKey(
                        name: "FK_IndicadorProgramas_Programa_ProgramaCodigo",
                        column: x => x.ProgramaCodigo,
                        principalTable: "Programa",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjetivoProgramas",
                columns: table => new
                {
                    IdObjetivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: true),
                    ProgramaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivoProgramas", x => x.IdObjetivo);
                    table.ForeignKey(
                        name: "FK_ObjetivoProgramas_Programa_ProgramaId",
                        column: x => x.ProgramaId,
                        principalTable: "Programa",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndicadorProgramas_ProgramaCodigo",
                table: "IndicadorProgramas",
                column: "ProgramaCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivoProgramas_ProgramaId",
                table: "ObjetivoProgramas",
                column: "ProgramaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicadorProgramas");

            migrationBuilder.DropTable(
                name: "ObjetivoProgramas");

            migrationBuilder.DropTable(
                name: "Programa");
        }
    }
}
