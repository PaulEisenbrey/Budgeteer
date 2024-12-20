using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class AccountDatum : EntityIntId
{
    public DateTime OpenDate { get; set; }

    public int AccountTypeId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Nickname { get; set; } = string.Empty;

    public string AccountNumber { get; set; } = string.Empty;

    public string RoutingNumber { get; set; } = string.Empty;

    public decimal InitialBalance { get; set; } = 0.0m;

    public virtual ICollection<AccountAprlookup> AccountAprlookups { get; set; } = new List<AccountAprlookup>();

    public virtual AccountType AccountType { get; set; } = new();

    public virtual ICollection<InstitutionAccountsLookup> InstitutionAccountsLookups { get; set; } = new List<InstitutionAccountsLookup>();
}
