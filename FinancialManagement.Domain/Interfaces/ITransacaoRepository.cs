using FinancialManagement.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagement.Domain.Interfaces;

public interface ITransacaoRepository : IBaseRepository<Transacao>
{
    Task<Transacao> GetById(Guid id, CancellationToken cancellationToken);
}
