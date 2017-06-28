
using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace DataEntryPOC.Infra.EntityConfiguration
{
    public class PaisConfiguration : EntityTypeConfiguration<Pais>
    {
        public PaisConfiguration()
        {
            HasKey(c => c.PaisId);

            Property(c => c.Sigla)
                .IsRequired()
                .HasMaxLength(2);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
