using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Infra.Data.SqlServer.Repositories;

public class FuncionarioRepository : BaseRepository<Funcionario, Guid>, IFuncionarioRepository
{
    private readonly SqlServerContext _context;

    public FuncionarioRepository(SqlServerContext context) : base(context)
    {
        _context = context;
    }
}