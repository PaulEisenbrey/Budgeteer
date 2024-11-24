namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentDocType
{
    public int Id { get; set; }
    public string? Type { get; set; }

    public virtual List<TruDatDboAttachment> Attachments { get; set; } = new();
}
