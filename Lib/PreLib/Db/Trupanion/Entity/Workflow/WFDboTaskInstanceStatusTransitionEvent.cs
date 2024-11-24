namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEvent
{
    public int TaskInstanceEventId { get; set; }
    public int PreTransitionTaskInstanceStatusId { get; set; }
    public int PostTransitionTaskInstanceStatusId { get; set; }

    public virtual WFDboTaskInstanceStatus? PostTransitionTaskInstanceStatus { get; set; }
    public virtual WFDboTaskInstanceStatus? PreTransitionTaskInstanceStatus { get; set; }
    public virtual WFDboTaskInstanceEvent? TaskInstanceEvent { get; set; }
}
