using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Contexts;

namespace Projeto01.Infra.Data.SqlServer.Repositories;

public class EmpresaRepository : BaseRepository<Empresa, Guid>, IEmpresaRepository
{
    private readonly SqlServerContext _context;

    public EmpresaRepository(SqlServerContext context) : base(context)
    {
        _context = context;
    }
}