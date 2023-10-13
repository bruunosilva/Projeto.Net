using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using MediatR;

namespace Projeto01.Application.Commands.Empresas;

public class EmpresaCreateCommand : IRequest
{
    public string NomeFantasia { get; set; }
    public string RazaoSocial { get; set; }
    public string Cnpj { get; set; }
}