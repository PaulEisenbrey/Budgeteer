namespace Database.Trupanion.Entity.TestData.RateCard;

public  class TestDataRateCardRowSet
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public int StartRow { get; set; }
    public int EndRow { get; set; }

    public virtual TestDataRateCardGroup? Group { get; set; }
}
