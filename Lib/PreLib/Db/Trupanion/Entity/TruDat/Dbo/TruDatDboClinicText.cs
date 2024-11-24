namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClinicText
{
    public int Id { get; set; }
    public string? ClinicName { get; set; }
    public bool Validated { get; set; }
    public string? ContactName { get; set; }
    public string? ContactTitle { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? EmailAddress { get; set; }
    public string? Url { get; set; }
    public string? City { get; set; }
    public int? StateId { get; set; }
    public string? StateCode { get; set; }
    public string? StateName { get; set; }
    public string? Zipcode { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public int? Rating { get; set; }
    public bool Active { get; set; }
    public string? SalesForceId { get; set; }
    public int PreferredContactMethodId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool EarlyDataCollection { get; set; }
}
