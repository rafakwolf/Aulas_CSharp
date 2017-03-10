using Aula07.Models;
using System.Data.Entity;

namespace Aula07.Repositorio
{
    public class Context : DbContext
    {
        public Context(): base("Aula09")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CidadeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
