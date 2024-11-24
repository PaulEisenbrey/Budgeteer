namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingCustomer
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Language { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? MobileNumber { get; set; }
    public int DdaStatus { get; set; }
    public int? DdaDescription { get; set; }
    public int CommunicationPreference { get; set; }
    public int? SearchField { get; set; }
    public int? BrandId { get; set; }
    public int? BirthdayDate { get; set; }
    public int CustomerExtId { get; set; }
    public Guid CustomerExtRef { get; set; }
    public Guid Ref { get; set; }
    public DateTimeOffset? ModifiedDateTime { get; set; }
    public int? Title { get; set; }
    public int? CareFlag { get; set; }
    public int ExtRef { get; set; }
    public Guid BatchId { get; set; }
}
