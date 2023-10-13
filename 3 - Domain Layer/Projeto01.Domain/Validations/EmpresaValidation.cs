using FluentValidation;
using Projeto01.Domain.Entities;
using Projeto01.Validations;

namespace Projeto01.Domain.Validations;

public class EmpresaValidation : AbstractValidator<Empresa>
{
    public EmpresaValidation()
    {
        RuleFor(e => e.Id)
            .NotEmpty().WithMessage("Id da empresa é obrigatório.");

        RuleFor(e => e.NomeFantasia)
            .NotEmpty().WithMessage("Nome fantasia é obrigatório.")
            .Length(6, 150).WithMessage("Nome fantasia deve ter de 6 a 150 caracteres.");
        
        RuleFor(e => e.RazaoSocial)
            .NotEmpty().WithMessage("Razão Social é obrigatório.")
            .Length(6, 150).WithMessage("Razão Social deve ter de 6 a 150 caracteres.");

        RuleFor(e => e.Cnpj)
            .NotEmpty().WithMessage("Cnpj é obrigatório.")
            .Length(20).WithMessage("Cnpj deve ter 20 caracteres.")
            .Must(CnpjValidation.IsValid).WithMessage("CNPJ inválido.");
    }
}