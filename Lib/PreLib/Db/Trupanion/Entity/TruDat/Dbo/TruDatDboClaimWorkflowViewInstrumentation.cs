namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimWorkflowViewInstrumentation
{
    public int Id { get; set; }
    public int? UserId { get; set; }
    public bool? Greyhound { get; set; }
    public bool? PreAppClaims { get; set; }
    public bool? ClaimsExpress { get; set; }
    public int? ClaimStatus { get; set; }
    public DateTime? StartedOn { get; set; }
    public DateTime? CompletedOn { get; set; }
}
