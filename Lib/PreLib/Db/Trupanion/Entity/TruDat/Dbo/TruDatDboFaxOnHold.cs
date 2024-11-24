namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboFaxOnHold
{
    public int Id { get; set; }
    public int AttachmentId { get; set; }
    public int HoldStatus { get; set; }
    public string? ProtusFaxId { get; set; }
    public string? HoldAttacher { get; set; }
    public string? ReceivingLine { get; set; }
    public string? ReceivingNumber { get; set; }
    public string? ClinicName { get; set; }
    public DateTime Inserted { get; set; }
}
