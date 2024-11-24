namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentPaymentAttemptOrder
{
    public int PaymentAttemptId { get; set; }
    public int EntityPaymentGroupId { get; set; }
    public decimal PaymentAmount { get; set; }
    public string? PaymentMethodLast4 { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDataPaymentEntityPaymentGroup? EntityPaymentGroup { get; set; }
    public virtual TruDataPaymentPaymentAttempt? PaymentAttempt { get; set; }
}
