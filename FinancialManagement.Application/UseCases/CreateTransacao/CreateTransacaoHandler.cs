    using AutoMapper;
    using FinancialManagement.Domain.Entities;
    using FinancialManagement.Domain.Interfaces;
    using MediatR;

    namespace FinancialManagement.Application.UseCases.CreateTransacao;

    public class CreateTransacaoHandler :
           IRequestHandler<CreateTransacaoRequest, CreateTransacaoResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransacaoRepository _transacaoRepository;
        private readonly IMapper _mapper;

        public CreateTransacaoHandler(IUnitOfWork unitOfWork,
            ITransacaoRepository transacaoRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _transacaoRepository = transacaoRepository;
            _mapper = mapper;
        }

        public async Task<CreateTransacaoResponse> Handle(CreateTransacaoRequest request,
            CancellationToken cancellationToken)
        {
            var transacao = _mapper.Map<Transacao>(request);

            _transacaoRepository.Create(transacao);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateTransacaoResponse>(transacao);
        }
    }
