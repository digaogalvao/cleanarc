using FluentValidation;

namespace FinancialManagement.Application.UseCases.DeleteTransacao;

public class DeleteTransacaoValidator :
    AbstractValidator<DeleteTransacaoRequest>
{
    public DeleteTransacaoValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
