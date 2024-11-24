namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboDmsClaimPetInfo
{
    public int ClaimId { get; set; }
    public int PetPolicyId { get; set; }
    public int PetId { get; set; }
    public string? PetName { get; set; }
    public int OwnerId { get; set; }
}
