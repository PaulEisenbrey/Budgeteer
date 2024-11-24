namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionMap
{
    public int Id { get; set; }
    public int ProcessInstanceStatusId { get; set; }
    public int CanTransitionToProcessInstanceStatusId { get; set; }
    public string TransitionVerb { get; set; } = "";
    public bool UserTransition { get; set; }
    public int? RequiredInputConfigurationId { get; set; }

    public virtual WFDboProcessInstanceStatus? CanTransitionToProcessInstanceStatus { get; set; }
    public virtual WFDboProcessInstanceStatus? ProcessInstanceStatus { get; set; }
    public virtual WFDboInputConfiguration? RequiredInputConfiguration { get; set; }
}
