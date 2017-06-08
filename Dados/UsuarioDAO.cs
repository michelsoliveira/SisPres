using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dados
{
    public class UsuarioDAO
    {
        public bool ValidarUsuario(Usuario user)
        {
            try
            {   
                string SQL = String.Format("SELECT * FROM Usuario WHERE usuario = '{0}' AND senha = '{1}'", user.Login, user.Senha);

                SqlDataReader data = DB.ExecutarSelect(SQL);

                if (data.Read())
                {
                    user.Cod = data.GetInt32(0);
                    user.Login = data.GetString(2);
                    user.Senha = data.GetString(3);
                    

                    data.Close();
                    DB.FecharConexao();

                    return true;
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public void InserirUsuario(Usuario _usuario)
        {
            try
            {
                string SQL = String.Format("INSERT INTO Usuario ( perfil_cod, nome, sobrenome, email, usuario, senha) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}')", _usuario.Perfilcod, _usuario.Nome, _usuario.Sobrenome, _usuario.Email, _usuario.Login, _usuario.Senha);
                DB.ExecutarSQLAlter(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeletarUsuario(int CodUsuario)
        {
            try
            {
                string SQL = String.Format("DELETE FROM Usuario WHERE cod = {0}", CodUsuario);

                DB.ExecutarSQLAlter(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizarUsuario(Usuario _usuario)
        {
            try
            {
                string SQL = String.Format("UPDATE Usuario SET perfil_cod = '{1}', nome = '{2}', sobrenome = '{3}', email = '{4}', usuario = '{5}', senha = '{6}' WHERE cod = '{0}'", _usuario.Cod,_usuario.Perfilcod, _usuario.Nome, _usuario.Sobrenome, _usuario.Email, _usuario.Login, _usuario.Senha);

                DB.ExecutarSQLAlter(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                string SQL = String.Format("SELECT * FROM usuario");

                SqlDataReader data = DB.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Usuario item = new Usuario();

                    item.Cod = data.GetInt32(0);
                    item.Perfilcod = data.GetInt32(1);
                    item.Nome = data.GetString(2);
                    item.Sobrenome = data.GetString(3);
                    item.Email = data.GetString(4);
                    item.Login = data.GetString(5);
                    item.Senha = data.GetString(6);
                    

                    listaUsuarios.Add(item);
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaUsuarios;
        }

        /*public Usuario BuscarUsuario(int _idUsuario)
        {
            try
            {
                string SQL = String.Format("SELECT * FROM usuario WHERE id = {0}", _idUsuario);

                SqlDataReader data = DB.ExecutarSelect(SQL);

                if (data.Read())
                {
                    Usuario item = new Usuario();

                    item.Cod = data.GetInt32(0);
                    item.Login = data.GetString(1);
                    item.Senha = data.GetString(2);
                    item. = data.GetInt32(3);

                    return item;
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return null;
        }*/
    
    
    }
}
