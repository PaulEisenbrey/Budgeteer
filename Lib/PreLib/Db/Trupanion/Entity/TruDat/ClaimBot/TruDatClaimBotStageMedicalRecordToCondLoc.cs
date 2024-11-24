namespace Database.Trupanion.Entity.TruDat.ClaimBot;

public class TruDatClaimBotStageMedicalRecordToCondLoc
{
    public long? MedicalRecordId { get; set; }
    public long? PetPolicyId { get; set; }
    public long? ClaimId { get; set; }
    public long? ConditionId { get; set; }
    public long? LocationId { get; set; }
    public long? SysChangeVersion { get; set; }
    public string? Etlaction { get; set; }
}
