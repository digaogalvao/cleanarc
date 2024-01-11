using AutoMapper;
using FinancialManagement.Domain.Interfaces;
using MediatR;

namespace FinancialManagement.Application.UseCases.UpdateTransacao;

public class UpdateTransacaoHandler : IRequestHandler<UpdateTransacaoRequest, UpdateTransacaoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITransacaoRepository _transacaoRepository;
    private readonly IMapper _mapper;

    public UpdateTransacaoHandler(IUnitOfWork unitOfWork,
                             ITransacaoRepository transacaoRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _transacaoRepository = transacaoRepository;
        _mapper = mapper;
    }
    public async Task<UpdateTransacaoResponse> Handle(UpdateTransacaoRequest command,
                                                 CancellationToken cancellationToken)
    {
        var transacao = await _transacaoRepository.Get(command.Id, cancellationToken);

        if (transacao is null) return default;

        transacao.Descricao = command.Descricao;
        transacao.Valor = command.Valor;
        transacao.Tipo = (Domain.Enum.EnumTipoTransacao)command.Tipo;

        _transacaoRepository.Update(transacao);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateTransacaoResponse>(transacao);
    }
}