namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerText
{
    public int Id { get; set; }
    public string? PolicyNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Name { get; set; }
    public string? EmailAddress { get; set; }
    public string? SecondaryEmail { get; set; }
    public string? HomePhone { get; set; }
    public string? CellPhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkExtension { get; set; }
    public string? FaxNumber { get; set; }
    public int? DefaultPaymentMethod { get; set; }
    public int EngineId { get; set; }
    public int? BillingDayOfMonth { get; set; }
    public string? State { get; set; }
    public string? StateCode { get; set; }
    public int? UserId { get; set; }
    public string? Engine { get; set; }
    public string? SalesForceId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
