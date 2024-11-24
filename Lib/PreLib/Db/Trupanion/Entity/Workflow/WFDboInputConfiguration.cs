namespace Database.Trupanion.Entity.Workflow;

public class WFDboInputConfiguration
{
    public WFDboInputConfiguration()
    {
        InputConfigurationOptionGroupItems = new HashSet<WFDboInputConfigurationOptionGroupItem>();
        ProcessInstanceStatusTransitionEventResolutions = new HashSet<WFDboProcessInstanceStatusTransitionEventResolution>();
        ProcessInstanceStatusTransitionMaps = new HashSet<WFDboProcessInstanceStatusTransitionMap>();
        StateTransitionResolutionGroupMembers = new HashSet<WFDboStateTransitionResolutionGroupMember>();
        TaskInstanceStatusTransitionEventResolutions = new HashSet<WFDboTaskInstanceStatusTransitionEventResolution>();
        TaskInstanceStatusTransitionMaps = new HashSet<WFDboTaskInstanceStatusTransitionMap>();
    }

    public int Id { get; set; }
    public long? VersionId { get; set; }

    public virtual WFDboInputConfigurationFollowup? InputConfigurationFollowup { get; set; }
    public virtual WFDboInputConfigurationOptionGroup? InputConfigurationOptionGroup { get; set; }
    public virtual WFDboInputConfigurationText? InputConfigurationText { get; set; }
    public virtual ICollection<WFDboInputConfigurationOptionGroupItem> InputConfigurationOptionGroupItems { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionEventResolution> ProcessInstanceStatusTransitionEventResolutions { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionMap> ProcessInstanceStatusTransitionMaps { get; set; }
    public virtual ICollection<WFDboStateTransitionResolutionGroupMember> StateTransitionResolutionGroupMembers { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolution> TaskInstanceStatusTransitionEventResolutions { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionMap> TaskInstanceStatusTransitionMaps { get; set; }
}
