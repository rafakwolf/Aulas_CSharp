using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    static class Program
    {
        static void Main()
        {
            var p = new PessoaFisica();

            //p.Nome = "jose";

            Pessoa.ValidaNome("ra");
   

            //Console.WriteLine("Idade é " + p.Nome);
        }
    }
}
