using System;

namespace Aula04
{
    public class ClassTeste
    {
        public void InsereTeste(PessoaAbstrata p)
        {
            Console.WriteLine( p.GetType().Name );
        }
    }
}
