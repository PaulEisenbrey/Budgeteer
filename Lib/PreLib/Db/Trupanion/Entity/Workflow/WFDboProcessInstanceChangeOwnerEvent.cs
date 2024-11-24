namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceChangeOwnerEvent
{
    public int ProcessInstanceEventId { get; set; }
    public Guid? PreOwningUserId { get; set; }
    public Guid? PostOwningUserId { get; set; }

    public virtual WFDboProcessInstanceEvent? ProcessInstanceEvent { get; set; }
}
