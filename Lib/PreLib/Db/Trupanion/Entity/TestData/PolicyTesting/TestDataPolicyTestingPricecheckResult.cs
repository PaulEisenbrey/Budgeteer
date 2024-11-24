namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingPricecheckResult
{
    public int Id { get; set; }
    public int PricecheckScenarioId { get; set; }
    public bool TestPassed { get; set; }
    public decimal? RateCardPremium { get; set; }
    public decimal? SprocPremium { get; set; }
    public string? Breed { get; set; }
    public int? BreedId { get; set; }
    public int EngineVersion { get; set; }
    public string? ResultMessage { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string? SystemError { get; set; }

    public virtual TestDataPolicyTestingPricecheckScenario? PricecheckScenario { get; set; }
    public virtual List<TestDataPolicyTestingPricecheckResultFactor> PricecheckResultFactors { get; set; } = new();
}
