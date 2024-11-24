namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingState
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public bool IsLegacy { get; set; } = false;
    public int CountryCode { get; set; }
}
