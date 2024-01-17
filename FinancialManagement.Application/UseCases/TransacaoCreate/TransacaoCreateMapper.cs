using AutoMapper;
using FinancialManagement.Application.UseCases.Common;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.TransacaoCreate
{
    public sealed class TransacaoCreateMapper : BaseMapper<TransacaoCreateRequest, Transacao, TransacaoCreateResponse>
    {
        public TransacaoCreateMapper()
        {
            // Mapeamentos específicos para CreateTransacao
            CreateMap<TransacaoCreateRequest, Transacao>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignorando Id, pois é gerado automaticamente
            CreateMap<Transacao, TransacaoCreateResponse>();
        }
    }
}
