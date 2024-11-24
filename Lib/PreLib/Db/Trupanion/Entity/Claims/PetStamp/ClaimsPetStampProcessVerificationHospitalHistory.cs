namespace Database.Trupanion.Entity.Claims.PetStamp;

public  class ClaimsPetStampProcessVerificationHospitalHistory
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ProcessVerificationHistoryId { get; set; }
    public int HospitalId { get; set; }

    public virtual ClaimsPetStampProcessVerificationHistory? ProcessVerificationHistory { get; set; }
}
