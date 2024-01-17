using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.UseCases.TransacaoGetAll
{
    public class TransacaoGetAllHandler :
        BaseHandler<TransacaoGetAllRequest, List<TransacaoGetAllResponse>, Transacao>
    {
        public TransacaoGetAllHandler(ITransacaoRepository transacaoRepository, IMapper mapper)
            : base(null, transacaoRepository, mapper) // IUnitOfWork não é necessário para leitura
        {
        }

        public override async Task<List<TransacaoGetAllResponse>> Handle(TransacaoGetAllRequest request,
            CancellationToken cancellationToken)
        {
            var transacoes = await _repository.GetAll(cancellationToken);
            return _mapper.Map<List<TransacaoGetAllResponse>>(transacoes);
        }
    }
}
