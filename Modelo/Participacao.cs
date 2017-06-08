using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Participacao
    {
        #region Atributos

        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        private DateTime data_part;

        public DateTime Data_part
        {
            get { return data_part; }
            set { data_part = value; }
        }
        private DateTime h_part;

        public DateTime H_part
        {
            get { return h_part; }
            set { h_part = value; }
        }


        #endregion
    }
}
