namespace Database.Trupanion.Entity.Billing.DataIntegration;

public  class BillingDataIntegrationJob
{
    public int Id { get; set; }
    public string? ExternalId { get; set; }
    public byte ExecutionStatus { get; set; }
    public DateTime StartedOn { get; set; }
    public DateTime? CompletedOn { get; set; }
    public DateTime? ProcessedOn { get; set; }
    public string? Project { get; set; }
    public string? TenantId { get; set; }

    public virtual List<BillingDataIntegrationBatch> Batches { get; set; } = new();
}
