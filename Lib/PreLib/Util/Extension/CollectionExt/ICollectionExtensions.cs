using System.Collections;

namespace Utilities.Extension.CollectionExt;

public static class ICollectionExtensions
{
    public static bool Any(this ICollection collection)
    {
        if (null == collection)
        {
            throw new ArgumentNullException("ICollection");
        }

        return collection.Count > 0;
    }

    public static void TestForEach<T>(this IEnumerable<T> sequence, Action<T> action)
    {
        if (sequence == null)
        {
            return;
        }

        foreach (T item in sequence)
        {
            action(item);
        }
    }

    public static bool TestIsOutOfBounds<T>(this int index, ICollection<T> collection)
    {
        return index < 0 || index >= collection.Count;
    }

    public static bool TestIsNullOrEmpty(this ICollection collection)
    {
        return collection == null || collection.Count == 0;
    }

    public static bool TestIsNullOrEmptyOfT<T>(this ICollection<T> collection)
    {
        return collection == null || collection.Count == 0;
    }
}