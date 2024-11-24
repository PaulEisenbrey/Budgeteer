namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClinicPsi
{
    public int Id { get; set; }
    public int HospitalId { get; set; }
    public int? ClinicId { get; set; }
    public string? HospitalName { get; set; }
    public string? PersonSalutation { get; set; }
    public string? PersonFirstName { get; set; }
    public string? PersonLastName { get; set; }
    public string? Address1 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? PostalCode { get; set; }
    public string? County { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public DateTime? ActiveDate { get; set; }
    public string? PersonEmail { get; set; }
    public int? Region { get; set; }
}
