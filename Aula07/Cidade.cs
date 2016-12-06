namespace Aula07
{
    public class Cidade
    {
        public int Idcidade;
        public string Nome;
        public string Uf;

        public override bool Equals(object obj)
        {
            return ((Cidade)obj).Idcidade == this.Idcidade;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return " Codigo: " + Idcidade +
                    " Nome:   " + Nome +
                    " Uf:     " + Uf;
        }

        public Cidade(int idcidade, string nome, string uf)
        {
            this.Idcidade = idcidade;
            this.Nome = nome;
            this.Uf = uf;
        }
    }
}