namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorWorkingGroup
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public int GroupId { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
