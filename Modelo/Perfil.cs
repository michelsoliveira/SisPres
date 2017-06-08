using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Perfil
    {
        #region Atributos

        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        #endregion
    }
}
