using FluentValidation;
using Projeto01.Domain.Entities;
using Projeto01.Validations;

namespace Projeto01.Domain.Validations;

public class FuncionarioValidation : AbstractValidator<Funcionario>
{
    public FuncionarioValidation()
    {
        RuleFor(f => f.Id)
            .NotEmpty().WithMessage("Id do funcionário é obrigatório.");

        RuleFor(f => f.Nome)
            .NotEmpty().WithMessage("Nome do funcionário é obrigatório")
            .Length(6, 150).WithMessage("Nome deve ter de 6 a 150 caracteres.");
        
        RuleFor(f => f.Cpf)
            .NotEmpty().WithMessage("CPF é obrigatório")
            .Length(11).WithMessage("CPF deve ter 11 caracteres.");

        RuleFor(f => f.Matricula)
            .NotEmpty().WithMessage("Matrícula é obrigatório")
            .Length(6).WithMessage("CPF deve ter 6 caracteres.")
            .Must(CpfValidation.IsValid).WithMessage("CPF inválido.");

        RuleFor(f => f.DataAdmissao)
            .NotEmpty().WithMessage("Data de admissão é obrigatório");

        RuleFor(f => f.EmpresaId)
            .NotEmpty().WithMessage("Id da empresa é obrigatório");
    }
}