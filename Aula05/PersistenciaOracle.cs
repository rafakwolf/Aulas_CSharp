using System;
using System.Windows.Forms;

namespace Aula05
{
    public class PersistenciaOracle : IPersistencia
    {
        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Inserir()
        {
            MessageBox.Show("conectei em um banco oracle.");
        }
    }
}
