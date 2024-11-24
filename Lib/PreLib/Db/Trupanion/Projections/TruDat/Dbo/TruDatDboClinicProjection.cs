namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboClinicProjection
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Validated { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public int? StateId { get; set; }
    public string? Zipcode { get; set; }
    public bool? Active { get; set; }
    public int? EnrolledPolicyCount { get; set; }
    public int ClinicRiskId { get; set; }
    public int? PartnerId { get; set; }
    public Guid UniqueId { get; set; }
}