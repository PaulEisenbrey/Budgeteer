using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimWizardTracking : EntityIntId
{
    public int AssessmentDataId { get; set; }

    public int SectionId { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateCompleted { get; set; }

    public bool? OverrideWarning { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int ChangeUserId { get; set; }

}
