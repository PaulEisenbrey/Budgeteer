using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMedicalRecord : EntityIntId
{
    public DateTime? ServiceDate { get; set; }

    public int RecordTypeId { get; set; }

    public bool Active { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int? EntityId { get; set; }

    public int? EntityTypeId { get; set; }

    public int? PageNumber { get; set; }

}
