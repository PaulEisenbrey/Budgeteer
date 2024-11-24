namespace Database.Trupanion.Entity.TestData.RateCardConfig;

public  class TestDataRateCardConfigRateCardSection
{
    public int Id { get; set; }
    public int CsRateCardTabId { get; set; }
    public string? RateCardSectionName { get; set; }

    public virtual TestDataRateCardConfigRateCardTab? CsRateCardTab { get; set; }
    public virtual List<TestDataRateCardConfigRateCardColumn> RateCardColumns { get; set; } = new();
    public virtual List<TestDataRateCardConfigRateCardRowset> RateCardRowsets { get; set; } = new();
}
