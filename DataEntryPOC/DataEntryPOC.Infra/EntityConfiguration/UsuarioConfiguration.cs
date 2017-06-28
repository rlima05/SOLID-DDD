
using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace DataEntryPOC.Infra.EntityConfiguration
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.UsuarioId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
