using AutoMapper;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.DeleteTransacao;

public sealed class DeleteTransacaoMapper : Profile
{
    public DeleteTransacaoMapper()
    {
        CreateMap<DeleteTransacaoRequest, Transacao>();
        CreateMap<Transacao, DeleteTransacaoResponse>();
    }
}
