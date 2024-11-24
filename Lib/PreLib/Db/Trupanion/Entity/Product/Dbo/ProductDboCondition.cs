namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCondition
{
    public Guid Id { get; set; }
    public Guid ConditionEffectId { get; set; }
    public string? Description { get; set; }

    public virtual ProductDboConditionEffect? ConditionEffect { get; set; }
    public virtual List<ProductDboConditionProductFactor> ConditionProductFactors { get; set; } = new();
    public virtual List<ProductDboEndorsementCondition> EndorsementConditions { get; set; } = new();
    public virtual List<ProductDboFormCondition> FormConditions { get; set; } = new();
    public virtual List<ProductDboPlanCondition> PlanConditions { get; set; } = new();
}
