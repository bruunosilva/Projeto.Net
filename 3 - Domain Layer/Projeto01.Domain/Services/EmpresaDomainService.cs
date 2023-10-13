using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Contracts.Services;
using Projeto01.Domain.Entities;

namespace Projeto01.Domain.Services;

public class EmpresaDomainService : BaseDomainServices<Empresa, Guid>, IEmpresaDomainService
{
    private readonly IUnitOfWork _unitOfWork;

    public EmpresaDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.EmpresaRepository)
    {
        _unitOfWork = unitOfWork;
    }
}