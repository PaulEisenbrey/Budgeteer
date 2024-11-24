using System.Diagnostics;

using Utilities.ArgumentEvaluation;

namespace Utilities.Extension;

public static class GenericExtensions
{
    public static T GuardAgainstNull<T>(this T value, string parameterName)
    {
        if (value == null)
        {
            throw new ArgumentNullException(parameterName, "Value cannot be null");
        }

        return value;
    }

    public static T GuardBreakOnNull<T>(this T value)
    {
        if (value == null)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }

            throw new ArgumentNullException(nameof(value), "Value cannot be null");
        }

        return value;
    }

    public static T GuardAgainstDefaultValue<T>(this T value, string parameterName)
    {
        EvaluateArgument.Execute(value, fn => value != null && !value.Equals(default(T)), "Value cannot be default");

        var type = typeof(T);

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            EvaluateArgument.Execute(value, fn => (object?)value != Nullable.GetUnderlyingType(type)?.GetDefault(), "Value cannot be default");
        }

        return value;
    }

    public static T? GuardAgainstDefaultValue<T>(this T? value, string parameterName)
        where T : struct =>
        value != null && value.Equals(default(T))
            ? throw new ArgumentException(parameterName, "Value cannot be default")
            : value;

    public static T? GuardAgainstNullOrDefaultValue<T>(this T? value, string parameterName)
        where T : struct =>
        value == null || value.Equals(default(T))
            ? throw new ArgumentException(parameterName, "Value cannot be default")
            : value;
}