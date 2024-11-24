namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorExpenseRateFactor
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public string? Name { get; set; }
    public double Factor { get; set; }
    public bool? IsDog { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
