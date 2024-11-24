namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingScenarioResult
{
    public int Id { get; set; }
    public int? ResultId { get; set; }
    public DateTime RunDate { get; set; }
    public bool? TestPassed { get; set; }
    public decimal? RateCardPremium { get; set; }
    public decimal? SprocPremium { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public string? ResultMessage { get; set; }
}
