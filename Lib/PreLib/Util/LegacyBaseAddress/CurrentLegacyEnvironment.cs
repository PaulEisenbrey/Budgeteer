using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;

namespace Utilities.LegacyBaseAddress;

public class CurrentLegacyEnvironment : Singleton<CurrentLegacyEnvironment>
{
    private LegacyEnvironment environment = LegacyEnvironment.test;

    public void SetEnvironment(LegacyEnvironment legacyEnvironment)
    {
        EvaluateArgument.Execute(legacyEnvironment, 
            fn => LegacyEnvironment.uninitialized != legacyEnvironment && LegacyEnvironment.outofrange != legacyEnvironment, 
            "Invalid environment setting");

        this.environment = legacyEnvironment;
    }

    public string? CurrentLegacyEnvironmentName => this.environment.Description();

    public LegacyEnvironment CurrentEnvironment => this.environment;
}
