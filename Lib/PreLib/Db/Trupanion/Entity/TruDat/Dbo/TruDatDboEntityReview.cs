namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityReview
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int UserId { get; set; }
    public string? Role { get; set; }
    public Guid BatchId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
