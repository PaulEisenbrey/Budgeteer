namespace Database.Trupanion.Entity.TestData.TestHarness;

public  class TestDataTestHarnessTest
{
    public int Id { get; set; }
    public string? TestName { get; set; }
    public string? TestPath { get; set; }
    public string? CommandLineParams { get; set; }
    public string? OneTimeCommandLine { get; set; }
    public int TestStatusId { get; set; }
    public DateTime FirstRun { get; set; }
    public DateTime? LastRun { get; set; }
    public int MinutesBetweenRuns { get; set; }
}
