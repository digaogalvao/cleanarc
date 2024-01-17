using FinancialManagement.Domain.Common;

namespace FinancialManagement.Domain.Entities
{
    public class RelatorioDiario : BaseEntity
    {
        public DateTime Data { get; set; }
        public decimal SaldoFinal { get; set; }
    }
}
