using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07.Repositorio
{
    public class Conexao
    {

        public static string Status { get; set;}
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection con = null;

            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost\\SQLEXPRESS",
                InitialCatalog = "Aula7",
                UserID = "sa",
                Password = "12244877e",
                MultipleActiveResultSets = true

            };

            con = new SqlConnection(connectionStringBuilder.ConnectionString);
            try
            {
                con.Open();
                Status = "Conexção OK";


            }
            catch (Exception e)
            {
                Status = "Conexão Falhou " + e.Message;


            }
            return con;

        }
    }
}
