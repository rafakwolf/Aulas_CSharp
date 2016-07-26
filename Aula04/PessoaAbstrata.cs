namespace Aula04
{
    public abstract class PessoaAbstrata
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public abstract void ImprimeNome(); 
    }
}
