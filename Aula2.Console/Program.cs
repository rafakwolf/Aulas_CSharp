namespace Aula02.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[6];
            var b = new int[6];

            var matrix = new int[6, 2];

            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Digite o " + (i + 1) + " valor no vetor 1.");

                a[i] = int.Parse(System.Console.ReadLine());
            }

            for (int i = 0; i < b.Length; i++)
            {
                System.Console.WriteLine("Digite o " + (i + 1) + " valor no vetor 2.");

                b[i] = int.Parse(System.Console.ReadLine());
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = a[i];
                    }
                    else if (j == 1)
                    {
                        matrix[i, j] = b[i];
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine("Linha " + i + " Coluna " + j + " = " + matrix[i, j]);
                }
            }

            System.Console.ReadKey();
        }
    }
}
