using MediatR;

namespace FinancialManagement.Application.UseCases.TransacaoUpdate;

public sealed record TransacaoUpdateRequest(Guid Id,
                      string Descricao, decimal Valor, int Tipo)
                      : IRequest<TransacaoUpdateResponse>;
