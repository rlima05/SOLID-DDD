

using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace DataEntryPOC.Infra.EntityConfiguration
{
     public class TipoSolicitacaoConfiguration : EntityTypeConfiguration<TipoSolicitacao>
    {
         public TipoSolicitacaoConfiguration()
         {
             HasKey(c => c.TipoSolicitacaoId);

             Property(c => c.Descricao)
                 .IsRequired()
                 .HasMaxLength(150);
         }
    }
}
