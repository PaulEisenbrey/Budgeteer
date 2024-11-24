namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboTwilioSmsChannelTemplate
{
    public Guid Id { get; set; }
    public Guid TwilioSmsChannelId { get; set; }
    public int TemplateId { get; set; }

    public virtual CommServicesDboTwilioSmsChannel? TwilioSmsChannel { get; set; }
}
