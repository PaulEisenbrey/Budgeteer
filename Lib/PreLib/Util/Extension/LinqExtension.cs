namespace Utilities.Extension
{
    public static class LinqExtension
    {
        // Divides a big list into a bunch of smaller lists. Really useful when you have a lot of data
        // to process, and memory is getting scarce.
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> list, int parts)
        {
            int i = 0;
            var splits = from item in list
                         group item by i++ % parts into part
                         select part.AsEnumerable();
            return splits;
        }
    }
}
