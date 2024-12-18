namespace Database.Models;

public partial class TransactionType
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public virtual List<BtTransaction> Transactions { get; set; } = new();
}