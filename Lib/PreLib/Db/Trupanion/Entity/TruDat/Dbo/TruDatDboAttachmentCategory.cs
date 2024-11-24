namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboAttachment> Attachments { get; set; } = new();
    public virtual List<TruDatDboFaxLineNumber> FaxLineNumbers { get; set; } = new();
}
