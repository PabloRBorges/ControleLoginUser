using FluentValidation;
using LoginUserControl.Core.Entities;

namespace LoginUserControl.Service.Validation
{
    public class DadoRecebidoValidator : AbstractValidator<DadoRecebido>
    {
        public DadoRecebidoValidator()
        {
            RuleFor(c => c.IdPlaca)
                .NotEmpty().WithMessage("Por favor, entre com id da placa.")
                .NotNull().WithMessage("Por favor, entre com id da placa.");

            RuleFor(c => c.DadosJson )
                .NotEmpty().WithMessage("Por favor, entre com os dados Json.")
                .NotNull().WithMessage("Por favor, entre com  os dados Json.");
        }
    }
}
