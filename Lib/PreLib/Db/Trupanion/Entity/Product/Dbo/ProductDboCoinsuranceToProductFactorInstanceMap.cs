namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCoinsuranceToProductFactorInstanceMap
{
    public Guid Id { get; set; }
    public decimal Coinsurance { get; set; }
    public Guid ProductFactorInstanceId { get; set; }
    public Guid ProductFactorId { get; set; }

    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
