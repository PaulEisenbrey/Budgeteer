namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentClaimPaymentPreference
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int PaymentMethodId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}
