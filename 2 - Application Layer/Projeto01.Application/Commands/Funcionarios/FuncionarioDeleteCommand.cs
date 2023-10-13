using MediatR;

namespace Projeto01.Application.Commands.Funcionarios;

public class FuncionarioDeleteCommand : IRequest
{
    public Guid Id { get; set; }
}