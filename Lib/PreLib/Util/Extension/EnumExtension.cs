using System.ComponentModel;
using Utilities.ArgumentEvaluation;

namespace Utilities.Extension;

public static class EnumExtension
{
    public static string? Description(this Enum value)
    {
        var type = value?.GetType();
        EvaluateArgument.Execute(value, fn => null != value, "Invalid Value");
        EvaluateArgument.Execute(type, fn => null != type, "Invalid Type");

        var name = Enum.GetName(type!, value!);

        if (name != null)
        {
            var field = type!.GetField(name);
            if (field != null)
            {
                return Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr ? attr.Description : string.Empty;
            }
        }

        return null;
    }

    public static IEnumerable<T> GetValues<T>()
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }

    public static bool InRange<T>(int prospectiveValue)
    {
        return Enum.IsDefined(typeof(T), prospectiveValue);
    }

    public static IEnumerable<T> Pipe<T>(this IEnumerable<T> collection, Action<T> action)
    {
        if (null == collection)
        {
            throw new ArgumentException("the collection may not be null");
        }

        if (null == action)
        {
            throw new ArgumentException("Action cannot be null");
        }

        return collection.PipeImpl(action);
    }

    private static IEnumerable<T> PipeImpl<T>(this IEnumerable<T> collection, Action<T> action)
    {
        foreach (var item in collection)
        {
            action(item);
            yield return item;
        }
    }
}