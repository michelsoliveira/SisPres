using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pessoa
    {
        #region atributos

        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        #endregion
    }
}
