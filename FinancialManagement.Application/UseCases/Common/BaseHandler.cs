using AutoMapper;
using FinancialManagement.Domain.Common;
using FinancialManagement.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

public abstract class BaseHandler<TRequest, TResponse, TEntity> :
    IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TEntity : BaseEntity
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IBaseRepository<TEntity> _repository;
    protected readonly IMapper _mapper;

    protected BaseHandler(IUnitOfWork unitOfWork, IBaseRepository<TEntity> repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }

    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
