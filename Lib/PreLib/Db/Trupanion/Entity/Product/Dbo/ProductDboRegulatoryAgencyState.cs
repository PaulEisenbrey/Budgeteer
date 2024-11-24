namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRegulatoryAgencyState
{
    public Guid Id { get; set; }
    public Guid RegulatoryAgencyId { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? StateCode { get; set; }

    public virtual ProductDboRegulatoryAgency? RegulatoryAgency { get; set; }
}
