using System;

namespace Aula04
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public virtual void ImprimeEstudo()
        {
            Console.WriteLine("Imprimindo estudo da classe pai");
        }

        public virtual void ImprimeTitulo()
        {
            Console.WriteLine("Imprimindo titulo da classe pai");
        }

        public override string ToString()
        {
            // Aqui esta a reescrita do método no formato que desejamos. 
            // Usaremos este método de agora em diante.

            return "Codigo= " + Codigo + "\nnome=" + Nome;
        }
    }
}
