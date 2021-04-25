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
        
        // Representar as tabelas da BD
        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<Monumentos> Monumentos { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<Imagens> Imagens { get; set; }
        public DbSet<CaractMonumentos> CaractMonumentos { get; set; }
    }
}
