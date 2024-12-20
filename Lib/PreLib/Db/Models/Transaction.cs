using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class Transaction : EntityIntId
{
    public Guid TransactionId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public int Source { get; set; }

    public string CheckNumber { get; set; } = string.Empty;

    public int TransactionTypeId { get; set; }

    public virtual TransactionType TransactionType { get; set; } = new();
}
