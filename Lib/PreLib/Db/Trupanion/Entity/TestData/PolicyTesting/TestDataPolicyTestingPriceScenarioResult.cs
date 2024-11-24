namespace Database.Trupanion.Entity.TestData.PolicyTesting;

public class TestDataPolicyTestingPriceScenarioResult
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public DateTime RunDate { get; set; }
    public int Engineversion { get; set; }
    public bool TestPassed { get; set; }
    public string? Name { get; set; }
    public decimal? RateCardPremium { get; set; }
    public decimal? SprocPremium { get; set; }
    public string? FactorSource { get; set; }
    public double BaseRate { get; set; }
    public double GeoFactor { get; set; }
    public double AgeFactor { get; set; }
    public double BreedFactor { get; set; }
    public double GenderFactor { get; set; }
    public double SpayFactor { get; set; }
    public double RecoveryFactor { get; set; }
    public double DeductibleFactor { get; set; }
}
