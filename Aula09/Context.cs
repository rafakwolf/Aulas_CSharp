using System.Data.Entity;

namespace Aula07
{
    public class Context: DbContext
    {
        public Context(): base("Aula7Connection")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }
    }
}
