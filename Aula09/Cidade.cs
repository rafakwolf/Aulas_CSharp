using System.ComponentModel.DataAnnotations;

namespace Aula07
{
    public class Cidade
    {
        [Key]
        public int Idcidade { get; set; }

        public string Nome { get; set; }
        public string Uf { get; set; }

        public override string ToString()
        {
            return " Codigo: " + Idcidade +
                    " Nome:   " + Nome +
                    " Uf:     " + Uf;
        }

        public Cidade()
        {
        }

        public Cidade(int idcidade, string nome, string uf)
        {
            this.Idcidade = idcidade;
            this.Nome = nome;
            this.Uf = uf;
        }
    }
}