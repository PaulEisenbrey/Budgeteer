namespace Database.Trupanion.Entity.Aggregates;

public class FullName
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public override string ToString() => $"{FirstName} {LastName}";
}
