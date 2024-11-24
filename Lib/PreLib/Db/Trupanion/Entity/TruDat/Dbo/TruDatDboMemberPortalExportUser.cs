namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboMemberPortalExportUser
{
    public int LegacyId { get; set; }
    public Guid TruIdUniqueId { get; set; }
    public Guid TruSecurityId { get; set; }
    public string? Password { get; set; }
    public string? PasswordSalt { get; set; }
    public string? PolicyNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? EmailAddress2 { get; set; }
    public int CorporateAccount { get; set; }
}
