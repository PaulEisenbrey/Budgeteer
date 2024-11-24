namespace Utilities.Helpers;

public static class StringHelpers
{
    public static string CombinePath(string prefix, string suffix)
    {
        return string.Join("/", prefix, suffix).Replace("//", "/");
    }

    public static string ReplaceInString(this string fullString, string tag, string replaceWith)
    {
        return fullString.Replace(tag, replaceWith);
    }
}