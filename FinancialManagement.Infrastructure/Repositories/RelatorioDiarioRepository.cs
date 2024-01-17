using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Repositories;

public class RelatorioDiarioRepository : BaseRepository<RelatorioDiario>, IRelatorioDiarioRepository
{
    public RelatorioDiarioRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Transacao>> RelatorioDiarioGetByData(DateTime data)
    {
        var transacoesDoDia = await Context.Transacoes
                .Where(r => r.DateCreated.Date == data.Date)
                .ToListAsync();

        return transacoesDoDia;
    }

}
