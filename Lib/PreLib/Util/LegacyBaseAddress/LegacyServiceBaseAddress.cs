using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;

namespace Utilities.LegacyBaseAddress;

public static class LegacyServiceBaseAddress
{
    private static CurrentLegacyEnvironment? env = CurrentLegacyEnvironment.Instance;

    public static string ServiceBaseAddress(LegacyService service, bool isHttps = false)
    {
        EvaluateArgument.Execute(env, fn => null != env, "Invalid environment setting.");
        EvaluateArgument.Execute(service, fn => LegacyService.outofrance != service && LegacyService.uninitialized != service,
            "Invalid Service Request.");

        var httpStr = isHttps ? "https" : "http";

        var baseStr = (env!.CurrentEnvironment != LegacyEnvironment.production)
            ? $"{httpStr}://{env.CurrentLegacyEnvironmentName}-{service.Description()}"
            : $"https://{service.Description()}";

        return baseStr;
    }
}