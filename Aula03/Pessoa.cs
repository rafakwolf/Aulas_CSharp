using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("passei no construtor");
            Console.ReadKey();
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("nome da pessoa " + nome);
            Console.ReadKey();
        }

        private int RetornaIdadePessoa()
        {
            return 31;
        }

        public int RetornaIdadePessoa(int idade)
        {
            return idade;
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        protected void ValidaNome()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                throw new Exception("Nome deve ser informado."); 
            }
        }

        public static void ValidaNome(string nome)
        {
            if (nome.Length < 3)
                throw new Exception(
                    "Nome deve ter no mínimo 3 caracteres.");
        }

        public abstract void ValidaDocumento();
    }
}
