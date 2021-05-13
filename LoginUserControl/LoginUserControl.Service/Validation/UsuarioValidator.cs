using FluentValidation;
using LoginUserControl.Domain.Entities;

namespace LoginUserControl.Service.Validation
{
    public class UsuarioValidator : AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, entre com o nome.")
                .NotNull().WithMessage("Por favor, entre com o nome.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor, entre com o email.")
                .NotNull().WithMessage("Por favor, entre com o email.");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Por favor, entre com a senha.")
                .NotNull().WithMessage("Por favor, entre com a senha.");

        }

    }
}
