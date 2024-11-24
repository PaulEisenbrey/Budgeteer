namespace Database.Trupanion.Entity.Workflow;

public class WFDboStateTransitionResolutionGroup
{
    public WFDboStateTransitionResolutionGroup()
    {
        ProcessDefinitions = new HashSet<WFDboProcessDefinition>();
        StateTransitionResolutionGroupMembers = new HashSet<WFDboStateTransitionResolutionGroupMember>();
        TaskDefinitions = new HashSet<WFDboTaskDefinition>();
    }

    public int Id { get; set; }
    public long? VersionId { get; set; }
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboProcessDefinition> ProcessDefinitions { get; set; }
    public virtual ICollection<WFDboStateTransitionResolutionGroupMember> StateTransitionResolutionGroupMembers { get; set; }
    public virtual ICollection<WFDboTaskDefinition> TaskDefinitions { get; set; }
}
