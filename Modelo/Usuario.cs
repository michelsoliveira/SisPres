using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    /// <summary>
    /// Modelo de Usuários
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Propriedade Cod
        /// </summary>
        public int Cod { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int Perfilcod { get; set; }

        public Usuario() { }

        /// <summary>
        /// Contrutor com parametros
        /// </summary>
        /// <param name="cod">É o código do Usuário</param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="email"></param>
        /// <param name="perfilcod"></param>
        public Usuario(int cod, string login, string senha, string nome, string sobrenome, string email, int perfilcod)
        {
            this.Cod = cod;
            this.Login = login;
            this.Senha = senha;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = email;
            this.Perfilcod = perfilcod;
        }
    }
}
