namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboCommunicationStatus
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<CommServicesDboCommunication> Communications { get; set; } = new();
}
