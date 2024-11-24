namespace Database.Trupanion.Entity.TestData.WorkflowSystemTest;

public  class TestDataWorkflowSystemTestTestDefinition
{
    public int Id { get; set; }
    public int UserMockTypeId { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
    public bool ShouldPass { get; set; }

    public virtual TestDataWorkflowSystemTestUserMockType? UserMockType { get; set; }
    public virtual List<TestDataWorkflowSystemTestTestDefinitionStep> TestDefinitionSteps { get; set; } = new();
    public virtual List<TestDataWorkflowSystemTestTestInstance> TestInstances { get; set; } = new();
}
