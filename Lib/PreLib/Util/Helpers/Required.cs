using Utilities.Extension;

namespace Utilities.Helpers;

public struct Required<T>
{
    public Required(T value)
    {
        value.GuardAgainstDefaultValue(nameof(value));
        this.Value = value;
    }

    public T Value { get; }

    public static implicit operator T(Required<T> value) => value.Value;

    public static implicit operator Required<T>(T value) => new Required<T>(value);
}