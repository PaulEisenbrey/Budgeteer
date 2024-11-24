namespace Database.Trupanion.Entity.TestData.RateCardConfig;

public  class TestDataRateCardConfigRateCardRowset
{
    public int Id { get; set; }
    public int RsRateCardSectionId { get; set; }
    public string? RatecardRowsetName { get; set; }
    public int RatecardRowsetStart { get; set; }
    public int RatecardRowsetEnd { get; set; }

    public virtual TestDataRateCardConfigRateCardSection? RsRateCardSection { get; set; }
}
