namespace Database.Trupanion.Entity.Workflow;

public class WFDboActiveUserTaskInstanceForAssignment
{
    public int Id { get; set; }
    public int ProcessDefinitionFlowId { get; set; }
    public int ProcessInstanceId { get; set; }
    public int TaskInstancePriorityId { get; set; }
    public DateTime CreatedOn { get; set; }
}
