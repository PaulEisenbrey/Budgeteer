namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryContent
{
    public int Id { get; set; }
    public int DeliveryInfoId { get; set; }
    public int Section { get; set; }
    public int Source { get; set; }
    public int Type { get; set; }
    public string? Content { get; set; }

    public virtual CommServicesDboDeliveryInfo? DeliveryInfo { get; set; }
}
