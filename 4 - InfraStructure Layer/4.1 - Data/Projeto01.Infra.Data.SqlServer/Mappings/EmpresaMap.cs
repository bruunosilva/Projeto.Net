using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto01.Domain.Entities;

namespace Projeto01.Infra.Data.SqlServer.Mappings;

public class EmpresaMap : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("Empresa");
        
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName("IDEMPRESA");

        builder.Property(e => e.NomeFantasia)
            .HasColumnName("NOMEFANTASIA")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(e => e.RazaoSocial)
            .HasColumnName("RAZAOSOCIAL")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(e => e.Cnpj)
            .HasColumnName("CNPJ")
            .HasMaxLength(20)
            .IsRequired();
    }
}