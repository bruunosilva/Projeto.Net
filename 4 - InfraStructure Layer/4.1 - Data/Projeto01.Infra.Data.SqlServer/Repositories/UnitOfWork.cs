using Microsoft.EntityFrameworkCore.Storage;
using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Infra.Data.SqlServer.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly SqlServerContext _context;

    private IDbContextTransaction _transaction;

    public UnitOfWork(SqlServerContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public void BeginTransaction()
    {
        _transaction = _context.Database.BeginTransaction();
    }

    public void Commit()
    {
        _transaction.Commit();
    }

    public void Rollback()
    {
        _transaction.Rollback();
    }

    public IEmpresaRepository EmpresaRepository => new EmpresaRepository(_context);
    public IFuncionarioRepository FuncionarioRepository => new FuncionarioRepository(_context);
}