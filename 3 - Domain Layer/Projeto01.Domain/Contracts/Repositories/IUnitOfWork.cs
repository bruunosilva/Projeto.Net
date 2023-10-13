namespace Projeto01.Domain.Contracts.Repositories;

public interface IUnitOfWork : IDisposable
{
    #region Transaction Management

    void BeginTransaction();
    void Commit();
    void Rollback();

    #endregion

    #region Repositories

    IEmpresaRepository EmpresaRepository { get; }
    IFuncionarioRepository FuncionarioRepository { get; }

    #endregion
    
    
}