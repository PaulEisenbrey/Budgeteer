namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboFixThese
{
    public int PetPolicyId { get; set; }
    public DateTime OriginalPolicyDate { get; set; }
    public string? CampaignCode { get; set; }
    public int OwnerId { get; set; }
    public bool? MustBeAddPet { get; set; }
    public bool? Fixed { get; set; }
}
