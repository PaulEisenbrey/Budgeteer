namespace Database.Models;

public partial class AccountType
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public virtual List<AccountDatum> AccountData { get; set; } = new();
}