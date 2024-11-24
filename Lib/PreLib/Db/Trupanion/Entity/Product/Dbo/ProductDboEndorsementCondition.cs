namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEndorsementCondition
{
    public Guid Id { get; set; }
    public Guid EndorsementId { get; set; }
    public Guid ConditionId { get; set; }

    public virtual ProductDboCondition? Condition { get; set; }
    public virtual ProductDboEndorsement? Endorsement { get; set; }
}
