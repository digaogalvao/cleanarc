using FinancialManagement.Domain.Enum;

namespace FinancialManagement.Application.UseCases.Common
{
    public record TransacaoBaseResponse
    {
        public Guid Id { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public EnumTipoTransacao Tipo { get; set; }
        // Outros campos comuns, se necessário
    }
}
