namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolution
{
    public int Id { get; set; }
    public int TaskInstanceEventId { get; set; }
    public int? InputConfigurationId { get; set; }

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
    public virtual WFDboTaskInstanceEvent? TaskInstanceEvent { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionAsync? TaskInstanceStatusTransitionEventResolutionAsync { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionCancelWait? TaskInstanceStatusTransitionEventResolutionCancelWait { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing? TaskInstanceStatusTransitionEventResolutionFinalizeProcessing { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionFollowup? TaskInstanceStatusTransitionEventResolutionFollowup { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionOption? TaskInstanceStatusTransitionEventResolutionOption { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionText? TaskInstanceStatusTransitionEventResolutionText { get; set; }
}
