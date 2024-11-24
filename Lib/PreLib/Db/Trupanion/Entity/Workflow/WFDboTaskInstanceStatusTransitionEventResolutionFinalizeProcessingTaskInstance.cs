namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance
{
    public int Id { get; set; }
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public int TaskInstanceId { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing? TaskInstanceStatusTransitionEventResolution { get; set; }
}
