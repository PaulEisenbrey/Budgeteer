namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorDeductibleFactor
{
    public int Id { get; set; }
    public DateTime ActiveDate { get; set; }
    public int CountryCode { get; set; }
    public int Deductible { get; set; }
    public double Factor { get; set; }
    public int RateCardStateId { get; set; }
}
