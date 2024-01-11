using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Repositories;

public class TransacaoRepository : BaseRepository<Transacao>, ITransacaoRepository
{
    public TransacaoRepository(AppDbContext context) : base(context)
    { }

    /*public void Adicionar(Transacao transacao)
    {
        _dbContext.Transacoes.Add(transacao);
        _dbContext.SaveChanges();
    }

    public List<Transacao> ObterTransacoesDoDia(DateTime data)
    {
        return _dbContext.Transacoes
            .Where(t => EF.Functions.DateDiffDay(t.Data, data) == 0)
            .ToList();
    }*/

    public async Task<IEnumerable<Transacao>> GetTransacoes(CancellationToken cancellationToken)
    {
        return await Context.Transacoes.ToListAsync(cancellationToken);
    }

    public async Task<Transacao> GetTransacao(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Transacoes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
