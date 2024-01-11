using FinancialManagement.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialManagement.Application.UseCases.CreateTransacao;

public sealed record CreateTransacaoResponse
{
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public decimal Valor { get; set; }
    public EnumTipoTransacao Tipo { get; set; }   
}
