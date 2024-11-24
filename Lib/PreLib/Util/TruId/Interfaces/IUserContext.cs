namespace Utilities.TruId.Interfaces;

public interface IUserContext
{
    Guid UniqueId { get; set; }
    string? Name { get; set; }
    string? DisplayName { get; set; }
    int LegacyId { get; set; }

    void Reset();
}
