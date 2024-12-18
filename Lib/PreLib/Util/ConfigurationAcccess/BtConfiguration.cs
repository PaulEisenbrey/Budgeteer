using System.Configuration;
using System.Reflection;
using Utilities.Constants.Strings;

namespace Utilities.ConfigurationAcccess;

public static class BtConfiguration
{
    public static string BudgeteerConnectionString => GetConnectionString(StringSpace.ConnectionStrings.BudgeteerConnection);

    private static string GetConnectionString(string connectionId)
    {
        string location = Assembly.GetExecutingAssembly()?.Location ?? "";

        string exeDir = Path.GetDirectoryName(location) ?? "";
        exeDir = Path.Combine(exeDir, "Budgeteer.exe");

        return ConfigurationManager.OpenExeConfiguration(exeDir).ConnectionStrings.ConnectionStrings[connectionId].ToString();
    }
}