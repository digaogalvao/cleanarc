using MediatR;

namespace FinancialManagement.Application.UseCases.TransacaoGetById;

public sealed record TransacaoGetByIdRequest(Guid Id)
                      : IRequest<TransacaoGetByIdResponse>;