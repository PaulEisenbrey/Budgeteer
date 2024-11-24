namespace Database.Trupanion.Entity.Workflow;

public class WFDboStateTransitionResolutionGroupMember
{
    public int Id { get; set; }
    public int StateTransitionResolutionGroupId { get; set; }
    public int InputConfigurationId { get; set; }
    public int TransitionFromStatusId { get; set; }
    public int TransitionToStatusId { get; set; }
    public int ResolutionOrder { get; set; }
    public bool IsRequired { get; set; }
    public bool? IsVisibleByDefault { get; set; }

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
    public virtual WFDboStateTransitionResolutionGroup? StateTransitionResolutionGroup { get; set; }
}
