namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCountry
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Currency { get; set; }
    public string? CurrencySymbol { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? CountryCode { get; set; }

    public virtual List<TruDatDboAccount> Accounts { get; set; } = new();
    public virtual List<TruDatDboCharityCountry> CharityCountries { get; set; } = new();
    public virtual List<TruDatDboPetFood> PetFoods { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboState> States { get; set; } = new();
}
