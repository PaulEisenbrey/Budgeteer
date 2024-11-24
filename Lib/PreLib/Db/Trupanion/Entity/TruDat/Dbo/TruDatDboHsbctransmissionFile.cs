namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboHsbctransmissionFile
{
    public int Id { get; set; }
    public string? FileName { get; set; }
    public bool? IsManual { get; set; }
    public bool? IsUploaded { get; set; }
    public int? RecordCount { get; set; }
    public int? DebitCount { get; set; }
    public decimal? DebitTotal { get; set; }
    public int? CreditCount { get; set; }
    public decimal? CreditTotal { get; set; }
    public DateTime DateCreated { get; set; }
    public string? CreatedBy { get; set; }
    public string? Comments { get; set; }
    public bool? IsConfirmationReceived { get; set; }
    public bool? IsFileRejected { get; set; }
}
