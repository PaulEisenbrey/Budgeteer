namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCountryToCountryProductFactorInstanceMap
{
    public string? IsoAlpha3CountryCode { get; set; }
    public Guid ProductFactorInstanceId { get; set; }

    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
