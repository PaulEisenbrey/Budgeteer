namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryMedium
{
    public CommServicesDboDeliveryMedium()
    {
        DeliveryInfos = new HashSet<CommServicesDboDeliveryInfo>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<CommServicesDboDeliveryInfo> DeliveryInfos { get; set; }
}
