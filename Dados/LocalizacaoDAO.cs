using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Dados
{
    public class LocalizacaoDAO
    {

        public List<Localizacao> BuscarTodasLocalizacoes()
        {
            List<Localizacao> listaLocalizacoes = new List<Localizacao>();

            try
            {
                string SQL = String.Format("SELECT * FROM Localizacao, Sala WHERE Localizacao.sala_cod = Sala.cod ");

                SqlDataReader data = DB.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Localizacao item = new Localizacao();

                    item.Cod = data.GetInt32(0);
                    item.Sala_cod = data.GetInt32(1);
                    item.Andar = data.GetString(2);
                    item.Bloco = data.GetString(3);
                    //item.Numero = data.GetInt32(

                    


                    listaLocalizacoes.Add(item);
                }

                data.Close();
                DB.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaLocalizacoes;
        }
    
    }
}
