namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboEnrollmentProcessDatum
{
    public int Id { get; set; }
    public int EnrollmentDataId { get; set; }
    public int ProcessItemId { get; set; }
    public DateTime? Completed { get; set; }

    public virtual PPDboEnrollmentDatum? EnrollmentData { get; set; }
}
