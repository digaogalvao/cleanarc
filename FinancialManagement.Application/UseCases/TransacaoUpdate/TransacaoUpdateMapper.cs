using AutoMapper;
using FinancialManagement.Application.UseCases.Common;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.TransacaoUpdate
{
    public sealed class TransacaoUpdateMapper : BaseMapper<TransacaoUpdateRequest, Transacao, TransacaoUpdateResponse>
    {
        public TransacaoUpdateMapper()
        {
            // Mapeamentos específicos para UpdateTransacao
            CreateMap<TransacaoUpdateRequest, Transacao>();
            CreateMap<Transacao, TransacaoUpdateResponse>();
        }
    }
}
