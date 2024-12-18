using System.Reflection;
using System.Text;

namespace Utilities.Helpers;

public static class DumpObjectValues
{
    public static string DumpValues(this object obj, Dictionary<string, object>? fields = null)
    {
        Dictionary<string, string?> properties = GetProperties(obj);
        StringBuilder stringBuilder = new StringBuilder();
        foreach (KeyValuePair<string, string?> item in properties)
        {
            stringBuilder.AppendLine(item.Key + " : " + item.Value);
        }

        if (fields != null)
        {
            foreach (KeyValuePair<string, object> field in fields)
            {
                stringBuilder.AppendLine($"{field.Key}: {field.Value}");
            }
        }

        string path = "objectValues.txt";
        string text = ((obj == null) ? "NULL" : obj.GetType().ToString());
        string text2 = "=====================[ Field Dump (" + text + ") ]============================\r\n "
            + stringBuilder.ToString()
            + "=====================[ End Dump ]=============================\r\n";

        using (FileStream fileStream = File.Open(path, FileMode.OpenOrCreate))
        {
            fileStream.Seek(0L, SeekOrigin.End);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(text2);
        }

        return text2;
    }

    private static Dictionary<string, string?> GetProperties(object obj)
    {
        Dictionary<string, string?> dictionary = new();
        if (obj == null)
        {
            return dictionary;
        }

        PropertyInfo[] properties = obj.GetType().GetProperties();
        foreach (PropertyInfo propertyInfo in properties)
        {
            object? value = propertyInfo.GetValue(obj, new object[0]);
            string? value2 = ((value == null) ? "null" : value.ToString());
            dictionary.Add(propertyInfo.Name, value2);
        }

        return dictionary;
    }
}