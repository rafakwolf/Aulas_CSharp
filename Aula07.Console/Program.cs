using System;
using System.Data.SqlClient;

namespace Aula07.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                InitialCatalog = "Aula07",
                IntegratedSecurity = true
            };

            var conexao = new SqlConnection(connectionStringBuilder.ConnectionString);

            try
            {
                conexao.Open();
                System.Console.WriteLine("Conexão aberta");

                AdicionarPessoas(5,"teste5",40, conexao);

                ListarPessoas(conexao);

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.ReadKey();
            }
        }

        private static void ListarPessoas(SqlConnection conexao)
        {
            var command = new SqlCommand("select * from dbo.Pessoas", conexao);
            var reader = command.ExecuteReader();

            while (reader.Read())
                System.Console.WriteLine("Id: "+reader["Id"]+", Nome: "+reader["Nome"]+", Idade: "+reader["Idade"]);

            reader.Close();
        }

        private static void AdicionarPessoas(int id, string nome, int idade, SqlConnection conexao)
        {
            var command = new SqlCommand(@"insert into dbo.Pessoas(Id, Nome, Idade) 
                                           values(@Id, @Nome, @Idade)", conexao);
            command.Parameters.AddWithValue("Id", id);
            command.Parameters.AddWithValue("Nome", nome);
            command.Parameters.AddWithValue("Idade", idade);

            command.ExecuteNonQuery();

            command.Dispose();
        }
    }
}
