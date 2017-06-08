using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Localizacao
    /// </summary>
    public class Localizacao
    {
        
        
        public int Cod  { get; set; }
        public int cod_bloco { get; set; }
        public int cod_andar { get; set; }


        public Localizacao() {}

       /// <summary>
       /// 
       /// </summary>
       /// <param name="cod"></param>
       /// <param name="cod_bloco"></param>
       /// <param name="cod_andar"></param>
 
        public Localizacao(int cod, int cod_bloco, int cod_andar)
        {
            this.Cod = cod;
            this.cod_bloco = cod_bloco;
            this.cod_andar = cod_andar;
        }       

        

    }
}
