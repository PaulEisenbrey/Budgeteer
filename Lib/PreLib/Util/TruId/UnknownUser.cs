using Utilities.TruId.Interfaces;

namespace Utilities.TruId;

public class UnknownUser : ISecurityUserInfo
{
    private static UnknownUser instance = new UnknownUser();

    public static UnknownUser Instance => instance;

    public Guid UniqueId => Guid.Empty;

    public string FirstName => string.Empty;

    public string LastName => string.Empty;

    public string Name => string.Empty;

    public string DisplayName => "Unknown User";

    public int LegacyId => 0;
}
