using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimWizardSection : EntityIntId
{
    public string? Name { get; set; }

    public int? SectionRank { get; set; }

    public int WizardType { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int ChangeUserId { get; set; }

    public bool? Optional { get; set; }

}
