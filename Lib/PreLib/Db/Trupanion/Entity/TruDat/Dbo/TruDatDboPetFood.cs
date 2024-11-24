namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetFood
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public int Sequence { get; set; }
    public int CountryId { get; set; }

    public virtual TruDatDboCountry? Country { get; set; }
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPet> Pets { get; set; } = new();
}
