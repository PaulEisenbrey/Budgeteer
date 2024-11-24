namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEventResolutionOption
{
    public WFDboProcessInstanceStatusTransitionEventResolutionOption()
    {
        ProcessInstanceStatusTransitionEventResolutionOptionSelections = new HashSet<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection>();
    }

    public int ProcessInstanceStatusTransitionEventResolutionId { get; set; }

    public virtual WFDboProcessInstanceStatusTransitionEventResolution? ProcessInstanceStatusTransitionEventResolution { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection> ProcessInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
}
