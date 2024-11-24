namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimAutoAdjudicationRunSetting
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TimeoutInSeconds { get; set; }
    public bool ProcessInRealtime { get; set; }
    public string? ClaimSubmitter { get; set; }
}
