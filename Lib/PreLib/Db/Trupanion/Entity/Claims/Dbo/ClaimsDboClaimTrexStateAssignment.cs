namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimTrexStateAssignment
{
    public int Id { get; set; }
    public int StateId { get; set; }
    public Guid UserId { get; set; }
    public string? EmailGroup { get; set; }
    public string? EmailNote { get; set; }
}
