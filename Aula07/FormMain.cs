using System.Windows.Forms;

namespace Aula07
{
    public partial class FormMain : Form
    {
        private readonly CidadeRepositorio _repositorio;

        private Cidade _cidadeBusca;

        public FormMain()
        {
            InitializeComponent();
            _repositorio = new CidadeRepositorio();
        }

        private void btnInserir_Click(object sender, System.EventArgs e)
        {
            var cidade = new Cidade(0, txtNome.Text, txtUf.Text);
            _repositorio.Inserir(cidade);
            lbxCidades.Items.Add(_repositorio.Status);
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            if (_cidadeBusca == null)
            {
                lbxCidades.Items.Add("Buscque um registro primeiro");
                return;
            }

            _cidadeBusca.Nome = txtNome.Text;
            _cidadeBusca.Uf = txtUf.Text;

            _repositorio.Alterar(_cidadeBusca);
            lbxCidades.Items.Add(_repositorio.Status);
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (_cidadeBusca == null)
            {
                lbxCidades.Items.Add("Buscque um registro primeiro");
                return;
            }

            _repositorio.Excluir(_cidadeBusca);
            lbxCidades.Items.Add(_repositorio.Status);
        }

        private void btnBuscarPorId_Click(object sender, System.EventArgs e)
        {
            _cidadeBusca = _repositorio.Buscar(int.Parse(txtId.Text));
            lbxCidades.Items.Add(_repositorio.Status);
        }

        private void btnListarTodos_Click(object sender, System.EventArgs e)
        {
            var cidades = _repositorio.Imprimir();

            foreach (var cidade in cidades)
                lbxCidades.Items.Add(cidade.ToString());
        }
    }
}
