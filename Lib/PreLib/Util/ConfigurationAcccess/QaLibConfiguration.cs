using System.Configuration;
using System.Reflection;
using Utilities.Constants.Strings;

namespace Utilities.ConfigurationAcccess;

public static class QaLibConfiguration
{
    public static string TruDatConnectionString => GetConnectionString(StringSpace.ConnectionStrings.TruDatConnection);

    public static string TestDataConnectionString => GetConnectionString(StringSpace.ConnectionStrings.TestDataConnection);

    public static string BillingConnectionString => GetConnectionString(StringSpace.ConnectionStrings.BillingConnection);

    public static string CommServicesConnectionString => GetConnectionString(StringSpace.ConnectionStrings.CommServicesConnection);

    public static string ClaimsConnectionString => GetConnectionString(StringSpace.ConnectionStrings.ClaimsConnection);

    public static string EnterpriseCatalogConnectionString => GetConnectionString(StringSpace.ConnectionStrings.EnterpriseCatalogConnection);

    public static string Geography2ConnectionString => GetConnectionString(StringSpace.ConnectionStrings.Geography2Connection);

    public static string ProductConntectionString => GetConnectionString(StringSpace.ConnectionStrings.ProductConnection);

    public static string VisionClaimsConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumClaimsConnection);

    public static string VisionConnectionString => GetConnectionString(StringSpace.ConnectionStrings.VisionMigrationConnection);

    public static string AquariumPolicyConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumPolicyConnection);

    public static string AquariumPolicyQuoteConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumPolicyQuoteConnection);

    public static string AquariumPolicyInteractionConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumPolicyInteractionConnection);

    public static string AquariumPolicyPaymentConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumPolicyPaymentConnection);

    public static string AquariumPolicyNotesConnectionString => GetConnectionString(StringSpace.ConnectionStrings.AquariumPolicyNotesConnection);

    public static string ReportingConnectionString => GetConnectionString(StringSpace.ConnectionStrings.ReportingConnection);

    public static string CLUString => GetConnectionString(StringSpace.ConnectionStrings.CLUConnection);

    private static string GetConnectionString(string connectionId)
    {
        string location = Assembly.GetExecutingAssembly()?.Location ?? "";

        string exeDir = Path.GetDirectoryName(location) ?? "";
        exeDir = Path.Combine(exeDir, "ClaimsMigrationValidation.dll");

        return ConfigurationManager.OpenExeConfiguration(exeDir).ConnectionStrings.ConnectionStrings[connectionId].ToString();
    }
}