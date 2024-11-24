namespace Database.Trupanion.Entity.TestData.PricingFactor;

public  class TestDataPricingFactorHospital
{
    public int Id { get; set; }
    public int RateCardStateId { get; set; }
    public string? GeoRegion { get; set; }
    public string? HospitalName { get; set; }
    public double HospitalGroup { get; set; }
    public double Factor { get; set; }

    public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
}
