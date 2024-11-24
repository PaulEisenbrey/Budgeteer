using System.Text;

namespace Utilities.Extension.StringExtension;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendFormattedLine
        (
            this StringBuilder stringBuilder,
            string fmt,
            params object[] args
        ) => stringBuilder.AppendFormat(fmt, args).AppendLine();

    public static StringBuilder AppendWhen
        (
            this StringBuilder stringBuilder,
            Func<bool> predicate,
            Func<StringBuilder, StringBuilder> fn
        ) => predicate() ? fn(stringBuilder) : stringBuilder;

    public static StringBuilder AppendSequence<T>
        (
            this StringBuilder stringBuilder,
            IEnumerable<T> seq,
            Func<StringBuilder, T, StringBuilder> fn
        ) => seq.Aggregate(stringBuilder, fn);
}