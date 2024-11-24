using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.PurchaseProcess.Dbo;

public class PPDboEnrollmentDatumProjection : EntityIntId
{
    public int? PolicyHolderId { get; set; }

    public string PolicyNumber { get; set; } = "";

    public string? ExternalAccountId { get; set; }

    public DateTime EnrollEffective { get; set; }

    public DateTime? Effective { get; set; }

    public string? EmailAddress { get; set; }

    public string? PostalCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? PrimaryPhone { get; set; }

    public bool? Active { get; set; }
}
