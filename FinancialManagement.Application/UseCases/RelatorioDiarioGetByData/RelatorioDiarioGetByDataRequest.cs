using MediatR;

namespace FinancialManagement.Application.UseCases.RelatorioDiarioGetByData;

public sealed record RelatorioDiarioGetByDataRequest(DateTime Data)
                  : IRequest<RelatorioDiarioGetByDataResponse>;
