namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimWorkflowViewStatusArchive
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }
}
