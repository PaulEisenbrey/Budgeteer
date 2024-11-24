namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboDeductibleToProductFactorInstanceMap
{
    public Guid Id { get; set; }
    public decimal Deductible { get; set; }
    public Guid ProductFactorInstanceId { get; set; }
    public Guid ProductFactorId { get; set; }

    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
