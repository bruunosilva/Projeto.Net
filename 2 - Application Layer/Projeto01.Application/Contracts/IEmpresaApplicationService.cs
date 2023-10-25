using Projeto01.Application.Commands.Empresas;
using Projeto01.Domain.Entities;

namespace Projeto01.Application.Contracts;

public interface IEmpresaApplicationService
{
    Task Create(EmpresaCreateCommand command);
    Task Update(EmpresaUpdateCommand command);
    Task Delete(EmpresaDeleteCommand command);
}
//3:12