using System;
using System.Windows.Forms;

namespace Aula04
{
    public class PessoaFisica: Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }

        public override void ImprimeEstudo()
        {
            MessageBox.Show("Estudando C#");
        }

    }
}
