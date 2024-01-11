using FluentValidation;

namespace FinancialManagement.Application.UseCases.GetAllTransacao;

public class GetAllTransacaoValidator : AbstractValidator<GetAllTransacaoRequest>
{
    public GetAllTransacaoValidator()
    {
        //sem validação    
    }
}
