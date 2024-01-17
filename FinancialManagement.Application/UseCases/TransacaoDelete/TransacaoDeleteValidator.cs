using FluentValidation;

namespace FinancialManagement.Application.UseCases.TransacaoDelete;

public class TransacaoDeleteValidator :
    AbstractValidator<TransacaoDeleteRequest>
{
    public TransacaoDeleteValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
