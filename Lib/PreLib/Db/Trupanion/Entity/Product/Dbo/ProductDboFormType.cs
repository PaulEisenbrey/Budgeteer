namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFormType
{
    public ProductDboFormType()
    {
        Forms = new HashSet<ProductDboForm>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboForm> Forms { get; set; }
}
