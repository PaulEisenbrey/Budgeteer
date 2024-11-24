using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimWizardOverride : EntityIntId
{
    public int WizardTrackingId { get; set; }

    public int? AuditTypeId { get; set; }

    public string? Comments { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int ChangeUserId { get; set; }

}
