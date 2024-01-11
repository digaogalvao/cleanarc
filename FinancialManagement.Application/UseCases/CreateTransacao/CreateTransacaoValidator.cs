using FluentValidation;

namespace FinancialManagement.Application.UseCases.CreateTransacao;

public sealed class CreateTransacaoValidator : AbstractValidator<CreateTransacaoRequest>
{
    public CreateTransacaoValidator()
    {
        RuleFor(x => x.Descricao).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Valor).NotEmpty().PrecisionScale(18, 2, false);
        RuleFor(x => x.Tipo).NotEmpty();
    }
}
