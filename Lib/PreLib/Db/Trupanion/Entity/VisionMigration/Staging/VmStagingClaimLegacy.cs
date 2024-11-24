namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimLegacy
{
    public int Id { get; set; }
    public string? Reference { get; set; }
    public string? FnolDescription { get; set; }
    public decimal? Amount { get; set; }
    public int Status { get; set; }
    public decimal? TotalPaid { get; set; }
    public bool? TriggeredRequest { get; set; }
    public DateTimeOffset? CreatedDate { get; set; }
    public int? ReassessParentId { get; set; }
    public bool? IsReassessing { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? RejectionOverriddenBy { get; set; }
    public DateTime? DateOfLoss { get; set; }
    public int? DateOfDeath { get; set; }
    public DateTime? TreatmentStartDate { get; set; }
    public DateTime? TreatmentEndDate { get; set; }
    public bool? IgnoreNoPolicyLimits { get; set; }
    public bool? AcknowledgementGenerated { get; set; }
    public DateTimeOffset? StampDownDateTime { get; set; }
    public int FormType { get; set; }
    public bool? PreAuthorisationCompleted { get; set; }
    public int? ReassessmentReasonId { get; set; }
    public int PayeeType { get; set; }
    public DateTimeOffset? ClosedDateTime { get; set; }
    public int? ReassessmentOutcomeId { get; set; }
    public int BrandId { get; set; }
    public Guid? StampDownById { get; set; }
    public Guid? ClosedById { get; set; }
    public int Source { get; set; }
    public int? PetId { get; set; }
    public string? AdjusterComment { get; set; }
    public int? LegacyClaimId { get; set; }
    public bool? HospitalNotificationGenerated { get; set; }
    public int PredictionFlags { get; set; }
    public int? SettledReason { get; set; }
    public int? NextStatus { get; set; }
    public int? LinkedGroupId { get; set; }
    public Guid? AssessedById { get; set; }
    public DateTimeOffset? AssessedDateTime { get; set; }
    public bool? Reassessed { get; set; }
    public int? FastTrackReasonId { get; set; }
    public int? EscalateReasonId { get; set; }
    public bool? MissingInfoCompleted { get; set; }
    public Guid? BatchId { get; set; }
    public bool? Migrated { get; set; }
}
