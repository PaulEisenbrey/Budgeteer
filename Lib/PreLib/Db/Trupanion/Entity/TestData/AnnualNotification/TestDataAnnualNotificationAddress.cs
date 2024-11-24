namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationAddress
{
    public int Id { get; set; }
    public int AddressTypeId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string StateAbbr { get; set; } = string.Empty;
    public string? ZipCode { get; set; }
}
