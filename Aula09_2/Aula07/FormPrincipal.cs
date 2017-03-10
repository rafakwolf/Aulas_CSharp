using Aula07.Models;
using Aula07.Repositorio;
using System;
using System.Windows.Forms;

namespace Aula07
{
    public partial class FormPrincipal : Form
    {
        private readonly CidadeRepositorio _repositorio;
        private Cidade _cidadeBusca;
        public FormPrincipal()
        {
            InitializeComponent();
            _repositorio = new CidadeRepositorio();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cidade = new Cidade(0,txtNome.Text, txtUf.Text);
            _repositorio.Inserir(cidade);
            MessageBox.Show(_repositorio.Status);

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_cidadeBusca == null)
            {
                MessageBox.Show("Busque um registo primeiro");
                return;
            }
            _cidadeBusca.Nome = txtNome.Text;
            _cidadeBusca.Uf = txtUf.Text;


            _repositorio.Alterar(_cidadeBusca);
            MessageBox.Show(_repositorio.Status);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (_cidadeBusca == null)
            {
                lbxCidades.Items.Add("Busque um registro primeiro");
                return;
            }

            _repositorio.Excluir(_cidadeBusca);
            MessageBox.Show(_repositorio.Status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codigo = 0;
            int.TryParse(txtCodigo.Text, out codigo);


            if (string.IsNullOrEmpty(txtCodigo.Text)||codigo == 0)
            {

                MessageBox.Show("Informe um codigo para buscar.");
                return;
            }

           

            lbxCidades.Items.Clear();

            _cidadeBusca = _repositorio.Buscar(codigo);

            if (_cidadeBusca == null)
            {
                MessageBox.Show("nenhum resultado encontrado");
            }else
            
            lbxCidades.Items.Add(_cidadeBusca.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbxCidades.Items.Clear();
            var cidades = _repositorio.Imprimir();

            foreach (var cidade in cidades)
                lbxCidades.Items.Add(cidade.ToString());

            lbxCidades.Items.Add(_repositorio.Status);

        }
    }
}
