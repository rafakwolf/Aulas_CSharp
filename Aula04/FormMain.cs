using System;
using System.Windows.Forms;

namespace Aula04
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTestaHeranca_Click(object sender, EventArgs e)
        {
            AlunoFaculdade af = new AlunoFaculdade();
            AlunoMestrado am = new AlunoMestrado();

            af.ImprimeEstudo();
            am.ImprimeEstudo();
        }

        private void btnTesteAbstracao_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            PessoaAbstrata p = new Aluno();

            //((Aluno)p).

            a.Codigo = 1;
            a.Nome = "Aluno normal";

            p.Codigo = 2;
            p.Nome = "Aluno Polimorfismo";

            Console.WriteLine("-----------Aluno normal -------------------------");
            Console.WriteLine(a.Codigo);
            Console.WriteLine(a.Nome);

            Console.WriteLine("-----------Aluno Polimorfismo--------------------");
            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Nome + "\n");

            Console.WriteLine("-----------Imprimindo metodos abstratos----------");
            a.ImprimeNome();
            p.ImprimeNome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new ClassTeste();

            PessoaAbstrata aluno = new Aluno();

            t.InsereTeste(aluno);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new PessoaFisica();

            p.Nome = "nome da pessoa";
            p.Codigo = 1;

            MessageBox.Show( p.ToString() );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new PessoaJuridica();
            p.ImprimeEstudo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PessoaAbstrata aluno = new Aluno();
            aluno.ImprimeNome();
        }
    }
}
