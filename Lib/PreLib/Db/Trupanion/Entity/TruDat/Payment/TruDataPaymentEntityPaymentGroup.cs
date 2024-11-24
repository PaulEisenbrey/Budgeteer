namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentEntityPaymentGroup
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public bool Closed { get; set; }
    public int? AccountId { get; set; }
    public int? IssuedByUserId { get; set; }
    public int? CancelledByUserId { get; set; }
    public DateTime? DateCancelled { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }
    public int? PaymentMethodId { get; set; }
    public DateTime? ScheduledPaymentDate { get; set; }
    public int? OwnerId { get; set; }

    public virtual TruDataPaymentAccount? Account { get; set; }
    public virtual List<TruDataPaymentEntityPayment> EntityPayments { get; set; } = new();
    public virtual List<TruDataPaymentPaymentAttemptOrder> PaymentAttemptOrders { get; set; } = new();
}
