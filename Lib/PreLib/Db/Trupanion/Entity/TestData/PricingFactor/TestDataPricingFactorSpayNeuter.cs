namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorSpayNeuter
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public bool IsSpayedOrNeutered { get; set; }
    public int GenderVal { get; set; }
    public bool IsBreedingFemale { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
