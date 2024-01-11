using FinancialManagement.Domain.Enum;

namespace FinancialManagement.Application.UseCases.UpdateTransacao;

public sealed record UpdateTransacaoResponse
{
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public decimal Valor { get; set; }
    public EnumTipoTransacao Tipo { get; set; }
}
