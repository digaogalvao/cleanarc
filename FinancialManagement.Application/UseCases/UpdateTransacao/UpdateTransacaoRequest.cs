using MediatR;

namespace FinancialManagement.Application.UseCases.UpdateTransacao;

public sealed record UpdateTransacaoRequest(Guid Id,
                      string Descricao, decimal Valor, int Tipo)
                      : IRequest<UpdateTransacaoResponse>;
