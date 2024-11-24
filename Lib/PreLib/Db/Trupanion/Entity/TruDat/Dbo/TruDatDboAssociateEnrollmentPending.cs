namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateEnrollmentPending
{
    public int Id { get; set; }
    public string? SessionId { get; set; }
    public string? AssociateName { get; set; }
    public string? PortalUserName { get; set; }
    public string? PortalEmailAddress { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public int StateId { get; set; }
    public string? Zipcode { get; set; }
    public string? PrimaryContactName { get; set; }
    public string? CellPhone { get; set; }
    public string? HomePhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkExtension { get; set; }
    public string? PrimaryContactEmail { get; set; }
    public string? Title { get; set; }
    public int PreferredContactMethodId { get; set; }
    public bool IsAuthorized { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual List<TruDatDboAssociateEnrollmentWebsitePending> AssociateEnrollmentWebsitePendings { get; set; } = new();
}
