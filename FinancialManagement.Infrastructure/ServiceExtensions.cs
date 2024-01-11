using FinancialManagement.Application.Services;
using FinancialManagement.Domain.Interfaces;
using FinancialManagement.Infrastructure.Context;
using FinancialManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagement.Infrastructure;

public static class ServiceExtensions
{
    public static void ConfigureInfrastructureApp(this IServiceCollection services,
                                                IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ITransacaoRepository, TransacaoRepository>();
    }
}
