using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

            var p1 = new Pessoa();

            p1.Nome = "teste";
            p1.CPF = "123456";



            var p2 = new Pessoa();
            p2.Nome = "Teste";
            p2.CPF = "123456";


            if (p1.Equals(p2))
            {
                MessageBox.Show("é igual");
            }
            else
            {
                MessageBox.Show("é diferente");
            }

        }
    }
}
