using Microsoft.EntityFrameworkCore;
using MonumentosOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Data {
    /// <summary>
    /// Representa a Base de Dados da aplicação Web
    /// </summary>
    public class Monumentos_OnlineDB : DbContext {

        // construtor da classe Monumentos_OnlineDB para indicar a a BD à qual as classes estão associadas
        public Monumentos_OnlineDB(DbContextOptions<Monumentos_OnlineDB> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            // insert DB seed
            modelBuilder.Entity<Utilizadores>().HasData(
                new Utilizadores { Id = 1, Login = "admin", Password="123456", Nome = "Administrador do Sistema", LocalidadeUtilizador="Data Center", Email="admin@monumentosonline.pt" },
                new Utilizadores { Id = 2, Login = "novato", Password = "abcdef", Nome = "Utilizador Novato", LocalidadeUtilizador = "Tomar", Email = "novato@ipt.pt" }
                );

            modelBuilder.Entity<Monumentos>().HasData(
                new Monumentos { Id = 1, CodSIPA = 4718, Designacao = "Convento de Cristo", Descricao = "Descrição do Convento de Cristo", EpocaConstrucao = "Séc. 12 / 15 / 16 / 17", ArtitetoConstrutor = "Construtor do Convento de Cristo", Endereco = "Igreja do Castelo Templário, 2300-000 Tomar", Localidade = "Tomar", CoordLatitude = "39 36 15 N", CoordLongitude = "08 25 22 O", UtilizadorFK = 1 },
                new Monumentos { Id = 2, CodSIPA = 6538, Designacao = "Igreja de São João Baptista", Descricao = "Descrição da Igreja São João Baptista", EpocaConstrucao = "Séc. 14 / 15 (conjectural) / 16 / 17 / 18", ArtitetoConstrutor = "Construtor da Igreja São João Baptista", Endereco = "Rua São João 135, Tomar", Localidade = "Tomar", CoordLatitude = "39 36 01 N", CoordLongitude = "08 24 51 O", UtilizadorFK = 1 },
                new Monumentos { Id = 3, CodSIPA = 6543, Designacao = "Mosteiro dos Jerónimos", Descricao = "Descrição do Mosteiro dos Jerónimos", EpocaConstrucao = "Séc. 16 / 17 / 18 / 19 / 20", ArtitetoConstrutor = "Construtor do Mosteiro dos Jerónimos", Endereco = "Praça do Império 1400-206 Lisboa", Localidade = "Lisboa", CoordLatitude = "38 41 52 N", CoordLongitude = "09 12 24 O", UtilizadorFK = 1 },
                new Monumentos { Id = 4, CodSIPA = 4061, Designacao = "Mosteiro da Batalha", Descricao = "Descrição do Mosteiro da Batalha", EpocaConstrucao = "Séc. 14 / 15 / 16 / 19 / 20", ArtitetoConstrutor = "Construtor do Mosteiro da Batalha", Endereco = "Largo Infante Dom Henrique, 2440-109 Batalha", Localidade = "Batalha", CoordLatitude = "39 39 32 N", CoordLongitude = "08 49 33 O", UtilizadorFK = 1 },
                new Monumentos { Id = 5, CodSIPA = 3312, Designacao = "Castelo de Leiria", Descricao = "Descrição do Castelo de Leiria", EpocaConstrucao = "Séc. 12 / 16 / 20", ArtitetoConstrutor = "Construtor do Castelo de Leiria", Endereco = "Largo de São Pedro, 2400-235 Leiria", Localidade = "Leiria", CoordLatitude = "39 44 49 N", CoordLongitude = "08 48 34 O", UtilizadorFK = 1 },
                new Monumentos { Id = 6, CodSIPA = 4719, Designacao = "Mosteiro de Alcobaça", Descricao = "Descrição Mosteiro de Alcobaça", EpocaConstrucao = "Séc. 12 / 14 / 16 / 18 / 19 / 20", ArtitetoConstrutor = "Construtor do Mosteiro de Alcobaça", Endereco = "Praça 25 de Abril 2460-018 Alcobaça", Localidade = "Alcobaça", CoordLatitude = "39 32 54 N", CoordLongitude = "08 58 48 O", UtilizadorFK = 1 },
                new Monumentos { Id = 7, CodSIPA = 3128, Designacao = "Castelo de São Jorge", Descricao = "Descrição do Castelo de São Jorge", EpocaConstrucao = "Séc. 01 (conjectural)", ArtitetoConstrutor = "Construtor do Castelo de São Jorge", Endereco = "Rua de Santa Cruz do Castelo, 1100-129 Lisboa", Localidade = "Lisboa", CoordLatitude = "38 42 51 N", CoordLongitude = "09 08 00 O", UtilizadorFK = 1 },
                new Monumentos { Id = 8, CodSIPA = 5522, Designacao = "Torre dos Clérigos", Descricao = "Descrição da Torre dos Clérigos", EpocaConstrucao = "Séc. 18", ArtitetoConstrutor = "Construtor da Torre dos Clérigos", Endereco = "Rua de São Filipe de Nery, 4050-546 Porto", Localidade = "Porto", CoordLatitude = "41 08 45 N", CoordLongitude = "08 36 51 O", UtilizadorFK = 1 }
                );

            modelBuilder.Entity<Imagens>().HasData(
                new Imagens { Id = 1, NomeImagem = "ConventoCristo.jpg", Legenda = "Convento de Cristo", DataImagem = new DateTime(2021, 4, 23), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 2, NomeImagem = "IgrejaSaoJoaoBaptista.jpg", Legenda = "Igreja São João Baptista", DataImagem = new DateTime(2021, 4, 23), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 3, NomeImagem = "MosteiroJeronimos.jpg", Legenda = "Mosteiro dos Jerónimos", DataImagem = new DateTime(2021, 4, 22), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 4, NomeImagem = "MosteiroBatalha.jpg", Legenda = "Mosteiro da Batalha", DataImagem = new DateTime(2021, 4, 24), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 5, NomeImagem = "CasteloLeiria.jpg", Legenda = "Castelo de Leiria", DataImagem = new DateTime(2021, 4, 24), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 6, NomeImagem = "MosteiroAlcobaca.jpg", Legenda = "Mosteiro de Alcobaça", DataImagem = new DateTime(2021, 4, 24), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 7, NomeImagem = "CasteloSaoJorge.jpg", Legenda = "Castelo de São Jorge", DataImagem = new DateTime(2021, 4, 22), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 },
                new Imagens { Id = 8, NomeImagem = "TorreClerigos.jpg", Legenda = "Torre dos Clérigos", DataImagem = new DateTime(2021, 4, 23), EstadoImagem = "S", MonumentoFK = 1, UtilizadorFK = 1 }
                );

            modelBuilder.Entity<Caracteristicas>().HasData(
                new Caracteristicas { Id = 1, Tipo = "Edifício", Estilo = "Gótico", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 2, Tipo = "Edifício", Estilo = "Gótico", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 3, Tipo = "Edifício", Estilo = "Manuelino", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 4, Tipo = "Edifício", Estilo = "Manuelino", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 5, Tipo = "Edifício", Estilo = "Renascentista", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 6, Tipo = "Edifício", Estilo = "Renascentista", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 7, Tipo = "Edifício", Estilo = "Maneirismo", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 8, Tipo = "Edifício", Estilo = "Maneirismo", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 9, Tipo = "Edifício", Estilo = "Românico", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 10, Tipo = "Edifício", Estilo = "Românico", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 11, Tipo = "Edifício", Estilo = "Medieval", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 12, Tipo = "Edifício", Estilo = "Medieval", ClassPatrimonial = "Património Nacional" },
                new Caracteristicas { Id = 13, Tipo = "Edifício", Estilo = "Barroco", ClassPatrimonial = "Património Mundial" },
                new Caracteristicas { Id = 14, Tipo = "Edifício", Estilo = "Barroco", ClassPatrimonial = "Património Nacional" }
                );

            modelBuilder.Entity<CaractMonumentos>().HasData(
                new CaractMonumentos { Id = 1, MonumentoFK = 1, CaracteristicaFK = 1 },
                new CaractMonumentos { Id = 2, MonumentoFK = 1, CaracteristicaFK = 2 },
                new CaractMonumentos { Id = 3, MonumentoFK = 1, CaracteristicaFK = 3 },
                new CaractMonumentos { Id = 4, MonumentoFK = 1, CaracteristicaFK = 4 },
                new CaractMonumentos { Id = 5, MonumentoFK = 1, CaracteristicaFK = 5 },
                new CaractMonumentos { Id = 6, MonumentoFK = 1, CaracteristicaFK = 6 },
                new CaractMonumentos { Id = 7, MonumentoFK = 1, CaracteristicaFK = 7 },
                new CaractMonumentos { Id = 8, MonumentoFK = 1, CaracteristicaFK = 8 },
                new CaractMonumentos { Id = 9, MonumentoFK = 1, CaracteristicaFK = 9 },
                new CaractMonumentos { Id = 10, MonumentoFK = 1, CaracteristicaFK = 10 },
                new CaractMonumentos { Id = 11, MonumentoFK = 2, CaracteristicaFK = 2 },
                new CaractMonumentos { Id = 12, MonumentoFK = 2, CaracteristicaFK = 4 },
                new CaractMonumentos { Id = 13, MonumentoFK = 3, CaracteristicaFK = 3 },
                new CaractMonumentos { Id = 14, MonumentoFK = 3, CaracteristicaFK = 4 },
                new CaractMonumentos { Id = 15, MonumentoFK = 4, CaracteristicaFK = 1 },
                new CaractMonumentos { Id = 16, MonumentoFK = 4, CaracteristicaFK = 2 },
                new CaractMonumentos { Id = 17, MonumentoFK = 4, CaracteristicaFK = 3 },
                new CaractMonumentos { Id = 18, MonumentoFK = 4, CaracteristicaFK = 4 },
                new CaractMonumentos { Id = 19, MonumentoFK = 5, CaracteristicaFK = 2 },
                new CaractMonumentos { Id = 20, MonumentoFK = 5, CaracteristicaFK = 10 },
                new CaractMonumentos { Id = 21, MonumentoFK = 6, CaracteristicaFK = 1 },
                new CaractMonumentos { Id = 22, MonumentoFK = 6, CaracteristicaFK = 2 },
                new CaractMonumentos { Id = 23, MonumentoFK = 6, CaracteristicaFK = 3 },
                new CaractMonumentos { Id = 24, MonumentoFK = 6, CaracteristicaFK = 4 },
                new CaractMonumentos { Id = 25, MonumentoFK = 6, CaracteristicaFK = 7 },
                new CaractMonumentos { Id = 26, MonumentoFK = 6, CaracteristicaFK = 8 },
                new CaractMonumentos { Id = 27, MonumentoFK = 7, CaracteristicaFK = 12 },
                new CaractMonumentos { Id = 28, MonumentoFK = 8, CaracteristicaFK = 14 }
                );

        }

        // Representar as tabelas da BD
        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<Monumentos> Monumentos { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<CaractMonumentos> CaractMonumentos { get; set; }
    }
}
