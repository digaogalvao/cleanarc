using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Domain.Interfaces;

public interface IRelatorioDiarioRepository
{
    Task<List<Transacao>> RelatorioDiarioGetByData(DateTime data);
}
