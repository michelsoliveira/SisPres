using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Andar
    /// </summary>
    public class Andar
    {
        public int Cod { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        
        public Andar() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="numero"></param>
        /// <param name="descricao"></param>
        public Andar(int cod, string numero, string descricao) 
        {
            this.Cod = cod;
            this.Numero = numero;
            this.Descricao = descricao;
        
        }
    
    }
}
