using Projeto01.Domain.Contracts.Repositories;
using Projeto01.Domain.Contracts.Services;
using Projeto01.Domain.Entities;

namespace Projeto01.Domain.Services;

public class FuncionarioDomainService : BaseDomainServices<Funcionario, Guid>, IFuncionarioDomainService
{
    private readonly IUnitOfWork _unitOfWork;

    public FuncionarioDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.FuncionarioRepository)
    {
        _unitOfWork = unitOfWork;
    }
}