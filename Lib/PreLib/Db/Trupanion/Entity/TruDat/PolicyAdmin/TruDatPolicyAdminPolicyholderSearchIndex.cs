namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPolicyholderSearchIndex
{
    public Guid Id { get; set; }
    public Guid? BrandId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PostalCode { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public string? AlternatePhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public string? PolicyNumber { get; set; }
}
