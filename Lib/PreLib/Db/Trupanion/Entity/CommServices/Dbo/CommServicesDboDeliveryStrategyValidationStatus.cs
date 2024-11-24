namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryStrategyValidationStatus
{
    public CommServicesDboDeliveryStrategyValidationStatus()
    {
        DeliveryInfos = new HashSet<CommServicesDboDeliveryInfo>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool RequiresUserIntervention { get; set; }

    public virtual ICollection<CommServicesDboDeliveryInfo> DeliveryInfos { get; set; }
}
