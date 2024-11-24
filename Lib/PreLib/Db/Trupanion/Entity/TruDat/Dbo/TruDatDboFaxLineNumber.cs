namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboFaxLineNumber
{
    public int Id { get; set; }
    public string? Number { get; set; }
    public int FaxLineId { get; set; }
    public int? DefaultCategoryId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? CountryId { get; set; }

    public virtual TruDatDboAttachmentCategory? DefaultCategory { get; set; }
    public virtual TruDatDboFaxLine? FaxLine { get; set; }
    public virtual List<TruDatDboAttachmentFaxInfo> AttachmentFaxInfos { get; set; } = new();
}
