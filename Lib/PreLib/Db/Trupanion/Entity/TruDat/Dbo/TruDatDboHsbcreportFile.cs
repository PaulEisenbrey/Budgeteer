namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboHsbcreportFile
{
    public int HsbcreportFileId { get; set; }
    public string? FileName { get; set; }
    public DateTime? ReportDateTime { get; set; }
    public string? ReportDescription { get; set; }
    public DateTime? DateCreated { get; set; }
}
