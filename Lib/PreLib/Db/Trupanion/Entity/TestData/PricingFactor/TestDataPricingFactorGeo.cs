namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorGeo
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public string? ProvinceOrZip { get; set; }
    public string? ZipCode { get; set; }
    public string? State { get; set; }
    public int CountryGroup { get; set; }
    public double Factor { get; set; }
    public string? RegionName { get; set; }
    public string? RegionDetailName { get; set; }
    public decimal? UpdatedGroup { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
