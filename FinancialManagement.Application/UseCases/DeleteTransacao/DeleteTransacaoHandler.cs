using AutoMapper;
using FinancialManagement.Domain.Interfaces;
using MediatR;

namespace FinancialManagement.Application.UseCases.DeleteTransacao;

public sealed class DeleteTransacaoHandler :
                    IRequestHandler<DeleteTransacaoRequest, DeleteTransacaoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITransacaoRepository _transacaoRepository;
    private readonly IMapper _mapper;

    public DeleteTransacaoHandler(IUnitOfWork unitOfWork,
                             ITransacaoRepository transacaoRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _transacaoRepository = transacaoRepository;
        _mapper = mapper;
    }

    public async Task<DeleteTransacaoResponse> Handle(DeleteTransacaoRequest request,
                                                 CancellationToken cancellationToken)
    {

        var user = await _transacaoRepository.Get(request.Id, cancellationToken);

        if (user == null) return default;

        _transacaoRepository.Delete(user);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteTransacaoResponse>(user);
    }
}
