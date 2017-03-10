namespace Aula07.Models
{
    public class Cidade
    {
        public int IdCidade { get;  set; }
        public string Nome { get; set; }
        public string Uf { get; set; }

        public Cidade()
        {
        }

        public override string ToString()
        {
            var c = "Codigo: " + this.IdCidade +
                    ",Nome: " + this.Nome +
                    ",Uf: " + this.Uf;

            return c;
        }
        public Cidade(int idcidade, string nome, string uf)
        {
            this.IdCidade = idcidade;
            this.Nome = nome;
            this.Uf = uf;

               
        }

    }
}
