namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingAmazonWalletPayment
{
    public int Id { get; set; }
    public decimal? Total { get; set; }
    public int? PaymentAttemptId { get; set; }
    public string? BillingAgreementId { get; set; }
}
