namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphxItemSelection
{
    public int Id { get; set; }
    public int PphxId { get; set; }
    public int PphxItemId { get; set; }

    public virtual ClaimsPetStampPphx? Pphx { get; set; }
    public virtual ClaimsPetStampPphxItem? PphxItem { get; set; }
}
