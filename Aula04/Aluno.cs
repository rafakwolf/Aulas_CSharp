using System.Windows.Forms;

namespace Aula04
{
    public class Aluno : PessoaAbstrata
    {
        public override void ImprimeNome()
        {
            MessageBox.Show("Nome: " + this.Nome);
        }
    }
}
