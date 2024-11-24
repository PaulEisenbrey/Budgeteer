namespace Database.Trupanion.Entity.CommServices.Campaign;

public  class CommServicesCpgCampaign
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }
    public Guid? TopicId { get; set; }
    public string? ConfigData { get; set; }
}
