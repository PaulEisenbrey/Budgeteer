namespace Database.Trupanion.Entity.TestData.NameSource;

public  class TestDataNameSourceLanguageSource
{
    public int Id { get; set; }
    public string? Language { get; set; }

    public virtual List<TestDataNameSourceName> Names { get; set; } = new();
}
