using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Aula07
{
    public class CidadeRepositorio
    {
        private Context ctx = new Context();
        public string Status = "";

        public void Inserir(Cidade c)
        {
            try
            {
                ctx.Cidades.Add(c);
                ctx.SaveChanges();

                Status = "Registro incluido com sucesso!";
            }
            catch (Exception e)
            {
                Status = "Não foi possivel incluir o registro erro: " +
                e.Message;
            }
        }

        public void Alterar(Cidade c)
        {
            try
            {
                ctx.Entry(c).State = EntityState.Modified;
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
            try
            {
                ctx.Cidades.Remove(c);
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
            try
            {
                var cidades = ctx.Cidades.ToList();
                return cidades;
            }
            catch (Exception e)
            {
                Status = e.Message;
            }
            return null;
        }
    }
}