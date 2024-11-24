namespace Database.Trupanion.Entity.TestData.WorkflowSystemTest;

public  class TestDataWorkflowSystemTestUserMockType
{
    public int Id { get; set; }
    public int EntityId { get; set; }
    public string? Description { get; set; }

    public virtual List<TestDataWorkflowSystemTestTestDefinition> TestDefinitions { get; set; } = new();
}
