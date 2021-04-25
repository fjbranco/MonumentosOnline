using System;
using System.Collections.Generic;
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
        public int Id { get; set; }

    }
}
