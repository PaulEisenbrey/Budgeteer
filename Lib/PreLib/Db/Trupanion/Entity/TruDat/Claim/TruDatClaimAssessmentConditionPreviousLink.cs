using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAssessmentConditionPreviousLink : EntityIntId
{
    public int MedicalRecordId { get; set; }

    public int EntityTypeId { get; set; }

    public int EntityId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}
