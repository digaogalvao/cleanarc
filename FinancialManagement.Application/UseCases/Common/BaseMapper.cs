using AutoMapper;
using FinancialManagement.Domain.Common;

namespace FinancialManagement.Application.UseCases.Common
{
    public abstract class BaseMapper<TRequest, TEntity, TResponse> : Profile
    {
        protected BaseMapper()
        {
            CreateMap<TRequest, TEntity>();
            CreateMap<TEntity, TResponse>();
            // Outras configurações comuns
        }
    }
}
