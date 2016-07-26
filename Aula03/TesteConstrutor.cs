namespace Aula03
{
    public class TesteConstrutor
    {
        public void InicializandoClasse()
        {
            // Sem passagem de parâmetros
            var exemploConstutor = new ExemploConstrutor();
            exemploConstutor.Codigo = 10;
            exemploConstutor.Nome = "Aula C# 03";

            // Passando parâmetros
            var exemploConstrutor2 = new ExemploConstrutor(10, "Aula C# 03");
        }
    }
}