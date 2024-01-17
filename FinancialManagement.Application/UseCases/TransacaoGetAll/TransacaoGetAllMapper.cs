using AutoMapper;
using FinancialManagement.Application.UseCases.Common;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.TransacaoGetAll
{
    public sealed class TransacaoGetMapper : BaseMapper<Transacao, Transacao, TransacaoGetAllResponse>
    {
        public TransacaoGetMapper()
        {
            // Mapeamentos específicos para GetAllTransacao
            CreateMap<Transacao, TransacaoGetAllResponse>();
        }
    }
}
