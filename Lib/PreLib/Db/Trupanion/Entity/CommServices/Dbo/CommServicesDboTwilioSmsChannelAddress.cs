namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboTwilioSmsChannelAddress
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public Guid TwilioSmsChannelId { get; set; }
}
