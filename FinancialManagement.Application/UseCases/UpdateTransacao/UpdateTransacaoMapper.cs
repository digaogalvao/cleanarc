using AutoMapper;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.UpdateTransacao;

public sealed class UpdateTransacaoMapper : Profile
{
    public UpdateTransacaoMapper()
    {
        CreateMap<UpdateTransacaoRequest, Transacao>();
        CreateMap<Transacao, UpdateTransacaoResponse>();
    }
}
