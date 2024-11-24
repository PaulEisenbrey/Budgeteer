namespace Utilities.TruId.Interfaces;

public interface ISecurityUserInfo
{
    Guid UniqueId { get; }

    string FirstName { get; }

    string LastName { get; }

    string Name { get; }

    string DisplayName { get; }

    int LegacyId { get; }
}
