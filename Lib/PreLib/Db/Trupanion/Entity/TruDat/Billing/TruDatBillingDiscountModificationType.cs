namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingDiscountModificationType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatBillingDiscount> Discounts { get; set; } = new();
}
