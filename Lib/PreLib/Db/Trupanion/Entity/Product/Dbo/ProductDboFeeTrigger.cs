namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFeeTrigger
{
    public Guid Id { get; set; }
    public Guid EventTypeId { get; set; }
    public Guid FeeTypeId { get; set; }

    public virtual ProductDboEventType? EventType { get; set; }
    public virtual ProductDboFeeType? FeeType { get; set; }
}
