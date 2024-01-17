using MediatR;

namespace FinancialManagement.Application.UseCases.TransacaoCreate
{
    public sealed record TransacaoCreateRequest(
        string Descricao, decimal Valor, int Tipo) :
         IRequest<TransacaoCreateResponse>;

}
