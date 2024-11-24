namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboMessageRetry
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public int EnterpriseHandlerId { get; set; }
    public string? MessageId { get; set; }
    public string? TriggeringMessageId { get; set; }
    public string? SerializedMessage { get; set; }
    public DateTime LastAttempt { get; set; }
    public int AttemptInterval { get; set; }
    public int MaximumAttempts { get; set; }
    public int AttemptCount { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplicationEventHandler? EnterpriseHandler { get; set; }
}
