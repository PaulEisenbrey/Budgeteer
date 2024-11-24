namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPolicy
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public string? Reference { get; set; }
    public int Type { get; set; }
    public decimal? Premium { get; set; }
    public int Status { get; set; }
    public DateTime? InceptionDate { get; set; }
    public DateTime? TermsDate { get; set; }
    public Guid Ref { get; set; }
    public DateTime ModifiedDateTime { get; set; }
    public Guid ExtRef { get; set; }
    public string? PromoCode { get; set; }
    public Guid BatchId { get; set; }
}
