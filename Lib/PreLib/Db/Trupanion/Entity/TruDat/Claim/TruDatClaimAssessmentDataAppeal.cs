using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAssessmentDataAppeal : EntityIntId
{
    public int AssessmentDataId { get; set; }

    public int? ContactDVMTypeId { get; set; }

    public string? ContactDestination { get; set; }

    public string? AppealingDVMName { get; set; }

    public int? MasterAssessmentDataId { get; set; }

    public bool? Overturn { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Inserted { get; set; }

    public int ChangeUserId { get; set; }

}
