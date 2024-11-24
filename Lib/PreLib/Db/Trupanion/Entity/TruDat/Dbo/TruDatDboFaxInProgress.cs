namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboFaxInProgress
{
    public int Id { get; set; }
    public int SessionId { get; set; }
    public int AttachmentId { get; set; }
    public string? ProtusFaxId { get; set; }
    public string? FileName { get; set; }
    public string? ReceivingLine { get; set; }
    public string? ReceivingNumber { get; set; }
    public int? ClinicId { get; set; }
    public string? ClinicName { get; set; }
    public int Priority { get; set; }
    public bool CurrentlyActive { get; set; }
    public DateTime Inserted { get; set; }
    public string? SendingFaxNumber { get; set; }
    public int? NumOfPages { get; set; }

    public virtual TruDatDboSession? Session { get; set; }
}
