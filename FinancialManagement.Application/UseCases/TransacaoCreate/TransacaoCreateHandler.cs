using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace FinancialManagement.Application.UseCases.TransacaoCreate
{
    public class TransacaoCreateHandler : BaseHandler<TransacaoCreateRequest, TransacaoCreateResponse, Transacao>
    {
        public TransacaoCreateHandler(IUnitOfWork unitOfWork, ITransacaoRepository transacaoRepository, IMapper mapper)
            : base(unitOfWork, transacaoRepository, mapper)
        {
        }

        public override async Task<TransacaoCreateResponse> Handle(TransacaoCreateRequest request, CancellationToken cancellationToken)
        {
            var transacao = _mapper.Map<Transacao>(request);

            _repository.Create(transacao);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<TransacaoCreateResponse>(transacao);
        }
    }
}
