namespace Database.Trupanion.Entity.TestData.WorkflowSystemTest;

public  class TestDataWorkflowSystemTestTestDefinitionStep
{
    public int Id { get; set; }
    public int TestDefinitionId { get; set; }
    public int? OperationId { get; set; }
    public Guid? ProcessDefinitionId { get; set; }
    public Guid? WellknownTaskId { get; set; }
    public int? EntityId { get; set; }
    public int? NewStatus { get; set; }
    public long DurationCeilingInMilliseconds { get; set; }
    public bool? StepPassed { get; set; }
    public string? ProcessType { get; set; }
    public string? Description { get; set; }

    public virtual TestDataWorkflowSystemTestTestDefinition? TestDefinition { get; set; }
    public virtual List<TestDataWorkflowSystemTestTestInstanceDetail> TestInstanceDetails { get; set; } = new();
}
