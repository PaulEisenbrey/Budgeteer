using Utilities.Constants.Enum;

namespace Utilities.Tools.Interfaces;

public interface IRotatingValue
{
    bool HandlesType(RotatorType rt);
}

public interface IRotatingValue<T> : IRotatingValue
{
    void Initialize(IEnumerable<T> collection);

    T GetNext();

    int Count { get; }

    void ShiftLocationPointer(int newLocation);
}