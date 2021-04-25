using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
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

        // ***************************************************

        /// <summary>
        /// FK para o Monumento ao qual pertence a Imagem
        /// </summary>
        [ForeignKey(nameof(Monumento))]
        public int MonumentoFK { get; set; }
        public Monumentos Monumento { get; set; }

        /// <summary>
        /// FK para o Utilizador criador da Imagem
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizadores Utilizador { get; set; }


    }
}
