namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProductFactor
{
    public Guid Id { get; set; }
    public Guid? ParentId { get; set; }
    public string? SystemName { get; set; }
    public string? DisplayName { get; set; }

    public virtual ProductDboProductFactor? Parent { get; set; }
    public virtual List<ProductDboConditionProductFactor> ConditionProductFactors { get; set; } = new();
    public virtual List<ProductDboProductFactor> InverseParent { get; set; } = new();
    public virtual List<ProductDboProductFactorInstance> ProductFactorInstances { get; set; } = new();
    public virtual List<ProductDboProductVersionProductFactor> ProductVersionProductFactors { get; set; } = new();
}
