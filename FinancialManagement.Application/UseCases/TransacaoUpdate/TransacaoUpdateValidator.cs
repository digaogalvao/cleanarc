using FluentValidation;

namespace FinancialManagement.Application.UseCases.TransacaoUpdate;

public class TransacaoUpdateValidator : AbstractValidator<TransacaoUpdateRequest>
{
    public TransacaoUpdateValidator()
    {
        RuleFor(x => x.Descricao).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Valor).NotEmpty().PrecisionScale(18, 2, false);
        RuleFor(x => x.Tipo).NotEmpty();
    }
}
