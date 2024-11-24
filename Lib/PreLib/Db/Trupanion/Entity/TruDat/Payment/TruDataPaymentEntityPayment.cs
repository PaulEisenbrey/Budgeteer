namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentEntityPayment
{
    public int Id { get; set; }
    public int EntityPaymentGroupId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int StatusId { get; set; }
    public decimal Amount { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public Guid? ApprovalBatchId { get; set; }

    public virtual TruDataPaymentEntityPaymentGroup? EntityPaymentGroup { get; set; }
}
