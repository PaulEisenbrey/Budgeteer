namespace Database.Trupanion.Entity.TestData.ProductVersion;

public  class TestDataProductVersionVersionValue
{
    public int Id { get; set; }
    public string? Version { get; set; }

    public virtual List<TestDataProductVersionStateVersion> StateVersions { get; set; } = new();
}
