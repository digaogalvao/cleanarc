using AutoMapper;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.CreateTransacao;

public sealed class CreateTransacaoMapper : Profile
{
    public CreateTransacaoMapper()
    {
        CreateMap<CreateTransacaoRequest, Transacao>();
        CreateMap<Transacao, CreateTransacaoResponse>();
    }
}
