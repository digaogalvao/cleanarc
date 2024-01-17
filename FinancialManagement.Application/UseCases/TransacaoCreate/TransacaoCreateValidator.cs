using FluentValidation;

namespace FinancialManagement.Application.UseCases.TransacaoCreate;

public sealed class TransacaoCreateValidator : AbstractValidator<TransacaoCreateRequest>
{
    public TransacaoCreateValidator()
    {
        RuleFor(x => x.Descricao).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Valor).NotEmpty().PrecisionScale(18, 2, false);
        RuleFor(x => x.Tipo).NotEmpty();
    }
}
