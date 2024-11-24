namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEventType
{
    public ProductDboEventType()
    {
        FeeTriggers = new HashSet<ProductDboFeeTrigger>();
        FormDeliveryTriggers = new HashSet<ProductDboFormDeliveryTrigger>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboFeeTrigger> FeeTriggers { get; set; }
    public virtual ICollection<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; }
}
