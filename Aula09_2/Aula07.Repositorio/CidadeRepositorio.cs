using Aula07.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Aula07.Repositorio
{
    public class CidadeRepositorio
    {
        private Context ctx = new Context();

        public string Status = "";

        public void Inserir(Cidade c)
        {
            Status = "";
            try
            {
                ctx.Cidades.Add(c);
                ctx.SaveChanges();

                Status = "Registro incluido com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possível incluir o registro erro: " +
                e.Message;
            }
        }

        public void Alterar(Cidade c)
        {
            Status = "";
            try
            {
                var cidade = ctx.Cidades.Find(c.IdCidade);

                cidade.Nome = c.Nome;
                cidade.Uf = c.Uf;

                ctx.Entry(cidade).State = EntityState.Modified;
                ctx.SaveChanges();

                Status = "Registro alterado com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel alterar o registro erro: " +
                e.Message;
            }
        }

        public void Excluir(Cidade c)
        {
            Status = "";
            try
            {
                ctx.Cidades.Remove(c);
                ctx.SaveChanges();

                Status = "Cidade " + c.Nome + " Excluido com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel excluir o registro erro: " +
                e.Message;
            }
        }

        public Cidade Buscar(int id)
        {
            Cidade cidadeRetorno = null;
            Status = "";
            try
            {
                cidadeRetorno = ctx.Cidades.Find(id);
            }
            catch (Exception e)
            {
                Status = e.Message;
            }

            if (cidadeRetorno != null)
            {
                Status = "Cidade: " + cidadeRetorno.Nome + " encontrada com sucesso!";
                return cidadeRetorno;
            }

            return null;
            
        }

        public List<Cidade> Imprimir()
        {
            List<Cidade> Cidades = null;

            Status = "";

            try
            {
                Cidades = ctx.Cidades.ToList();

            }
            catch (Exception e)
            {
                Status = e.Message;
            }
            return Cidades;
        }

    }
}
