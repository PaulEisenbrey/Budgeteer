namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboTwilioSmsChannel
{
    public CommServicesDboTwilioSmsChannel()
    {
        TwilioSmsChannelTemplates = new HashSet<CommServicesDboTwilioSmsChannelTemplate>();
    }

    public Guid Id { get; set; }
    public int TwilioSmsChannelTypeId { get; set; }
    public string? From { get; set; }
    public string? StatusCallbackUrl { get; set; }
    public int CampaignCategoryId { get; set; }
    public int TwilioAccountId { get; set; }

    public virtual ICollection<CommServicesDboTwilioSmsChannelTemplate> TwilioSmsChannelTemplates { get; set; }
}
