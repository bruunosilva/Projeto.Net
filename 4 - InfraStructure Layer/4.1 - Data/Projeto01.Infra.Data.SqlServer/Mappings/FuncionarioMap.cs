using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto01.Domain.Entities;

namespace Projeto01.Infra.Data.SqlServer.Mappings;

public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
{
    public void Configure(EntityTypeBuilder<Funcionario> builder)
    {
        builder.ToTable("FUNCIONARIO");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Id)
            .HasColumnName("IDFUNCIONARIO");

        builder.Property(f => f.Nome)
            .HasColumnName("NOME")
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(f => f.Cpf)
            .HasColumnName("CPF")
            .HasMaxLength(11)
            .IsRequired();

        builder.Property(f => f.Matricula)
            .HasColumnName("MATRICULA")
            .HasMaxLength(6)
            .IsRequired();

        builder.Property(f => f.DataAdmissao)
            .HasColumnName("DATAADMISSAO")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(f => f.EmpresaId)
            .HasColumnName("EMPRESAID")
            .IsRequired();

        #region Relacionamento

        builder.HasOne(f => f.Empresa)
            .WithMany(e => e.Funcionarios)
            .HasForeignKey(f => f.EmpresaId);

        #endregion
    }
}