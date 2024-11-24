namespace Database.Trupanion.Entity.Billing.DataIntegration;

public  class BillingDataIntegrationBatch
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string? ExternalId { get; set; }
    public byte ExecutionStatus { get; set; }
    public byte? ProcessingStatus { get; set; }
    public DateTime? CompletedOn { get; set; }
    public DateTime? ProcessedOn { get; set; }
    public string? FileId { get; set; }
    public string? Name { get; set; }

    public virtual BillingDataIntegrationJob? Job { get; set; }
}
