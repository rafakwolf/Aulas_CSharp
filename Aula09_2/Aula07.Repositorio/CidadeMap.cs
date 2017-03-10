using Aula07.Models;
using System.Data.Entity.ModelConfiguration;

namespace Aula07.Repositorio
{
    public class CidadeMap: EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            ToTable("Cidades","dbo");
            HasKey(t => t.IdCidade);
        } 
    }
}
