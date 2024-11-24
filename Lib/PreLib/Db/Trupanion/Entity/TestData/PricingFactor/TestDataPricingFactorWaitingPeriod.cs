namespace Database.Trupanion.Entity.TestData.PricingFactor
{
    public  class TestDataPricingFactorWaitingPeriod
    {
        public int Id { get; set; }
        public int RateCardStateId { get; set; }
        public int WaitingPeriodType { get; set; }
        public double Factor { get; set; }

        public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
    }
}
