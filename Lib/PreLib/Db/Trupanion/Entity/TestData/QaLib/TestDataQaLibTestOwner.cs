namespace Database.Trupanion.Entity.TestData.QaLib;

public  class TestDataQaLibTestOwner
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? DeletedOn { get; set; }
    public Guid? PolicyHolderId { get; set; }
    public bool? EnrollmentComplete { get; set; }
    public string? ExternalId { get; set; }
}
