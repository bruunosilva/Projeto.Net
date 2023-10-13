using MediatR;

namespace Projeto01.Application.Commands.Empresas;

public class EmpresaDeleteCommand : IRequest
{
    public Guid Id { get; set; }
}
