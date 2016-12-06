using System.Windows.Forms;

namespace Aula03
{
    public class ExemploConstrutor
    {
        public int Codigo { get; set;}
        public string Nome { get; set; }

        public ExemploConstrutor(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public ExemploConstrutor()
        {
        }

        public int GetCodigo()
        {
            return this.Codigo;
        }

        public string GetNome()
        {
            return this.Nome;
        }
    }
}