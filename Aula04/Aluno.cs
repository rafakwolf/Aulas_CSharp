using System;

namespace Aula04
{
    public class Aluno : PessoaAbstrata
    {
        public override void ImprimeNome()
        {
            Console.WriteLine("Nome: "+this.Nome);
        }


        public void teste()
        {
            Console.WriteLine("aaaaaaaaaaaaaaaaaaa");
        }
    }
}
