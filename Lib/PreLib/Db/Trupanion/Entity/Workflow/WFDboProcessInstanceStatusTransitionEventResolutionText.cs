namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEventResolutionText
{
    public int ProcessInstanceStatusTransitionEventResolutionId { get; set; }
    public string ResolutionText { get; set; } = "";

    public virtual WFDboProcessInstanceStatusTransitionEventResolution? ProcessInstanceStatusTransitionEventResolution { get; set; }
}
