using System;

namespace Aula02.Exercicio1a6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sair = false;

            var menu = "1 - cadastrar\n" +
                       "2 - imprimir\n" +
                       "3 - sair\n" +
                       "Digite uma opção";

            var nomes = new string[3];


            while (sair == false) // ou !sair 
            {
                Console.WriteLine(menu);

                var op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Escreva o nome " + (i + 1));
                            nomes[i] = Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("===Lista de nomes===");

                        for (int i = 0; i < nomes.Length; i++)
                            Console.WriteLine("Nome : " + nomes[i]);

                        Console.WriteLine("====================");

                        break;
                    case 3:
                        sair = true;
                        break;
                }

            }

        }
    }
}
