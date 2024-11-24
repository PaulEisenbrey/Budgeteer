namespace Utilities.Entity;

public struct GuidNonEmpty : IEquatable<GuidNonEmpty>, IEquatable<Guid>, IEquatable<EntityId>
{
    public Guid Value { get; }

    public GuidNonEmpty(Guid guid)
    {
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("Supplied guid must be non-empty");
        }

        Value = guid;
    }

    public static implicit operator Guid(GuidNonEmpty value)
    {
        return value.Value;
    }

    public static implicit operator GuidNonEmpty(Guid value)
    {
        return new GuidNonEmpty(value);
    }

    public static bool operator ==(GuidNonEmpty d1, GuidNonEmpty d2)
    {
        return d1.Value == d2.Value;
    }

    public static bool operator ==(GuidNonEmpty d1, Guid d2)
    {
        return d1.Value == d2;
    }

    public static bool operator ==(Guid d1, GuidNonEmpty d2)
    {
        return d1 == d2.Value;
    }

    public static bool operator !=(GuidNonEmpty d1, GuidNonEmpty d2)
    {
        return d1.Value != d2.Value;
    }

    public static bool operator !=(GuidNonEmpty d1, Guid d2)
    {
        return d1.Value != d2;
    }

    public static bool operator !=(Guid d1, GuidNonEmpty d2)
    {
        return d1 != d2.Value;
    }

    public bool Equals(GuidNonEmpty other)
    {
        return Value == other.Value;
    }

    public bool Equals(EntityId other)
    {
        return Value == other.Value;
    }

    public bool Equals(Guid other)
    {
        return Value == other;
    }

    public override bool Equals(object? obj)
    {
        if (obj != null)
        {
            if (obj is EntityId)
            {
                EntityId other = (EntityId)obj;
                return Equals(other);
            }

            if (obj is Guid)
            {
                Guid other2 = (Guid)obj;
                return Equals(other2);
            }

            if (obj is GuidNonEmpty)
            {
                GuidNonEmpty other3 = (GuidNonEmpty)obj;
                return Equals(other3);
            }

            return false;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}