namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboMessageInterventionExceptionInfo
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int MessageInterventionId { get; set; }
    public int AttemptNumber { get; set; }
    public int EnterpriseHostId { get; set; }
    public bool IsTransient { get; set; }
    public string? SerializedException { get; set; }
    public string? SerializedMessage { get; set; }

    public virtual EnterpriseCatalogDboMessageIntervention? MessageIntervention { get; set; }
}
