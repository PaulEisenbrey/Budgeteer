namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboEnrollmentDataAssociation
{
    public int Id { get; set; }
    public int EnrollmentDataId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual PPDboEnrollmentDatum? EnrollmentData { get; set; }
}
