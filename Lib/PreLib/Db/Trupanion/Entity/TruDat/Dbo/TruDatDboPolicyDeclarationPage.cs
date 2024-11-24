namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyDeclarationPage
{
    public int Id { get; set; }
    public int? PetId { get; set; }
    public string? FileName { get; set; }
    public string? DocumentId { get; set; }
    public DateTime Inserted { get; set; }
    public int? AttachmentId { get; set; }
    public int OwnerId { get; set; }
}
