using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentosOnline.Migrations
{
    public partial class CorrecaoFKZeroMuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaractMonumentos_Caracteristicas_CaracteristicaFK",
                table: "CaractMonumentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Monumentos_Utilizadores_UtilizadorFK",
                table: "Monumentos");

            migrationBuilder.AlterColumn<int>(
                name: "UtilizadorFK",
                table: "Monumentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CaracteristicaFK",
                table: "CaractMonumentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CaractMonumentos_Caracteristicas_CaracteristicaFK",
                table: "CaractMonumentos",
                column: "CaracteristicaFK",
                principalTable: "Caracteristicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monumentos_Utilizadores_UtilizadorFK",
                table: "Monumentos",
                column: "UtilizadorFK",
                principalTable: "Utilizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaractMonumentos_Caracteristicas_CaracteristicaFK",
                table: "CaractMonumentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Monumentos_Utilizadores_UtilizadorFK",
                table: "Monumentos");

            migrationBuilder.AlterColumn<int>(
                name: "UtilizadorFK",
                table: "Monumentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CaracteristicaFK",
                table: "CaractMonumentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CaractMonumentos_Caracteristicas_CaracteristicaFK",
                table: "CaractMonumentos",
                column: "CaracteristicaFK",
                principalTable: "Caracteristicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monumentos_Utilizadores_UtilizadorFK",
                table: "Monumentos",
                column: "UtilizadorFK",
                principalTable: "Utilizadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
