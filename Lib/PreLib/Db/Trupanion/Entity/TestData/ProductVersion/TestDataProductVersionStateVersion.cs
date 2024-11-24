namespace Database.Trupanion.Entity.TestData.ProductVersion;

public  class TestDataProductVersionStateVersion
{
    public int Id { get; set; }
    public int StateId { get; set; }
    public int VersionValueId { get; set; }

    public virtual TestDataProductVersionVersionValue? VersionValue { get; set; }
}
