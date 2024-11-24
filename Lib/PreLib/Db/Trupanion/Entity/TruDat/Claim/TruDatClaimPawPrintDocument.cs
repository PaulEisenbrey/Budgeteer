using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPawPrintDocument : EntityIntId
{
    public int PetId { get; set; }

    public string? Name { get; set; }

    public string? Comment { get; set; }

    public string? Extension { get; set; }

    public byte[]? Body { get; set; }

    public DateTime Inserted { get; set; }

    public int? ChangeUserId { get; set; }

}
