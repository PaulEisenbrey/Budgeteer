namespace Database.Models;

public partial class Institution
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Nickname { get; set; } = string.Empty;

    public string AccountNumber { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public virtual List<AccountDatum> AccountData { get; set; } = new();

    public virtual Address Address { get; set; } = new();
}