namespace Database.TestData.TruDatPayment;

public  class TruDataPaymentCheckPrintHistory
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CheckId { get; set; }
    public Guid BatchId { get; set; }
    public DateTime PrintDate { get; set; }

    public virtual TruDataPaymentCheck? Check { get; set; }
}
