using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace DataEntryPOC.Infra.EntityConfiguration
{
    public class StatusConfiguration :  EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            HasKey(c => c.StatusId);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
