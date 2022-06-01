using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblLineas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLineas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblMarcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMarcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionLarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscoDuroHDD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscoDuroSSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPUIntegrada = table.Column<bool>(type: "bit", nullable: false),
                    GPUDedicada = table.Column<bool>(type: "bit", nullable: false),
                    GPUDedicadaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HzPantalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InPantalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    LineaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEquipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEquipos_tblCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tblCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEquipos_tblLineas_LineaId",
                        column: x => x.LineaId,
                        principalTable: "tblLineas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEquipos_tblMarcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "tblMarcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEquipos_CategoriaId",
                table: "tblEquipos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEquipos_LineaId",
                table: "tblEquipos",
                column: "LineaId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEquipos_MarcaId",
                table: "tblEquipos",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEquipos");

            migrationBuilder.DropTable(
                name: "tblCategorias");

            migrationBuilder.DropTable(
                name: "tblLineas");

            migrationBuilder.DropTable(
                name: "tblMarcas");
        }
    }
}
