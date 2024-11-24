namespace Utilities.Extension.DateExtension;

public static class DateExt
{
    public static string DateOnlyString(this DateTime date) =>
        date.ToString("MM/dd/yyyy");
}

