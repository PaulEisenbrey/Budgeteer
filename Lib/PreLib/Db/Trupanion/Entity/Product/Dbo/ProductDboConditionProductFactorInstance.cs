namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboConditionProductFactorInstance
{
    public Guid Id { get; set; }
    public Guid ConditionProductFactorId { get; set; }
    public Guid ProductFactorInstanceId { get; set; }

    public virtual ProductDboConditionProductFactor? ConditionProductFactor { get; set; }
    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
}
