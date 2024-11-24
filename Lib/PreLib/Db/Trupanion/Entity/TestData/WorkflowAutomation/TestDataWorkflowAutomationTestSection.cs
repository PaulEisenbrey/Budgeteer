namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationTestSection
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int InitialLoadTypeId { get; set; }

    public virtual TestDataWorkflowAutomationInitialLoadType? InitialLoadType { get; set; }
    public virtual List<TestDataWorkflowAutomationTest> Tests { get; set; } = new();
}
