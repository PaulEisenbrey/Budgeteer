namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCharity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal DefaultDonation { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public string? LogoName { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual List<TruDatDboCharityCountry> CharityCountries { get; set; } = new();
    public virtual List<TruDatDboCharityState> CharityStates { get; set; } = new();
    public virtual List<TruDatDboOwnerCharity> OwnerCharities { get; set; } = new();
    public virtual List<TruDatDboOwnerCharityEffective> OwnerCharityEffectives { get; set; } = new();
}
