using AutoMapper;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.GetAllTransacao;

public sealed class GetAllTransacaoMapper : Profile
{
    public GetAllTransacaoMapper()
    {
        CreateMap<Transacao, GetAllTransacaoResponse>();
    }
}
