using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dados
{
    
    
    
    public static class DB
    {
        //private string userdb = "sa";
        //private string passdb = "lasalle2016";
        //private string 
        
        static SqlConnection conn = new SqlConnection();
        //static string Conn = @"Data Source=TIC07UNI\SQLEXPRESS;Initial Catalog=bd_presenca;User ID=sa;Password=lasalle2016";
        static string Conn = @"Data Source=LB316UNI\SQLEXPRESS;Initial Catalog=bd_presenca;User ID=sa;Password=lasalle2016";
        //static string Conn = @"Server=tcp:bdpres.database.windows.net,1433;Data Source=bdpres.database.windows.net;Initial Catalog=bd_presenca;Persist Security Info=False;User ID=micheloliveira;Password=Mso0111012;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static void AbrirConexao()
        {
            try
            {
                conn.ConnectionString = Conn;

                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                }
                else
                {
                    conn = new SqlConnection();
                    conn.Open();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void FecharConexao()
        {
            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
        public static SqlDataReader ExecutarSelect(string _sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand comando = new SqlCommand(_sql, conn);

                SqlDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                DB.FecharConexao();
                throw new Exception(ex.Message);
            }
            /*finally
            {
                DB.FecharConexao();
            }*/

        }

        public static int ExecutarSQLAlter(string _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCommand comando = new SqlCommand(_SQL, conn);

                linhasAfetadas = comando.ExecuteNonQuery();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DB.FecharConexao();
            }
        }


    }
}
