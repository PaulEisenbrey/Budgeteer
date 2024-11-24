namespace Database.Trupanion.Entity.Workflow;

public class WFDboInputConfigurationOptionItem
{
    public WFDboInputConfigurationOptionItem()
    {
        InputConfigurationOptionGroupItems = new HashSet<WFDboInputConfigurationOptionGroupItem>();
        ProcessInstanceStatusTransitionEventResolutionOptionSelections = new HashSet<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection>();
        TaskInstanceStatusTransitionEventResolutionOptionSelections = new HashSet<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection>();
    }

    public int Id { get; set; }
    public string SelectionText { get; set; } = "";
    public long? VersionId { get; set; }

    public virtual ICollection<WFDboInputConfigurationOptionGroupItem> InputConfigurationOptionGroupItems { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection> ProcessInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection> TaskInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
}
