using MediatR;

namespace FinancialManagement.Application.UseCases.CreateTransacao
{
    public sealed record CreateTransacaoRequest(
        string Descricao, decimal Valor, int Tipo) :
         IRequest<CreateTransacaoResponse>;

}
