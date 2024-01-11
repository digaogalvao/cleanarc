using FluentValidation;

namespace FinancialManagement.Application.UseCases.UpdateTransacao;

public class UpdateTransacaoValidator : AbstractValidator<UpdateTransacaoRequest>
{
    public UpdateTransacaoValidator()
    {
        RuleFor(x => x.Descricao).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Valor).NotEmpty().PrecisionScale(18, 2, false);
        RuleFor(x => x.Tipo).NotEmpty();
    }
}
