using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dados
{
    class AndarDAO
    {
        public void InserirAndar(Andar andar)
        {
            try
            {
                string SQL = String.Format("INSERT INTO Bloco (numero,decricao) VALUES ('{1}','{2}')", andar.Numero, andar.Descricao );
                DB.ExecutarSQLAlter(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Andar> BuscarTodosAndares()
        {
            List<Andar> listaAndares = new List<Andar();

            try
            {
                string SQL = String.Format("SELECT * FROM Andar");

                SqlDataReader data = DB.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Andar item = new Andar();

                    item.Cod = data.GetInt32(0);
                    item.Numero = data.GetString(1);
                    item.Descricao = data.GetString(2);


                    listaAndares.Add(item);
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaAndares;
        }
    
    
    
    }
}
