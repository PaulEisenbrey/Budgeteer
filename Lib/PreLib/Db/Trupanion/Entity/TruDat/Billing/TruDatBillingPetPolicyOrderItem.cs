namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingPetPolicyOrderItem
{
    public int Id { get; set; }
    public DateTime BillingDate { get; set; }
    public bool? IsNewPolicy { get; set; }
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    public int? PetPolicyId { get; set; }
    public int? ProratedDays { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Taxtotal { get; set; }
}
