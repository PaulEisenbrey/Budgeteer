namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEvent
{
    public int ProcessInstanceEventId { get; set; }
    public int PreTransitionProcessInstanceStatusId { get; set; }
    public int PostTransitionProcessInstanceStatusId { get; set; }

    public virtual WFDboProcessInstanceStatus? PostTransitionProcessInstanceStatus { get; set; }
    public virtual WFDboProcessInstanceStatus? PreTransitionProcessInstanceStatus { get; set; }
    public virtual WFDboProcessInstanceEvent? ProcessInstanceEvent { get; set; }
}
