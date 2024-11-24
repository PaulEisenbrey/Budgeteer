namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorAgeFactor
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public int AgeVal { get; set; }
    public double Factor { get; set; }
    public int? Species { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
