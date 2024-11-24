namespace Database.Trupanion.Entity.Workflow;

public class WFDboActiveProcessInstance
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public DateTimeOffset? FinalizedOn { get; set; }
    public int ProcessDefinitionId { get; set; }
    public int ProcessInstanceStatusId { get; set; }
    public int ProcessInstanceStatusGroupId { get; set; }
    public Guid? OwningUserId { get; set; }
    public int? ProcessInstancePriorityId { get; set; }
    public int? CurrentProcessDefinitionFlowId { get; set; }

    public virtual WFDboProcessInstance? IdNavigation { get; set; }
}
