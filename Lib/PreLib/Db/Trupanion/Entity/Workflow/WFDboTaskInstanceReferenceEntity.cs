namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceReferenceEntity
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceId { get; set; }
    public int EnterpriseEntityId { get; set; }
    public string EntityId { get; set; } = "";

    public virtual WFDboTaskInstance? TaskInstance { get; set; }
}
