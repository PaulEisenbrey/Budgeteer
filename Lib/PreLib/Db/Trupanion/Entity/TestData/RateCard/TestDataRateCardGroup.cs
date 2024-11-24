namespace Database.Trupanion.Entity.TestData.RateCard;

public  class TestDataRateCardGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int TabId { get; set; }

    public virtual TestDataRateCardGroup? Tab { get; set; }
    public virtual List<TestDataRateCardColumnSet> ColumnSets { get; set; } = new();
    public virtual List<TestDataRateCardGroup> InverseTab { get; set; } = new();
    public virtual List<TestDataRateCardRowSet> RowSets { get; set; } = new();
}
