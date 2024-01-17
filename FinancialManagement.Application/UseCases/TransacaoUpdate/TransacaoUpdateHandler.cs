using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.UseCases.TransacaoUpdate
{
    public class TransacaoUpdateHandler :
        BaseHandler<TransacaoUpdateRequest, TransacaoUpdateResponse, Transacao>
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoUpdateHandler(IUnitOfWork unitOfWork,
            ITransacaoRepository transacaoRepository, IMapper mapper)
            : base(unitOfWork, transacaoRepository, mapper)
        {
        }

        public override async Task<TransacaoUpdateResponse> Handle(TransacaoUpdateRequest command,
            CancellationToken cancellationToken)
        {
            var transacao = await _transacaoRepository.GetById(command.Id, cancellationToken);

            if (transacao == null) return default;

            transacao.Descricao = command.Descricao;
            transacao.Valor = command.Valor;
            transacao.Tipo = (Domain.Enum.EnumTipoTransacao)command.Tipo;

            _repository.Update(transacao);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<TransacaoUpdateResponse>(transacao);
        }
    }
}
