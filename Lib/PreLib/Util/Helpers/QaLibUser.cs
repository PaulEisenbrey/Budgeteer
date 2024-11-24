using System.Security.Claims;

using Utilities.Constants.Enum;
using Utilities.Constants.Guids;
using Utilities.LegacyBaseAddress;
using Utilities.TruId;

namespace Utilities.Helpers;

public static class QaLibUser
{
    public static Guid UniqueId
    {
        get
        {
            if (CurrentLegacyEnvironment.Instance!.CurrentEnvironment == LegacyEnvironment.development || 
                CurrentLegacyEnvironment.Instance.CurrentEnvironment == LegacyEnvironment.dev)
            {
                return WellKnownGuids.QaLibId.DevelopmentId;
            }
            else if (CurrentLegacyEnvironment.Instance!.CurrentEnvironment == LegacyEnvironment.test)
            {
                return WellKnownGuids.QaLibId.TestId;
            }

            return UnknownUser.Instance.UniqueId;
        }
    }

    public static Guid? OnBehalfOfUserId
    {
        get
        {
            return UniqueId;
        }
    }
}