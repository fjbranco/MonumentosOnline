using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {

    /// <summary>
    /// Relação de Características com Monumentos de Muitos para Muitos
    /// </summary>
    public class CaractMonumentos {

        /// <summary>
        /// PK para a classe de relacionamento entre Características e Monumentos
        /// </summary>
        [Key]
        public int Id { get; set; }

        // ***************************************************

        /// <summary>
        /// FK para o Monumento
        /// </summary>
        [ForeignKey(nameof(Monumento))]
        public int MonumentoFK { get; set; }
        public Monumentos Monumento { get; set; }

        /// <summary>
        /// FK para a Característica
        /// </summary>
        [ForeignKey(nameof(Caracteristica))]
        public int? CaracteristicaFK { get; set; }
        public Caracteristicas Caracteristica { get; set; }
    }
}
