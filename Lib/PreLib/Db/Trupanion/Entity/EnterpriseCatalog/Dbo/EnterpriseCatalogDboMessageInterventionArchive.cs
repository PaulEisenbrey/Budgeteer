namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboMessageInterventionArchive
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public DateTime InterventionCreatedOn { get; set; }
    public Guid InterventionCreatedBy { get; set; }
    public Guid? InterventionCreatedOnBehalfOf { get; set; }
    public DateTime InterventionModifiedOn { get; set; }
    public Guid InterventionModifiedBy { get; set; }
    public Guid? InterventionModifiedOnBehalfOf { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public int EnterpriseHandlerId { get; set; }
    public string? MessageId { get; set; }
    public string? TriggeringMessageId { get; set; }
    public string? SerializedMessage { get; set; }
    public int ProcessInstanceId { get; set; }
    public bool ResumeComplete { get; set; }
    public string? ResumeNote { get; set; }
    public Guid? LocalId { get; set; }
    public string? ResolvedException { get; set; }
    public bool? Fail { get; set; }
    public string? HandlerType { get; set; }
    public int? FailureCount { get; set; }
    public bool? IsTransient { get; set; }
}
