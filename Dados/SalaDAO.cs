using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dados
{
    class SalaDAO
    {

        public List<Sala> BuscarTodasSalas()
        {
            List<Sala> listaSalas = new List<Sala>();

            try
            {
                string SQL = String.Format("SELECT * FROM Sala");

                SqlDataReader data = DB.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Sala item = new Sala();

                    item.Cod = data.GetInt32(0);
                    item.Numero = data.GetString(1);
                    item.Descricao = data.GetString(2);
                    




                    listaSalas.Add(item);
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaSalas;
        }
        
       
      
       
        public void InserirSala(Sala sala)
        {
            try
            {
                string SQL = String.Format("INSERT INTO Sala ( numero, descricao, andar_cod) VALUES ('{0}', '{1}', '{3}')", sala.Numero, sala.Descricao, sala);
                DB.ExecutarSQLAlter(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
