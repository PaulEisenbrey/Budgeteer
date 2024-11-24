namespace Database.Trupanion.Entity.TestData.PricingFactor
{
    public  class TestDataPricingFactorRiderB
    {
        public int Id { get; set; }
        public int RateCardStateId { get; set; }
        public bool IsSelected { get; set; }
        public double Factor { get; set; }

        public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
    }
}
