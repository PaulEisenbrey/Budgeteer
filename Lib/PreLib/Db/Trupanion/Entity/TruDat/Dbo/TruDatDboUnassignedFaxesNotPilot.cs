namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUnassignedFaxesNotPilot
{
    public int AttachmentId { get; set; }
    public string? ProtusFaxId { get; set; }
    public string? FileName { get; set; }
    public string? Name { get; set; }
    public string? Number { get; set; }
    public int? FaxLineNumberId { get; set; }
    public DateTime? ReceivedTime { get; set; }
    public int? NumOfPages { get; set; }
    public string? SendingFaxNumber { get; set; }
    public int? InsertUserId { get; set; }
}
