using Utilities.Extension.StringExtension;

namespace Utilities.ReturnType.Base;

public readonly struct Maybe<T> : IEquatable<Maybe<T>>
{
    private readonly T? value;

    private Maybe(T? value)
    {
        this.HasValue = value != null;
        this.value = value;
    }

    private Maybe(bool hasValue)
    {
        this.HasValue = hasValue;
        this.value = default;
    }

    public T? Value
    {
        get
        {
            if (this.HasNoValue)
            {
                throw new InvalidOperationException();
            }

            return this.value;
        }
    }

    public T? ValueOrDefault => this.HasValue ? this.value : default;

    public bool HasValue { get; }

    public bool HasNoValue => !this.HasValue;

    public bool Equals(Maybe<T> other)
    {
        if (this.HasNoValue && other.HasNoValue)
        {
            return true;
        }

        if (this.HasNoValue || other.HasNoValue)
        {
            return false;
        }

        return null == this.value ? false : this.value.Equals(other.Value);
    }

    public static implicit operator Maybe<T>(T? value) =>
        value == null ? new Maybe<T>(false) : new Maybe<T>(value);

    public static Maybe<T> From(T obj) => new Maybe<T>(obj);

    public static Maybe<T> FromNoValue() => new Maybe<T>(false);

    public static bool operator ==(Maybe<T> TestUtilitiesMaybe, T value) =>
        null == TestUtilitiesMaybe.Value ? false : TestUtilitiesMaybe.Value.Equals(value);

    public static bool operator !=(Maybe<T> TestUtilitiesMaybe, T value) => !(TestUtilitiesMaybe == value);

    public static bool operator ==(Maybe<T> first, Maybe<T> second) => first.Equals(second);

    public static bool operator !=(Maybe<T> first, Maybe<T> second) => !(first == second);

    public override bool Equals(object? obj)
    {
        if (obj is T)
        {
            obj = new Maybe<T>((T)obj);
        }

        if (!(obj is Maybe<T>))
        {
            return false;
        }

        return this.Equals(obj);
    }

    public override int GetHashCode() => this.value?.GetHashCode() ?? 0;

    public override string ToString() => this.Value?.ToString().NullIfEmpty() ?? "No value";
}