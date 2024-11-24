namespace Database.Trupanion.Entity.CommServices.Recipient;

public  class CommServicesRecipientRecipientType
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<CommServicesRecipientRecipient> Recipients { get; set; } = new();
}
