namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatBillingOrderItem> OrderItems { get; set; } = new();
}
