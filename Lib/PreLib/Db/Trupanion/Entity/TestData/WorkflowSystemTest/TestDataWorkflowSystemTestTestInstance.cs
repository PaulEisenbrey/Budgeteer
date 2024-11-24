namespace Database.Trupanion.Entity.TestData.WorkflowSystemTest;

public  class TestDataWorkflowSystemTestTestInstance
{
    public int Id { get; set; }
    public int TestDefinitionId { get; set; }
    public DateTime RunDate { get; set; }

    public virtual TestDataWorkflowSystemTestTestDefinition? TestDefinition { get; set; }
    public virtual List<TestDataWorkflowSystemTestTestInstanceDetail> TestInstanceDetails { get; set; } = new();
}
