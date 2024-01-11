using MediatR;

namespace FinancialManagement.Application.UseCases.DeleteTransacao;

public sealed record DeleteTransacaoRequest(Guid Id)
                  : IRequest<DeleteTransacaoResponse>;
