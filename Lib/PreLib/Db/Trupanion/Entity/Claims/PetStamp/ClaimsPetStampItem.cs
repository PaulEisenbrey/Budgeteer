namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampItem
{
    public ClaimsPetStampItem()
    {
        ProcessVerifications = new HashSet<ClaimsPetStampProcessVerification>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ClaimsPetStampProcessVerification> ProcessVerifications { get; set; }
}
