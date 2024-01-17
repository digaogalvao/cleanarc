using MediatR;

namespace FinancialManagement.Application.UseCases.TransacaoGetAll;

public sealed record TransacaoGetAllRequest :
                   IRequest<List<TransacaoGetAllResponse>>;
