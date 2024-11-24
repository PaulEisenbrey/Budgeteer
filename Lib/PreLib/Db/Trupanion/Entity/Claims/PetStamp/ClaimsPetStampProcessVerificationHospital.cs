namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcessVerificationHospital
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int ProcessVerificationId { get; set; }
    public int HospitalId { get; set; }

    public virtual ClaimsPetStampProcessVerification? ProcessVerification { get; set; }
}
