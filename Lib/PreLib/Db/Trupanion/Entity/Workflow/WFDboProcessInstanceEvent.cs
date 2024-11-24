namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceEvent
{
    public WFDboProcessInstanceEvent()
    {
        ProcessInstanceStatusTransitionEventResolutions = new HashSet<WFDboProcessInstanceStatusTransitionEventResolution>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ProcessInstanceId { get; set; }
    public int TriggeringEventId { get; set; }

    public virtual WFDboProcessInstance? ProcessInstance { get; set; }
    public virtual WFDboEvent? TriggeringEvent { get; set; }
    public virtual WFDboProcessInstanceChangeOwnerEvent? ProcessInstanceChangeOwnerEvent { get; set; }
    public virtual WFDboProcessInstanceStatusTransitionEvent? ProcessInstanceStatusTransitionEvent { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionEventResolution> ProcessInstanceStatusTransitionEventResolutions { get; set; }
}
