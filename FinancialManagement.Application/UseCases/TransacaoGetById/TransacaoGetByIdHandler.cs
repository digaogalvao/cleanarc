using AutoMapper;
using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;

namespace FinancialManagement.Application.UseCases.TransacaoGetById
{
    public class TransacaoGetByIdHandler :
        BaseHandler<TransacaoGetByIdRequest, TransacaoGetByIdResponse, Transacao>
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoGetByIdHandler(ITransacaoRepository transacaoRepository, IMapper mapper)
            : base(null, transacaoRepository, mapper) // IUnitOfWork não é necessário para leitura
        {
        }

        public override async Task<TransacaoGetByIdResponse> Handle(TransacaoGetByIdRequest command,
            CancellationToken cancellationToken)
        {
            var transacao = await _transacaoRepository.GetById(command.Id, cancellationToken);

            if (transacao == null) return default;

            return _mapper.Map<TransacaoGetByIdResponse>(transacao);
        }

    }
}
