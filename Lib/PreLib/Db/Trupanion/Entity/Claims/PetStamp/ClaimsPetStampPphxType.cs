namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampPphxType
{
    public ClaimsPetStampPphxType()
    {
        Pphxes = new HashSet<ClaimsPetStampPphx>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ClaimsPetStampPphx> Pphxes { get; set; }
}
