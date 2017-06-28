using System.Data.Entity;
using DataEntryPOC.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace DataEntryPOC.Infra.Contexto
{
    public class DataEntryContext : DbContext
    {
        public DataEntryContext()
            : base("DataEntry")
        {

        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<Solicitacao> Solicitacao { get; set; }
        public DbSet<TipoSolicitacao> TipoSolicitacao { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
              .Where(p => p.Name == p.ReflectedType.Name + "Id")
              .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

        }
    }
}

