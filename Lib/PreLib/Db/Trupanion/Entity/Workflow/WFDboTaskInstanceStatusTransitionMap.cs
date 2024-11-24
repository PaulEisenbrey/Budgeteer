namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionMap
{
    public int Id { get; set; }
    public int TaskInstanceStatusId { get; set; }
    public int CanTransitionToTaskInstanceStatusId { get; set; }
    public bool StandardTransition { get; set; }
    public string TransitionVerb { get; set; } = "";
    public bool StoppingTransition { get; set; }
    public bool UserTransition { get; set; }
    public int? RequiredInputConfigurationId { get; set; }

    public virtual WFDboTaskInstanceStatus? CanTransitionToTaskInstanceStatus { get; set; }
    public virtual WFDboInputConfiguration? RequiredInputConfiguration { get; set; }
    public virtual WFDboTaskInstanceStatus? TaskInstanceStatus { get; set; }
}
