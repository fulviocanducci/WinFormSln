using FluentValidation;

namespace Models.Validations
{
    public class PeopleValidator : AbstractValidator<People>
    {
        public PeopleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Digite o nome")
                .MaximumLength(100).WithMessage("Máximo de 100 caracteres");

            RuleFor(x => x.Salary)
                .NotNull()
                .WithMessage("Digite o salário")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Digite no minimo 1 real");

            RuleFor(x => x.Active)
                .NotNull()
                .WithMessage("Ativo ou inativo");
        }
    }
}
