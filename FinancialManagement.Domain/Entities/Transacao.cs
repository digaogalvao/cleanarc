using FinancialManagement.Domain.Common;
using FinancialManagement.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialManagement.Domain.Entities;

public class Transacao : BaseEntity
{
    public string Descricao { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }
    public EnumTipoTransacao Tipo { get; set; }
}
