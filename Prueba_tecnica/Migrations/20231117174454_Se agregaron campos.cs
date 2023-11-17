using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_tecnica.Migrations
{
    /// <inheritdoc />
    public partial class Seagregaroncampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncuestaCampos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCampo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requerido = table.Column<bool>(type: "bit", nullable: true),
                    TipoCampo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    encuestasEncabezadoIDId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaCampos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EncuestaCampos_EncuestasEncabezados_encuestasEncabezadoIDId",
                        column: x => x.encuestasEncabezadoIDId,
                        principalTable: "EncuestasEncabezados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaCampos_encuestasEncabezadoIDId",
                table: "EncuestaCampos",
                column: "encuestasEncabezadoIDId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestaCampos");
        }
    }
}
