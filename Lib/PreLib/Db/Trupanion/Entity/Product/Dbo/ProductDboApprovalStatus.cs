namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboApprovalStatus
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual List<ProductDboApproval> Approvals { get; set; } = new();
}
