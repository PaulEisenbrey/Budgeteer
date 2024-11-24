namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorBreedFactor
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public int BreedId { get; set; }
    public int SpeciesVal { get; set; }
    public string? Name { get; set; }
    public string? BreedRollup { get; set; }
    public int BreedGroup { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
