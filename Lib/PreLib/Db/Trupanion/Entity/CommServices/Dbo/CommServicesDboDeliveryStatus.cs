namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryStatus
{
    public CommServicesDboDeliveryStatus()
    {
        DeliveryInfos = new HashSet<CommServicesDboDeliveryInfo>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<CommServicesDboDeliveryInfo> DeliveryInfos { get; set; }
}
