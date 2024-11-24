namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboStateToStateProductFactorInstanceMap
{
    public string? IsoAlpha3CountryCode { get; set; }
    public string? StateCode { get; set; }
    public Guid ProductFactorInstanceId { get; set; }

    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
