using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {
    
    /// <summary>
    /// Descrição de cada um dos Monumentos
    /// </summary>
    public class Monumentos {

        public Monumentos() {
            // Inicializar a lista de Imagens de cada um dos Monumentos
            ListaImagens = new HashSet<Imagens>();
            // Inicializar a lista de Características de cada um dos Monumentos
            ListaCaracteristicas = new HashSet<CaractMonumentos>();
        }

        /// <summary>
        /// Identificador de cada um dos Monumentos
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Identifica o Código SIPA do Sistema de Informação para o Património Arquitetónico
        /// </summary>
        public int CodSIPA { get; set; }

        /// <summary>
        /// Define uma breve designação do Monumento
        /// </summary>
        public string Designacao { get; set; }

        /// <summary>
        /// Faz uma descrição do Monumento
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Define a Época de construção do Monumento
        /// </summary>
        public string EpocaConstrucao { get; set; }

        /// <summary>
        /// Define o Arquiteto ou construtor do Monumento
        /// </summary>
        public string ArtitetoConstrutor { get; set; }

        /// <summary>
        /// Define um endereço do Monumento
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Define a Localidade do Monumento
        /// </summary>
        public string Localidade { get; set; }

        /// <summary>
        /// Define a Coordenada Latitude do Monumento
        /// </summary>
        public string CoordLatitude { get; set; }

        /// <summary>
        /// Define a Coordenada Longitude do Monumento
        /// </summary>
        public string CoordLongitude { get; set; }

        // ***************************************************

        /// <summary>
        /// FK para o Utilizador criador do Monumento
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        // ###################################################

        // associar os Monumentos às Imagens
        /// <summary>
        /// Lista de Imagens do Monumento
        /// </summary>
        public ICollection<Imagens> ListaImagens { get; set; }

        // associar os Monumentos às Caraterísticas
        /// <summary>
        /// Lista de Características do Monumento
        /// </summary>
        public ICollection<CaractMonumentos> ListaCaracteristicas { get; set; }
    }
}
