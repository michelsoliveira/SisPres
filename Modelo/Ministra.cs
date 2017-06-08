using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Ministra
    {
        #region Atributos

        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        private DateTime data_min;

        public DateTime Data_min
        {
            get { return data_min; }
            set { data_min = value; }
        }
        private DateTime h_min;

        public DateTime H_min
        {
            get { return h_min; }
            set { h_min = value; }
        }


        #endregion
    }
}
