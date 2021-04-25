using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {

    /// <summary>
    /// Descrição das caracteríticas do Monumento
    /// </summary>
    public class Caracteristicas {

        /// <summary>
        /// Identificador de cada uma das Características do Monumento
        /// </summary>
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
    }
}
