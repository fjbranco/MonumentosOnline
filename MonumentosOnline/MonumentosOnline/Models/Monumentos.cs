using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {
    
    /// <summary>
    /// Descrição de cada um dos Monumentos
    /// </summary>
    public class Monumentos {

        /// <summary>
        /// Identificador de cada um dos Monumentos
        /// </summary>
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
    }
}
