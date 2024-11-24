namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProductFactorInstance
{
    public Guid Id { get; set; }
    public string? InstanceName { get; set; }
    public Guid ProductFactorId { get; set; }
    public Guid? ParentId { get; set; }
    public int Score { get; set; }

    public virtual ProductDboProductFactorInstance? Parent { get; set; }
    public virtual ProductDboProductFactor? ProductFactor { get; set; }
    public virtual List<ProductDboCoinsuranceToProductFactorInstanceMap> CoinsuranceToProductFactorInstanceMaps { get; set; } = new();
    public virtual List<ProductDboConditionProductFactorInstance> ConditionProductFactorInstances { get; set; } = new();
    public virtual List<ProductDboCountryToCountryProductFactorInstanceMap> CountryToCountryProductFactorInstanceMaps { get; set; } = new();
    public virtual List<ProductDboDeductibleToProductFactorInstanceMap> DeductibleToProductFactorInstanceMaps { get; set; } = new();
    public virtual List<ProductDboProductFactorInstance> InverseParent { get; set; } = new();
    public virtual List<ProductDboPostalCodeToGeoRegionProductFactorInstanceMap> PostalCodeToGeoRegionProductFactorInstanceMaps { get; set; } = new();
    public virtual List<ProductDboStateToStateProductFactorInstanceMap> StateToStateProductFactorInstanceMaps { get; set; } = new();
}
