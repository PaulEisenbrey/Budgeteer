namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphxItemSelectionHistory
{
    public int Id { get; set; }
    public int PphxId { get; set; }
    public int PphxItemId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }

    public virtual ClaimsPetStampPphx? Pphx { get; set; }
    public virtual ClaimsPetStampPphxItem? PphxItem { get; set; }
}
