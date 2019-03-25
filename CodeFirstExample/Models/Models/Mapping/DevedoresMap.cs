using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.Models.Mapping
{
    //Fluent API 
    //The Fluent API can be used to configure an entity to map it with database table(s), default schema, etc.

    public class DevedoresMap : EntityTypeConfiguration<Devedores>
    {
        public DevedoresMap()
        {
            // Primary Key
            HasKey(t => t.Contrato);

            // Table & Column Mappings

            ToTable("CAD_DEVF");

            Property(t => t.Contrato)
                .HasColumnName("CONTRATO_FIN")
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Cpf).HasColumnName("CPF_DEV")
                .IsRequired()
                .HasMaxLength(14);

            Property(t => t.CodigoCliente).HasColumnName("COD_CLI")
                .IsOptional();

            Property(t => t.CodigoCarteira).HasColumnName("COD_CAR")
                .IsOptional();
        }
    }
}
