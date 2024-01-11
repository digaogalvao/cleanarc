using AutoMapper;
using FinancialManagement.Domain.Interfaces;
using MediatR;

namespace FinancialManagement.Application.UseCases.GetAllTransacao;

public sealed class GetAllTransacaoHandler : IRequestHandler<GetAllTransacaoRequest, List<GetAllTransacaoResponse>>
{
    private readonly ITransacaoRepository _transacaoRepository;
    private readonly IMapper _mapper;

    public GetAllTransacaoHandler(ITransacaoRepository transacaoRepository, IMapper mapper)
    {
        _transacaoRepository = transacaoRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllTransacaoResponse>> Handle(GetAllTransacaoRequest request, CancellationToken cancellationToken)
    {
        var users = await _transacaoRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllTransacaoResponse>>(users);
    }
}
