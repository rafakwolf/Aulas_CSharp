using System.Collections;

namespace Aula5.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Digite a primeira string:");
            //var s1 = System.Console.ReadLine();

            //System.Console.WriteLine("Digite a segunda string:");
            //var s2 = System.Console.ReadLine();

            //if (s1.Equals(s2))
            //{
            //    System.Console.WriteLine("Valores informados são iguais.");
            //}
            //else
            //{
            //    System.Console.WriteLine("Valores informados são diferentes.");
            //}

            //System.Console.ReadKey();

            TesteEquals.Teste();
        }

        public class Pessoa
        {
            private string nome;
            private int idade;


            public override string ToString()
            {
                return " Nome: " + nome + " Idade: " + idade;
            }

            public Pessoa(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }

            public override bool Equals(object obj)
            {
                return ((Pessoa)obj).idade == this.idade;
            }
        }

        public class TesteEquals
        {
            public static void Teste()
            {
                var dados = new ArrayList();

                Pessoa p1 = new Pessoa("Pessoa 01", 20);
                Pessoa p2 = new Pessoa("Pessoa 02", 25);
                Pessoa p3 = new Pessoa("Pessoa 03", 30);
                Pessoa p4 = new Pessoa("", 30);

                Pessoa p5;

                dados.Add(p1);
                dados.Add(p2);
                dados.Add(p3);

                //dados.Remove(p4);

                var indice = dados.IndexOf(p3);
                p5 = (Pessoa)dados.GetRange(indice,1)[0];

                System.Console.WriteLine(indice);
                System.Console.WriteLine(p5);

                int total = dados.Count;
                System.Console.WriteLine(total);

                System.Console.ReadKey();
            }

        }
    }
}