using FluentValidation;

namespace FinancialManagement.Application.UseCases.TransacaoGetAll;

public class TransacaoGetAllValidator : AbstractValidator<TransacaoGetAllRequest>
{
    public TransacaoGetAllValidator()
    {
        //sem validação    
    }
}
