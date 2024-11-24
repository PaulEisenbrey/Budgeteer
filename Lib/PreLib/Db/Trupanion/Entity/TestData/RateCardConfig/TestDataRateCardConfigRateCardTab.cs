namespace Database.Trupanion.Entity.TestData.RateCardConfig;

public  class TestDataRateCardConfigRateCardTab
{
    public int Id { get; set; }
    public string? RateCardTabName { get; set; }

    public virtual List<TestDataRateCardConfigRateCardSection> RateCardSections { get; set; } = new();
}
