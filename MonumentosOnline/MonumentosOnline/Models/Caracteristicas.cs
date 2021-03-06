using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {

    /// <summary>
    /// Descrição das caracteríticas do Monumento
    /// </summary>
    public class Caracteristicas {

        public Caracteristicas() {
            // Inicializar a lista de Monumentos de cada uma das Características
            ListaMonumentos = new HashSet<CaractMonumentos>();
        }

        /// <summary>
        /// Identificador de cada uma das Características do Monumento
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Descreve o tipo do Monumento, se edifício, estátua, escultura, castelo, palácio, natural ou outro
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Descreve o estilo do Monumento, se Barroco, Manuelino, renascentista, gótico ou outro
        /// </summary>
        public string Estilo { get; set; }

        /// <summary>
        /// Descreve a Classificação Patrimonial do Monumento, se Nacional ou Mundial, Imóvel de Interesse Público ou Imóvel de Interesse Municipal
        /// </summary>
        public string ClassPatrimonial { get; set; }

        // ###################################################

        /// <summary>
        /// Lista de Monumentos associados às Características
        /// </summary>
        public ICollection<CaractMonumentos> ListaMonumentos { get; set; }
    }
}
