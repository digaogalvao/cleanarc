using MediatR;

namespace FinancialManagement.Application.UseCases.TransacaoDelete;

public sealed record TransacaoDeleteRequest(Guid Id)
                  : IRequest<RelatorioDiarioResponse>;
