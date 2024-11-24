namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboMissingClaim
{
    public double? ClaimNumber { get; set; }
    public DateTime? DateOfLoss { get; set; }
    public DateTime? CheckClosedDate { get; set; }
    public string? PolicyNumber { get; set; }
    public string? InsuredName { get; set; }
    public double? PetId { get; set; }
    public string? PetName { get; set; }
    public double? InvoiceTotal { get; set; }
    public double? Allowed { get; set; }
    public double? DeductibleApplied { get; set; }
    public double? Paid { get; set; }
    public string? ClaimStatus { get; set; }
    public int? ClaimId { get; set; }
    public int? PetPolicyId { get; set; }
}
