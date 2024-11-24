using System.Reflection;

namespace Utilities.Extension;

public static class TypeExtensions
{
    private static readonly Dictionary<Type, Dictionary<Type, bool>> CyclicalTypesBasedOnType = new Dictionary<Type, Dictionary<Type, bool>>();

    // go through an object graph, look at types, figure out if a type in the graph has reference to another type.  only pay attention to a particular base class

    public static Type? GetEnumerableType(this Type type)
    {
        IEnumerable<Type> enumerableTypes = type.GetInterfaces().Where(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>));

        return enumerableTypes.Select(intType => intType.GetGenericArguments()[0]).FirstOrDefault();
    }

    public static IEnumerable<PropertyInfo> GetPropertiesOfType(this Type type, Type propertyType)
    {
        PropertyInfo[] properties = type.GetProperties();

        return properties.Where(p => p.PropertyType.IsAssignableFrom(propertyType));
    }

    public static void SetAllPropertiesOfType(this Type type, object obj, object value, bool overwriteValues = false)
    {
        IEnumerable<PropertyInfo> properties = obj.GetType().GetPropertiesOfType(value.GetType());

        foreach (PropertyInfo info in properties)
        {
            if (overwriteValues || info.GetValue(obj, null) == info.PropertyType.GetDefault())
            {
                info.SetValue(obj, value, null);
            }
        }
    }

    public static object? GetDefault(this Type type)
    {
        return type.IsValueType ? Activator.CreateInstance(type) : null;
    }

    public static bool TypeWithDerivedTypeMembersIsCyclical(this Type type, Type memberTypeDerivedFrom)
    {
        bool isCyclical;

        Dictionary<Type, bool>? cyclicalTypes;
        if (!CyclicalTypesBasedOnType.TryGetValue(memberTypeDerivedFrom, out cyclicalTypes))
        {
            lock (CyclicalTypesBasedOnType)
            {
                cyclicalTypes = new Dictionary<Type, bool>();
                CyclicalTypesBasedOnType.Add(memberTypeDerivedFrom, cyclicalTypes);
            }
        }

        if (!cyclicalTypes.TryGetValue(type, out isCyclical))
        {
            isCyclical = InternalTypeWithDerivedTypeMembersIsCyclical(type, memberTypeDerivedFrom, new Dictionary<Type, int>(), 0);

            lock (cyclicalTypes)
            {
                cyclicalTypes.Add(type, isCyclical);
            }
        }

        return isCyclical;
    }

    public static Type? TryGetType(string typeName)
    {
        Type? type = Type.GetType(typeName);

        if (type != null)
        {
            return type;
        }

        throw new Exception($"Could not get type {typeName}");
    }

    public static Type? GetElementTypeOrThrow(this PropertyInfo propertyInfo)
    {
        if (propertyInfo.PropertyType.IsArray)
        {
            return propertyInfo.PropertyType.GetElementType();
        }

        if (propertyInfo.PropertyType.IsGenericType)
        {
            return propertyInfo.PropertyType.GetGenericArguments()[0];
        }

        throw new InvalidOperationException("Type must be array or IEnumerable<T>.");
    }

    private static bool InternalTypeWithDerivedTypeMembersIsCyclical(Type typeToCheck, Type memberTypeDerivedFrom, Dictionary<Type, int> seenTypes, int level)
    {
        bool cyclical = false;
        level++;

        if (!seenTypes.ContainsKey(typeToCheck))
        {
            seenTypes.Add(typeToCheck, level);
        }
        else
        {
            return true;
        }

        PropertyInfo[] properties = typeToCheck.GetProperties();

        foreach (PropertyInfo prop in properties)
        {
            if (typeToCheck == prop.PropertyType)
            {
                return true;
            }

            int seenAtLevel;
            seenTypes.TryGetValue(prop.PropertyType, out seenAtLevel);

            if (seenAtLevel != level)
            {
                if (memberTypeDerivedFrom.IsAssignableFrom(prop.PropertyType))
                {
                    cyclical = InternalTypeWithDerivedTypeMembersIsCyclical(prop.PropertyType, memberTypeDerivedFrom, seenTypes, level);
                }
                else if (prop.PropertyType.IsGenericType && memberTypeDerivedFrom.IsAssignableFrom(prop.PropertyType.GetGenericArguments()[0]))
                {
                    cyclical = InternalTypeWithDerivedTypeMembersIsCyclical(prop.PropertyType.GetGenericArguments()[0], memberTypeDerivedFrom, seenTypes, level);
                }

                if (cyclical)
                {
                    return true;
                }
            }
        }

        return false;
    }
}