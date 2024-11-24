namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionText
{
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public string ResolutionText { get; set; } = "";

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
}
