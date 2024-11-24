namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentsDupFaxis
{
    public int Id { get; set; }
    public string? FileName { get; set; }
    public int InputTypeId { get; set; }
    public int? CategoryId { get; set; }
    public int? DocTypeId { get; set; }
    public string? Source { get; set; }
    public string? Description { get; set; }
    public string? SalesForceId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
