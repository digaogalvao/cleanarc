using FinancialManagement.Application.UseCases.Common;
using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Application.UseCases.TransacaoGetById
{
    public sealed class TransacaoGetByIdMapper : BaseMapper<Transacao, Transacao, TransacaoGetByIdResponse>
    {
        public TransacaoGetByIdMapper()
        {
            // Mapeamentos específicos para GetAllTransacao
            CreateMap<Transacao, TransacaoGetByIdResponse>();
        }
    }
}
