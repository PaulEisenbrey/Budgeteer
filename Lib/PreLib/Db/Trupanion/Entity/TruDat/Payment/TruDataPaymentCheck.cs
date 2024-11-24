namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentCheck
{
    public int Id { get; set; }
    public int EntityPaymentGroupId { get; set; }
    public string? Memo { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual List<TruDataPaymentCheckPrintHistory> CheckPrintHistories { get; set; } = new();
}
