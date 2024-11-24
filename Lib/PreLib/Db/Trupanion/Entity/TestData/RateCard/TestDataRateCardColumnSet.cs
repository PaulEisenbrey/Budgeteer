namespace Database.Trupanion.Entity.TestData.RateCard;

public  class TestDataRateCardColumnSet
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public int StartColumn { get; set; }
    public int EndColumn { get; set; }

    public virtual TestDataRateCardGroup? Group { get; set; }
}
