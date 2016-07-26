using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Aula07
{
    public class CidadeRepositorio
    {
        private string _query;
        private readonly SqlConnection _con = Conexao.GetConnection();
        private static readonly List<Cidade> Cidades = new List<Cidade>();

        private int _idcidade;
        private string _nome;
        private string _uf;

        public string Status = "";

        public void Inserir(Cidade c)
        {
            _query = "insert into cidades(nome,uf) " +
                "values(@Nome, @Uf)";
            try
            {
                var command = _con.CreateCommand();
                command.CommandText = _query;
                command.Parameters.AddWithValue("Nome", c.Nome);
                command.Parameters.AddWithValue("Uf", c.Uf);
                command.ExecuteNonQuery();

                Status = "Registro incluido com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel incluir o registro erro: " +
                e.Message + " sql executado: " + _query;
            }
        }

        public void Alterar(Cidade c)
        {
            _query = "update cidades set nome=@Nome, uf=@Uf" +
                " where idcidade = @IdCidade";
            try
            {
                var command = _con.CreateCommand();
                command.CommandText = _query;
                command.Parameters.AddWithValue("Nome", c.Nome);
                command.Parameters.AddWithValue("Uf", c.Uf);
                command.Parameters.AddWithValue("IdCidade", c.Idcidade);

                command.ExecuteNonQuery();

                Status = "Registro alterado com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel alterar o registro erro: " +
                e.Message + " sql executado: " + _query;
            }
        }

        public void Excluir(Cidade c)
        {
            _query = "delete from cidades where idcidade = " + c.Idcidade;
            try
            {
                var command = _con.CreateCommand();
                command.CommandText = _query;
                command.Parameters.AddWithValue("IdCidade", c.Idcidade);

                command.ExecuteNonQuery();
                Status = "Cidade " + c.Nome + " Excluido com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel excluir o registro erro: " +
                e.Message + " sql executado: " + _query;
            }
        }

        public Cidade Buscar(int id)
        {
            _query = "select * from cidades where idcidade = " + id;
            try
            {
                var command = _con.CreateCommand();
                command.CommandText = _query;
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    _idcidade = int.Parse(reader["idcidade"].ToString());
                    _nome = reader["nome"].ToString();
                    _uf = reader["uf"].ToString();
                }
                else
                {
                    _idcidade = 0;
                    _nome = null;
                    _uf = null;
                }
            }
            catch (Exception e)
            {
                Status = e.Message;
            }

            if (_idcidade <= 0) return null;

            Status = "Cidade: " + _nome + " encontrada com sucesso!";
            var cidadeRetorno = new Cidade(_idcidade, _nome, _uf);
            return cidadeRetorno;
        }
        public List<Cidade> Imprimir()
        {
            Cidades.Clear();

            _query = "select * from cidades ";
            try
            {
                var command = _con.CreateCommand();
                command.CommandText = _query;
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    _idcidade = int.Parse(reader["idcidade"].ToString());
                    _nome = reader["nome"].ToString();
                    _uf = reader["uf"].ToString();

                    var cidade = new Cidade(_idcidade, _nome, _uf);
                    Cidades.Add(cidade);
                }
            }
            catch (Exception e)
            {
                Status = e.Message;
            }
            return Cidades;
        }
    }
}