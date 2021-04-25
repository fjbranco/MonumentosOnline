using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentosOnline.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caracteristicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassPatrimonial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadeUtilizador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodSIPA = table.Column<int>(type: "int", nullable: false),
                    Designacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpocaConstrucao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtitetoConstrutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordLatitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoordLongitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UtilizadorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monumentos_Utilizadores_UtilizadorFK",
                        column: x => x.UtilizadorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaractMonumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonumentoFK = table.Column<int>(type: "int", nullable: false),
                    CaracteristicaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaractMonumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaractMonumentos_Caracteristicas_CaracteristicaFK",
                        column: x => x.CaracteristicaFK,
                        principalTable: "Caracteristicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaractMonumentos_Monumentos_MonumentoFK",
                        column: x => x.MonumentoFK,
                        principalTable: "Monumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Legenda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataImagem = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonumentoFK = table.Column<int>(type: "int", nullable: false),
                    UtilizadorFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagens_Monumentos_MonumentoFK",
                        column: x => x.MonumentoFK,
                        principalTable: "Monumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imagens_Utilizadores_UtilizadorFK",
                        column: x => x.UtilizadorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaractMonumentos_CaracteristicaFK",
                table: "CaractMonumentos",
                column: "CaracteristicaFK");

            migrationBuilder.CreateIndex(
                name: "IX_CaractMonumentos_MonumentoFK",
                table: "CaractMonumentos",
                column: "MonumentoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_MonumentoFK",
                table: "Imagens",
                column: "MonumentoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_UtilizadorFK",
                table: "Imagens",
                column: "UtilizadorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Monumentos_UtilizadorFK",
                table: "Monumentos",
                column: "UtilizadorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaractMonumentos");

            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "Caracteristicas");

            migrationBuilder.DropTable(
                name: "Monumentos");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
