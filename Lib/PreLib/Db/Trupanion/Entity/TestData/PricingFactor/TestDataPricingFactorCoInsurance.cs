namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorCoInsurance
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public string? CoInsuranceRate { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
