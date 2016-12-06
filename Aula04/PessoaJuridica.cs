using System.Windows.Forms;

namespace Aula04
{
    public class PessoaJuridica: Pessoa
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void ImprimeEstudo()
        {
            MessageBox.Show("Uma pessoa juridica não pode estudar.");
        }
    }
}
