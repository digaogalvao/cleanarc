using FinancialManagement.Application.UseCases.Common;

namespace FinancialManagement.Application.UseCases.RelatorioDiarioGetByData;

public sealed record RelatorioDiarioGetByDataResponse
{
    public DateTime Data { get; set; }
    public decimal SaldoFinal { get; set; }
}