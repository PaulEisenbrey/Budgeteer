namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentFaxInfo
{
    public int AttachmentId { get; set; }
    public string? ProtusFaxId { get; set; }
    public int? NumOfPages { get; set; }
    public int? Duration { get; set; }
    public string? SendingFaxNumber { get; set; }
    public DateTime? ReceivedTime { get; set; }
    public int? FaxLineNumberId { get; set; }
    public bool Assigned { get; set; }
    public int? ClinicId { get; set; }
    public int ExecutionId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Udpated { get; set; }
    public int? RightFaxId { get; set; }

    public virtual TruDatDboAttachment? Attachment { get; set; }
    public virtual TruDatDboFaxLineNumber? FaxLineNumber { get; set; }
}
