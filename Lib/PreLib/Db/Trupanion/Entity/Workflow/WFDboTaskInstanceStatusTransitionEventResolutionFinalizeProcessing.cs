namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing
{
    public WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing()
    {
        TaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstances = new HashSet<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance>();
    }

    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance> TaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstances { get; set; }
}
