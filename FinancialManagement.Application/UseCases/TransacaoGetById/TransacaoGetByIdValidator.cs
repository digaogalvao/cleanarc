using FluentValidation;

namespace FinancialManagement.Application.UseCases.TransacaoGetById;

public class TransacaoGetByIdValidator : AbstractValidator<TransacaoGetByIdRequest>
{
    public TransacaoGetByIdValidator()
    {
        //sem validação    
    }
}
