namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAccount
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string? AccountNumber { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboCountry? Country { get; set; }
    public virtual List<TruDatDboBankCheck> BankChecks { get; set; } = new();
}
