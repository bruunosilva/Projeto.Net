using MediatR;

namespace Projeto01.Application.Commands.Empresas;

public class EmpresaUpdateCommand : IRequest
{
    public Guid Id { get; set; }
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    public string Cnpj { get; set; }
}