using AutoMapper;
using FinancialManagement.Application.UseCases.Common;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.TransacaoDelete
{
    public sealed class TransacaoDeleteMapper : BaseMapper<TransacaoDeleteRequest, Transacao, RelatorioDiarioResponse>
    {
        public TransacaoDeleteMapper()
        {
            // Mapeamentos específicos para DeleteTransacao
            CreateMap<TransacaoDeleteRequest, Transacao>();
            CreateMap<Transacao, RelatorioDiarioResponse>();
        }
    }
}
