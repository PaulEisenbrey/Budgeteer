namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerInvestigation
{
    public int? PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public DateTime? BillingDate { get; set; }
    public int? BillingDayOfMonth { get; set; }
    public int? Lastday { get; set; }
    public int? DefaultPaymentMethod { get; set; }
}
