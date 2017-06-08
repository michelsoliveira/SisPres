using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Bloco
    /// </summary>
    public class Bloco
    {

        private int cod { get; set; }
        private string nome { get; set; }
        private string descricao { get; set; }

        public Bloco() { }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nome"></param>
        /// <param name="descricao"></param>
        public Bloco(int cod, string nome, string descricao)
        {
            this.cod = cod;
            this.nome = nome;
           this.descricao = descricao;   
        }
    }
}
