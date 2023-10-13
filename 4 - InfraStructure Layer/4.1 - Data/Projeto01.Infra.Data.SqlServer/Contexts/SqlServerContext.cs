using Microsoft.EntityFrameworkCore;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Mappings;

namespace Projeto01.Infra.Data.SqlServer.Contexts;

public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options)
        : base(options)
    {
        
    }

    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region FluentMappings

        modelBuilder.ApplyConfiguration(new EmpresaMap());
        modelBuilder.ApplyConfiguration(new FuncionarioMap());

        #endregion

        #region Indexs

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasIndex(e => e.Cnpj)
                .IsUnique();
        });
        
        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasIndex(e => e.Cpf)
                .IsUnique();
            entity.HasIndex(e => e.Matricula)
                .IsUnique();
        });

        #endregion
        //3:04:41
    }
}