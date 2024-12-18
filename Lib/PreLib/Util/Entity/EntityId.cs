namespace Utilities.Entity;

public struct EntityId : IEquatable<EntityId>, IEquatable<Guid>, IEquatable<GuidNonEmpty>
{
    public Guid Value { get; }

    public EntityId(Guid guid)
    {
        if (guid == Guid.Empty)
        {
            throw new ArgumentException("Supplied guid must be non-empty to be used as an entity's id.");
        }

        Value = guid;
    }

    public static implicit operator Guid(EntityId value)
    {
        return value.Value;
    }

    public static implicit operator EntityId(Guid value)
    {
        return new EntityId(value);
    }

    public static implicit operator EntityId(GuidNonEmpty value)
    {
        return new EntityId(value.Value);
    }

    public static bool operator ==(EntityId d1, EntityId d2)
    {
        return d1.Value == d2.Value;
    }

    public static bool operator ==(EntityId d1, Guid d2)
    {
        return d1.Value == d2;
    }

    public static bool operator ==(Guid d1, EntityId d2)
    {
        return d1 == d2.Value;
    }

    public static bool operator !=(EntityId d1, EntityId d2)
    {
        return d1.Value != d2.Value;
    }

    public static bool operator !=(EntityId d1, Guid d2)
    {
        return d1.Value != d2;
    }

    public static bool operator !=(Guid d1, EntityId d2)
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
        if (obj == null)
        {
            return false;
        }

        if (obj is EntityId)
        {
            return Equals((EntityId)obj);
        }

        if (obj is Guid)
        {
            return Equals((Guid)obj);
        }

        if (obj is GuidNonEmpty)
        {
            return Equals((GuidNonEmpty)obj);
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