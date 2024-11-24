namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEventResolutionAsync
{
    public int ProcessInstanceStatusTransitionEventResolutionId { get; set; }
    public string MessageId { get; set; } = "";
    public string TriggeringMessageId { get; set; } = "";
    public string EventArgs { get; set; } = "";

    public virtual WFDboProcessInstanceStatusTransitionEventResolution? ProcessInstanceStatusTransitionEventResolution { get; set; }
}
