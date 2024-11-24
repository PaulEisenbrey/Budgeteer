namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationTaskType
{
    public int Id { get; set; }
    public int TaskTypeValue { get; set; }
    public string? Description { get; set; }

    public virtual List<TestDataWorkflowAutomationAction> Actions { get; set; } = new();
}
