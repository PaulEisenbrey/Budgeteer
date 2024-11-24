namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAttachmentsForPet
{
    public int Id { get; set; }
    public int AttachmentId { get; set; }
    public int? EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int? AssignedUserid { get; set; }
    public int? UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? Pagenumber { get; set; }
    public int PetId { get; set; }
}
