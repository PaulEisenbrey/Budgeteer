namespace Database.Trupanion.Entity.TestData.WorkflowSystemTest;

public  class TestDataWorkflowSystemTestTestInstanceDetail
{
    public int Id { get; set; }
    public int TestInstanceId { get; set; }
    public int TestDefinitionStepId { get; set; }
    public DateTime StartTime { get; set; }
    public int Duration { get; set; }
    public bool Passed { get; set; }
    public string? Description { get; set; }

    public virtual TestDataWorkflowSystemTestTestDefinitionStep? TestDefinitionStep { get; set; }
    public virtual TestDataWorkflowSystemTestTestInstance? TestInstance { get; set; }
}
