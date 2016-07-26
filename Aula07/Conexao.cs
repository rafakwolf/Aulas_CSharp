using System;
using System.Data.SqlClient;

namespace Aula07
{
    public class Conexao
    {
        public static string Status = "";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;

            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                InitialCatalog = "Aula07",
                IntegratedSecurity = true
            };

            con = new SqlConnection(connectionStringBuilder.ConnectionString);

            try
            {
                con.Open();
                Status = "Conexão ok";
            }
            catch (Exception e)
            {
                Status = e.Message;
            }
            return con;
        }
    }
}