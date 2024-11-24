namespace Database.Trupanion.Entity.TestData.RateCardConfig;

public  class TestDataRateCardConfigRateCardColumn
{
    public int Id { get; set; }
    public int CcRateCardSectionId { get; set; }
    public string? RateCardColumnName { get; set; }
    public int RateCardColumnValue { get; set; }

    public virtual TestDataRateCardConfigRateCardSection? CcRateCardSection { get; set; }
}
