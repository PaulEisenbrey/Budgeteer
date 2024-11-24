namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEventResolution
{
    public int Id { get; set; }
    public int ProcessInstanceEventId { get; set; }
    public int? InputConfigurationId { get; set; }

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
    public virtual WFDboProcessInstanceEvent? ProcessInstanceEvent { get; set; }
    public virtual WFDboProcessInstanceStatusTransitionEventResolutionAsync? ProcessInstanceStatusTransitionEventResolutionAsync { get; set; }
    public virtual WFDboProcessInstanceStatusTransitionEventResolutionOption? ProcessInstanceStatusTransitionEventResolutionOption { get; set; }
    public virtual WFDboProcessInstanceStatusTransitionEventResolutionText? ProcessInstanceStatusTransitionEventResolutionText { get; set; }
}
