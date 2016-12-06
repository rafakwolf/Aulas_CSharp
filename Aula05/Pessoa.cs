using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05
{
    public class Pessoa
    {
        public Pessoa()
        {
            Contatos = new List<string>();
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public IEnumerable<string> Contatos { get; set; }

        public string CPF { get; set; }


        public override bool Equals(object obj)
        {

            return ((Pessoa)obj).CPF == this.CPF;
        }
    }
}
