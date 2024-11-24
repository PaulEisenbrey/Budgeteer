﻿namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboSelectedPolicyOption
{
    public int Id { get; set; }
    public int EnrollmentPetDataId { get; set; }
    public string? Name { get; set; }
    public decimal Cost { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual PPDboEnrollmentPetDatum? EnrollmentPetData { get; set; }
}
