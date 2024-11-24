namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorGenderFactor
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public int GenderVal { get; set; }
    public int SpeciesVal { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
