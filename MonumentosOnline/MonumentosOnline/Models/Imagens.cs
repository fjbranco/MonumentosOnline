using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {

    /// <summary>
    /// Descrição de cada uma das Imagens do Monumento
    /// </summary>
    public class Imagens {

        /// <summary>
        /// Identificador de cada uma das Imagens
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do ficheiro da Imagem
        /// </summary>
        public string NomeImagem { get; set; }

        /// <summary>
        /// Define uma legenda da Imagem
        /// </summary>
        public string Legenda { get; set; }

        /// <summary>
        /// Define a data de criação da imagem
        /// </summary>
        public DateTime DataImagem { get; set; }

        /// <summary>
        /// Define o Estado da imagem para aceitação ou não na aplicação
        /// </summary>
        public string EstadoImagem { get; set; }
    }
}
