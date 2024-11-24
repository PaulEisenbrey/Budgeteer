namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizLegacyPolicyHolderBillingInfo
{
    public int Id { get; set; }
    public DateTime? BillingPastDue { get; set; }
    public decimal? TotalPremium { get; set; }
    public DateTime? NextBillingDate { get; set; }
    public string PaymentMethod { get; set; } = "";
    public int? PaymentMethodId { get; set; }
    public DateTime? AdjustmentDate { get; set; }
}
