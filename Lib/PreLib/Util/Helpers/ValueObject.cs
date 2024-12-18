using System.Reflection;

namespace Utilities.Helpers;

public abstract class ValueObject<T> : IEquatable<T> where T : ValueObject<T>
{
    public static bool operator ==(ValueObject<T> x, ValueObject<T>? y)
    {
        return x?.Equals(y) ?? ((object?)y == null);
    }

    public static bool operator !=(ValueObject<T> x, ValueObject<T>? y)
    {
        if (null! == y)
        {
            return false;
        }

        return !(x == y!);
    }

    public virtual bool Equals(T? other)
    {
        if ((object?)other == null)
        {
            return false;
        }

        Type type = GetType();
        Type type2 = other.GetType();
        if (type != type2)
        {
            return false;
        }

        FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        FieldInfo[] array = fields;
        foreach (FieldInfo fieldInfo in array)
        {
            var rhsValue = fieldInfo.GetValue(other);
            var lhsValue = fieldInfo.GetValue(this);

            if ((null == rhsValue && null != lhsValue) || !rhsValue!.Equals(lhsValue))
            {
                return false;
            }
        }

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        T? other = obj as T;
        return Equals(other!);
    }

    public override int GetHashCode()
    {
        IEnumerable<FieldInfo> fields = GetFields();
        int num = 17;
        int num2 = 59;
        int num3 = num;
        foreach (FieldInfo item in fields)
        {
            object? value = item.GetValue(this) ?? null;
            if (null != value)
            {
                num3 = num3 * num2 + value.GetHashCode();
            }
        }

        return num3;
    }

    private IEnumerable<FieldInfo> GetFields()
    {
        Type? type = GetType();
        List<FieldInfo> list = new List<FieldInfo>();

        while (type != typeof(object) && null != type)
        {
            list.AddRange(type!.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
            type = type.BaseType;
        }

        return list;
    }
}