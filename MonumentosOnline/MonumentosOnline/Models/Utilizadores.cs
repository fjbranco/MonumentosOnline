using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonumentosOnline.Models {
    
    /// <summary>
    /// Utilizador registado na aplicação
    /// </summary>
    public class Utilizadores {
        
        /// <summary>
        /// Identificador de cada um dos Utilizadores
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Define o Login do Utilizador 
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Define a Password do Utilizador
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Identifica o Nome do Utilizador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Identifica a Localidade do Utilizador
        /// </summary>
        public string LocalidadeUtilizador { get; set; }

        /// <summary>
        /// Define o Email do Utilizador
        /// </summary>
        public string Email { get; set; }
    }
}
