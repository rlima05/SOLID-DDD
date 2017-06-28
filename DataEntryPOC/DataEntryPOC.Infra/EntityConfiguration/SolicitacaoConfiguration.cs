using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataEntryPOC.Infra.EntityConfiguration
{
    public class SolicitacaoConfiguration : EntityTypeConfiguration<Solicitacao>
    {
        public SolicitacaoConfiguration()
        {
            HasKey(c => c.SolicitacaoId);

            Property(c => c.DataCadastro)
                .IsRequired();

            Property(c => c.DataUltimaAtualizacao)
                .IsRequired();

            HasRequired(c => c.TipoSolicitacao)
                .WithMany()
                .HasForeignKey(c => c.TipoSolicitacaoId);

            HasRequired(c => c.Status)
               .WithMany()
               .HasForeignKey(c => c.StatusId);

            HasRequired(c => c.Usuario)
               .WithMany()
               .HasForeignKey(c => c.UsuarioId);

            
        }
    }
}
