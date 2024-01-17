using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.UseCases.TransacaoDelete
{
    public class TransacaoDeleteHandler :
        BaseHandler<TransacaoDeleteRequest, RelatorioDiarioResponse, Transacao>
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoDeleteHandler(IUnitOfWork unitOfWork,
            ITransacaoRepository transacaoRepository, IMapper mapper)
            : base(unitOfWork, transacaoRepository, mapper)
        {
        }

        public override async Task<RelatorioDiarioResponse> Handle(TransacaoDeleteRequest request,
            CancellationToken cancellationToken)
        {
            var transacao = await _transacaoRepository.GetById(request.Id, cancellationToken);

            if (transacao == null) return default;

            _repository.Delete(transacao);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<RelatorioDiarioResponse>(transacao);
        }
    }
}
