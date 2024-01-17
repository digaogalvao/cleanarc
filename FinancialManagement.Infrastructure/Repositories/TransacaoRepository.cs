using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Repositories;

public class TransacaoRepository : BaseRepository<Transacao>, ITransacaoRepository
{
    public TransacaoRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Transacao> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Set<Transacao>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

}
