namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceChangeAssignmentEvent
{
    public int TaskInstanceEventId { get; set; }
    public Guid? PreAssignedToUserId { get; set; }
    public Guid? PostAssignedToUserId { get; set; }
    public bool WasAutomated { get; set; }

    public virtual WFDboTaskInstanceEvent? TaskInstanceEvent { get; set; }
}
