namespace Database.Trupanion.Entity.TestData.NameSource;

public  class TestDataNameSourceName
{
    public int Id { get; set; }
    public int LanguageId { get; set; }
    public bool IsSurname { get; set; }
    public string? Name { get; set; }

    public virtual TestDataNameSourceLanguageSource? Language { get; set; }
}
