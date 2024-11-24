namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboTwilioSmsChannelAction
{
    public CommServicesDboTwilioSmsChannelAction()
    {
        TwilioSmsChannelActionResponses = new HashSet<CommServicesDboTwilioSmsChannelActionResponse>();
    }

    public int Id { get; set; }
    public int ActionId { get; set; }
    public string? Keywords { get; set; }
    public string? Response { get; set; }
    public Guid TwilioSmsChannelId { get; set; }

    public virtual ICollection<CommServicesDboTwilioSmsChannelActionResponse> TwilioSmsChannelActionResponses { get; set; }
}
