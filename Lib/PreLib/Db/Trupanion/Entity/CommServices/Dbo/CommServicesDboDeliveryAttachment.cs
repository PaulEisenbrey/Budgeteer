namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboDeliveryAttachment
{
    public int Id { get; set; }
    public int DeliveryInfoId { get; set; }
    public string? AttachmentContents { get; set; }
    public int AttachmentSource { get; set; }

    public virtual CommServicesDboDeliveryInfo? DeliveryInfo { get; set; }
}
