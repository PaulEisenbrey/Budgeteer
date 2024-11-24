namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFormDeliveryMethod
{
    public ProductDboFormDeliveryMethod()
    {
        FormDeliveryTriggers = new HashSet<ProductDboFormDeliveryTrigger>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; }
}
