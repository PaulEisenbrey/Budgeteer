namespace Database.Models;

public partial class BtTransaction
{
    public int Id { get; set; }

    public Guid TransactionId { get; set; }

    public int AccountDatumId { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public int SourceId { get; set; }

    public string Description { get; set; } = string.Empty;

    public string CheckNumber { get; set; } = string.Empty;

    public int TransactionTypeId { get; set; }

    public int BudgetCategoryId { get; set; }
    
    public bool IsDeposit { get; set; }

    public virtual AccountDatum AccountDatum { get; set; } = new();

    public virtual TransactionType TransactionType { get; set; } = new();
}