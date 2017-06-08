using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Sala
    /// </summary>
    public class Sala
    {
        public int Cod { get; set; }
        public String Numero { get; set; }
        public String Descricao { get; set; }
        public int cod_bloco { get; set; }
        public int cod_andar { get; set; }

        public Sala() { }

       
        public Sala(int cod, String numero, String descricao, int cod_bloco, int cod_andar)
        {
            this.Cod = cod;
            this.Numero = numero;
            this.Descricao = descricao;
            this.cod_bloco = cod_bloco;
            this.cod_andar = cod_andar;
        }
    }
}
