namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboSelectedWorkingPet
{
    public int Id { get; set; }
    public int EnrollmentPetDataId { get; set; }
    public int WorkingPetId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual PPDboEnrollmentPetDatum? EnrollmentPetData { get; set; }
}
