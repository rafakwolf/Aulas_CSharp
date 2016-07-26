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
        private IQueryable<string> _minhaLista = new List<string>();


        public Form1()
        {
            InitializeComponent();

            var listaFiltrada = _minhaLista.FirstOrDefault(x => x.Contains("a"));


        }
    }
}
