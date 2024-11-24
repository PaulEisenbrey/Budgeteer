namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPostalCodeToGeoRegionProductFactorInstanceMap
{
    public string? IsoAlpha3CountryCode { get; set; }
    public string? PostalCode { get; set; }
    public Guid ProductFactorInstanceId { get; set; }

    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
