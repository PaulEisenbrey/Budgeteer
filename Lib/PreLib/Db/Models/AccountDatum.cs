namespace Database.Models;

public partial class AccountDatum
{
    public int Id { get; set; }

    public int InstitutionId { get; set; }

    public DateTime OpenDate { get; set; }

    public int AccountTypeId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Nickname { get; set; } = string.Empty;

    public string AccountNumber { get; set; } = string.Empty;

    public string RoutingNumber { get; set; } = string.Empty;

    public decimal InitialBalance { get; set; }

    public Guid AccountUniqueId { get; set; }

    public virtual AccountType AccountType { get; set; } = new();

    public virtual List<AnnualPercentageRate> AnnualPercentageRates { get; set; } = new();

    public virtual Institution Institution { get; set; } = new();

    public virtual List<BtTransaction> btTransactions { get; set; } = new();
}