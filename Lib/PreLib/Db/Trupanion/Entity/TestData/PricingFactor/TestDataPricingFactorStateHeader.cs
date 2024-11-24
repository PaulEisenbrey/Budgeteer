namespace Database.Trupanion.Entity.TestData.PricingFactor
{
    public  class TestDataPricingFactorStateHeader
    {
        public int Id { get; set; }
        public int RateCardStateId { get; set; }
        public int AdminFee { get; set; }
        public double Factor { get; set; }
        public DateTime BaseEffectiveDate { get; set; }
        public bool? IsCapped { get; set; }
        public int? RateChangeNotification { get; set; }

        public virtual TestDataPricingFactorRateCardState? RateCardState { get; set; }
    }
}
