using MediatR;

namespace Projeto01.Application.Commands.Funcionarios;

public class FuncionarioCreateCommand : IRequest
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Matricula { get; set; }
    public DateTime DataAdmissao { get; set; }
    public Guid EmpresaId { get; set; }
}