namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorRateCard
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime PublishDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public virtual List<TestDataPricingFactorRateCardState> RateCardStates { get; set; } = new();
}
