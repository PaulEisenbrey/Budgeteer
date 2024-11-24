namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboExternalRequestLog
{
    public int Id { get; set; }
    public int ObjectTypeId { get; set; }
    public string? ObjectId { get; set; }
    public string? Payload { get; set; }
    public string? StackTrace { get; set; }
    public DateTime CreatedOn { get; set; }
}
