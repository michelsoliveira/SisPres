using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Dados;

namespace Dados
{
    public class EventoDAO
    {
        public void InserirEventoUnico(Evento evento)
        {
            try
            {
                string SQL = String.Format("INSERT INTO Evento ( titulo, descricao, qtd_horas, local_cod, data_ini, hora_ini, data_fim, hora_fim) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}')", evento.Titulo, evento.Descricao, evento.Qtdhoras, evento.Local_cod, evento.Data_ini, evento.Hora_ini, evento.Data_fim, evento.Hora_fim);
                DB.ExecutarSQLAlter(SQL);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InserirEventoMultiplo(Evento evento)
        {
            try
            {
                string SQL = String.Format("INSERT INTO Evento ( evento_cod, titulo, descricao, qtd_horas, local_cod, data_ini, hora_ini, data_fim, hora_fim) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}','{6}','{7}','{8}')", evento.Evento_cod, evento.Titulo, evento.Descricao, evento.Qtdhoras, evento.Local_cod, evento.Data_ini, evento.Hora_ini, evento.Data_fim, evento.Hora_fim);
                DB.ExecutarSQLAlter(SQL);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Evento> BuscarTodosEventos()
        {
            List<Evento> listaEventos = new List<Evento>();

            try
            {
                string SQL = String.Format("SELECT * FROM Evento");

                SqlDataReader data = DB.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Evento item = new Evento();

                    item.Cod = data.GetInt32(0);
                    //item.Evento_cod = data.GetInt32(1); -- verificar como trazer null
                    item.Titulo = data.GetString(2);
                    item.Descricao = data.GetString(3);
                    item.Qtdhoras = data.GetString(4);
                    item.Local_cod = data.GetInt32(5);


                    listaEventos.Add(item);
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaEventos;
        }

        

    }
}
