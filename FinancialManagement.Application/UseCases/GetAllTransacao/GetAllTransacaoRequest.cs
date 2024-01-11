using MediatR;

namespace FinancialManagement.Application.UseCases.GetAllTransacao;

public sealed record GetAllTransacaoRequest : 
                   IRequest<List<GetAllTransacaoResponse>>;
