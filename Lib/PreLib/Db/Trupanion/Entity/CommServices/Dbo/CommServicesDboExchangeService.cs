namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboExchangeService
{
    public CommServicesDboExchangeService()
    {
        Mailboxes = new HashSet<CommServicesDboMailbox>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string? Url { get; set; }

    public virtual ICollection<CommServicesDboMailbox> Mailboxes { get; set; }
}
