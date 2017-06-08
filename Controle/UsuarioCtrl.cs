using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Controle
{
    public class UsuarioCtrl
    {
        public void InserirUsuario(Usuario _usuario)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                dao.InserirUsuario(_usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletarUsuario(int _IdUsuario)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                dao.DeletarUsuario(_IdUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarUsuario(Usuario _estado)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                dao.AtualizarUsuario(_estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                return dao.BuscarTodosUsuarios();
           }
           catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public Usuario BuscarUsuario(int _idUsuario)
        //{
        //    try
        //    {
        //        UsuarioDAO dao = new UsuarioDAO();

        //        return dao.BuscarUsuario(_idUsuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public bool ValidarUsuario(Usuario user)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                return dao.ValidarUsuario(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool verificaSenha(string Senha, string ConfSenha)
        {
            return (Senha != ConfSenha);
        }


    }
}
