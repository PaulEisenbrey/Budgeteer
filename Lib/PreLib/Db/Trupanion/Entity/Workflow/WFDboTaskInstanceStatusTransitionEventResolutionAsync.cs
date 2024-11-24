namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionAsync
{
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public string MessageId { get; set; } = "";
    public string TriggeringMessageId { get; set; } = "";
    public string EventArgs { get; set; } = "";

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
}
