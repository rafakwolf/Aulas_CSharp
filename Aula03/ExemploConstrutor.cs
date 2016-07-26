namespace Aula03
{
    public class ExemploConstrutor
    {
        public int Codigo { private get; set;}
        public string Nome { private get; set; }

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