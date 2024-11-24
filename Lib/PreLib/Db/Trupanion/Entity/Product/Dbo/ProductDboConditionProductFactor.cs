namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboConditionProductFactor
{
    public Guid Id { get; set; }
    public Guid ConditionId { get; set; }
    public Guid ProductFactorId { get; set; }
    public Guid ConditionOperatorId { get; set; }

    public virtual ProductDboCondition? Condition { get; set; }
    public virtual ProductDboConditionOperator? ConditionOperator { get; set; }
    public virtual ProductDboProductFactor? ProductFactor { get; set; }
    public virtual List<ProductDboConditionProductFactorInstance> ConditionProductFactorInstances { get; set; } = new();
}
