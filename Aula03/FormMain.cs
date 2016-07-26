using System;
using System.Windows.Forms;

namespace Aula03
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int itemNoArray = 0;
        ExemploConstrutor[] arrayObjetos = new ExemploConstrutor[5];

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var item = new ExemploConstrutor();
            item.Codigo = int.Parse(txtCodigo.Text);
            item.Nome = txtNome.Text;

            if (itemNoArray < 5)
            {
                arrayObjetos[itemNoArray] = item;
                itemNoArray++;

                txtCodigo.Clear();
                txtNome.Clear();
                txtCodigo.Focus();
            }
            else
                MessageBox.Show("Já temos 5 items no array.");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayObjetos.Length; i++)
            {
                if (arrayObjetos[i] != null)
                    lbxItems.Items.Add(arrayObjetos[i].GetCodigo().ToString() + 
                        " - " + arrayObjetos[i].GetNome());
            }
        }
    }
}
