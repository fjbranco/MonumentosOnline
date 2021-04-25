using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentosOnline.Migrations
{
    public partial class DadosTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Caracteristicas",
                columns: new[] { "Id", "ClassPatrimonial", "Estilo", "Tipo" },
                values: new object[,]
                {
                    { 1, "Património Mundial", "Gótico", "Edifício" },
                    { 2, "Património Nacional", "Gótico", "Edifício" },
                    { 3, "Património Mundial", "Manuelino", "Edifício" },
                    { 4, "Património Nacional", "Manuelino", "Edifício" },
                    { 5, "Património Mundial", "Renascentista", "Edifício" },
                    { 6, "Património Nacional", "Renascentista", "Edifício" },
                    { 7, "Património Mundial", "Maneirismo", "Edifício" },
                    { 8, "Património Nacional", "Maneirismo", "Edifício" },
                    { 9, "Património Mundial", "Românico", "Edifício" },
                    { 10, "Património Nacional", "Românico", "Edifício" },
                    { 11, "Património Mundial", "Medieval", "Edifício" },
                    { 12, "Património Nacional", "Medieval", "Edifício" },
                    { 13, "Património Mundial", "Barroco", "Edifício" },
                    { 14, "Património Nacional", "Barroco", "Edifício" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Id", "Email", "LocalidadeUtilizador", "Login", "Nome", "Password" },
                values: new object[,]
                {
                    { 1, "admin@monumentosonline.pt", "Data Center", "admin", "Administrador do Sistema", "123456" },
                    { 2, "novato@ipt.pt", "Tomar", "novato", "Utilizador Novato", "abcdef" }
                });

            migrationBuilder.InsertData(
                table: "Monumentos",
                columns: new[] { "Id", "ArtitetoConstrutor", "CodSIPA", "CoordLatitude", "CoordLongitude", "Descricao", "Designacao", "Endereco", "EpocaConstrucao", "Localidade", "UtilizadorFK" },
                values: new object[,]
                {
                    { 1, "Construtor do Convento de Cristo", 4718, "39 36 15 N", "08 25 22 O", "Descrição do Convento de Cristo", "Convento de Cristo", "Igreja do Castelo Templário, 2300-000 Tomar", "Séc. 12 / 15 / 16 / 17", "Tomar", 1 },
                    { 2, "Construtor da Igreja São João Baptista", 6538, "39 36 01 N", "08 24 51 O", "Descrição da Igreja São João Baptista", "Igreja de São João Baptista", "Rua São João 135, Tomar", "Séc. 14 / 15 (conjectural) / 16 / 17 / 18", "Tomar", 1 },
                    { 3, "Construtor do Mosteiro dos Jerónimos", 6543, "38 41 52 N", "09 12 24 O", "Descrição do Mosteiro dos Jerónimos", "Mosteiro dos Jerónimos", "Praça do Império 1400-206 Lisboa", "Séc. 16 / 17 / 18 / 19 / 20", "Lisboa", 1 },
                    { 4, "Construtor do Mosteiro da Batalha", 4061, "39 39 32 N", "08 49 33 O", "Descrição do Mosteiro da Batalha", "Mosteiro da Batalha", "Largo Infante Dom Henrique, 2440-109 Batalha", "Séc. 14 / 15 / 16 / 19 / 20", "Batalha", 1 },
                    { 5, "Construtor do Castelo de Leiria", 3312, "39 44 49 N", "08 48 34 O", "Descrição do Castelo de Leiria", "Castelo de Leiria", "Largo de São Pedro, 2400-235 Leiria", "Séc. 12 / 16 / 20", "Leiria", 1 },
                    { 6, "Construtor do Mosteiro de Alcobaça", 4719, "39 32 54 N", "08 58 48 O", "Descrição Mosteiro de Alcobaça", "Mosteiro de Alcobaça", "Praça 25 de Abril 2460-018 Alcobaça", "Séc. 12 / 14 / 16 / 18 / 19 / 20", "Alcobaça", 1 },
                    { 7, "Construtor do Castelo de São Jorge", 3128, "38 42 51 N", "09 08 00 O", "Descrição do Castelo de São Jorge", "Castelo de São Jorge", "Rua de Santa Cruz do Castelo, 1100-129 Lisboa", "Séc. 01 (conjectural)", "Lisboa", 1 },
                    { 8, "Construtor da Torre dos Clérigos", 5522, "41 08 45 N", "08 36 51 O", "Descrição da Torre dos Clérigos", "Torre dos Clérigos", "Rua de São Filipe de Nery, 4050-546 Porto", "Séc. 18", "Porto", 1 }
                });

            migrationBuilder.InsertData(
                table: "CaractMonumentos",
                columns: new[] { "Id", "CaracteristicaFK", "MonumentoFK" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 13, 3, 3 },
                    { 14, 4, 3 },
                    { 15, 1, 4 },
                    { 16, 2, 4 },
                    { 17, 3, 4 },
                    { 18, 4, 4 },
                    { 12, 4, 2 },
                    { 19, 2, 5 },
                    { 21, 1, 6 },
                    { 22, 2, 6 },
                    { 23, 3, 6 },
                    { 24, 4, 6 },
                    { 25, 7, 6 },
                    { 26, 8, 6 },
                    { 20, 10, 5 },
                    { 11, 2, 2 },
                    { 28, 14, 8 },
                    { 9, 9, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 10, 10, 1 },
                    { 27, 12, 7 },
                    { 8, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Imagens",
                columns: new[] { "Id", "DataImagem", "EstadoImagem", "Legenda", "MonumentoFK", "NomeImagem", "UtilizadorFK" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Castelo de São Jorge", 1, "CasteloSaoJorge.jpg", 1 },
                    { 2, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Igreja São João Baptista", 1, "IgrejaSaoJoaoBaptista.jpg", 1 },
                    { 3, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Mosteiro dos Jerónimos", 1, "MosteiroJeronimos.jpg", 1 },
                    { 4, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Mosteiro da Batalha", 1, "MosteiroBatalha.jpg", 1 },
                    { 5, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Castelo de Leiria", 1, "CasteloLeiria.jpg", 1 },
                    { 6, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Mosteiro de Alcobaça", 1, "MosteiroAlcobaca.jpg", 1 },
                    { 1, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Convento de Cristo", 1, "ConventoCristo.jpg", 1 },
                    { 8, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "S", "Torre dos Clérigos", 1, "TorreClerigos.jpg", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CaractMonumentos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Imagens",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Caracteristicas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Monumentos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
