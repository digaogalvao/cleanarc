using FinancialManagement.Domain.Entities;

namespace FinancialManagement.Domain.Interfaces;

public interface ITransacaoRepository : IBaseRepository<Transacao>
{
    //void Adicionar(Transacao transacao);
    //List<Transacao> ObterTransacoesDoDia(DateTime data);
    Task<IEnumerable<Transacao>> GetTransacoes(CancellationToken cancellationToken);
    Task<Transacao> GetTransacao(Guid id, CancellationToken cancellationToken);
}
