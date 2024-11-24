namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboTwilioSmsChannelActionResponse
{
    public int Id { get; set; }
    public int TwilioSmsChannelActionId { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? Response { get; set; }

    public virtual CommServicesDboTwilioSmsChannelAction? TwilioSmsChannelAction { get; set; }
}
