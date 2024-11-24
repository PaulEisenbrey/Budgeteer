namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationInitialLoadType
{
    public int Id { get; set; }
    public string? Description { get; set; }

    public virtual List<TestDataWorkflowAutomationTestSection> TestSections { get; set; } = new();
}
