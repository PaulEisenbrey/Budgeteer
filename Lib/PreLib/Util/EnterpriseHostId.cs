using Utilities.Constants.Enum;
using Utilities.LegacyBaseAddress;

namespace Utilities;

public static class EnterpriseHostId
{
    public static int QaLibHostId => CurrentLegacyEnvironment.Instance!.CurrentEnvironment == LegacyEnvironment.test ? 2 : 23;
}
