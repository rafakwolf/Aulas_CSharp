using System;

namespace Aula5.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var sair = false;

            var menu = "1 - cadastrar\n" +
                       "2 - alterar\n"+ 
                       "3 - excluir\n"+
                       "4 - imprimir\n" +
                       "5 - sair\n" +
                       "Digite uma opção";

            var persistencia = new PersistenciaCidade();
            Cidade cidade;
            int codigo;
            string nome;
            string estado;


            while (sair == false) // ou !sair 
            {

                Console.WriteLine(menu);

                var op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Escreva o códgo");
                        codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escreva o nome");
                        nome = Console.ReadLine();
                        Console.WriteLine("Escreva o estado");
                        estado = Console.ReadLine();

                        cidade = new Cidade();
                        cidade.Codigo = codigo;
                        cidade.Nome = nome;
                        cidade.Uf = estado;

                        persistencia.Salvar(cidade);

                        break;
                    case 2:
                        Console.WriteLine("Escreva o código");
                        codigo = int.Parse(Console.ReadLine());

                        cidade = new Cidade {Codigo = codigo};

                        if (persistencia.Consultar(cidade))
                        {
                            Console.WriteLine("Escreva um novo nome");
                            nome = Console.ReadLine();

                            Console.WriteLine("Escreva um novo estado");
                            estado = Console.ReadLine();

                            cidade.Nome = nome;
                            cidade.Uf = estado;

                            persistencia.Salvar(cidade);
                        }
                        else
                        {
                            Console.WriteLine("Cidade não encontrada.");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Escreva o código");
                        codigo = int.Parse(Console.ReadLine());
                        cidade = new Cidade { Codigo = codigo };

                        if (persistencia.Consultar(cidade))
                        {
                            persistencia.Excluir(cidade);
                        }
                        else
                        {
                            Console.WriteLine("Cidade não encontrada.");
                        }
                        break;    
                    case 4:
                        Console.WriteLine("===Lista de nomes===");

                        var cidades = persistencia.Listar();

                        foreach (var c in cidades)
                        {
                            Console.WriteLine(c.ToString());
                        }

                        Console.WriteLine("====================");

                        break;
                    case 5:
                        sair = true;
                        break;
                }

            }
        }
    }
}