namespace Database.Trupanion.Entity.TestData.QaLib;

public  class TestDataQaLibPendingEnrollment
{
    public int Id { get; set; }
    public int? OwnerId { get; set; }
    public string? EmailAddress { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime? Enrolled { get; set; }
}
