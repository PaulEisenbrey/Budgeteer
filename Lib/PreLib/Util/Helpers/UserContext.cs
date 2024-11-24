namespace Utilities.Helpers;

public class UserContext
{
    private Guid uniqueId;

    public UserContext()
    {
        this.Reset();
    }

    public Guid UniqueId
    {
        get
        {
            return uniqueId;
        }
        set
        {
            uniqueId = value;
        }
    }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }

    public int LegacyId { get; set; }

    public void Reset()
    {
        this.UniqueId = Guid.Empty;
        this.Name = null;
        this.DisplayName = null;

        this.LegacyId = 1;
    }
}