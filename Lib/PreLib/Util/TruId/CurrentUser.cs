using System.Security.Claims;

using Utilities.Extension.StringExtension;
using Utilities.IoCInterfaces;
using Utilities.TruId.Interfaces;

namespace Utilities.TruId;


public static class CurrentUser
{
    public static ISecurityUserInfo UserInfo
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            if (securityUserInfo == null)
            {
                return UnknownUser.Instance;
            }

            return securityUserInfo;
        }
    }

    public static Guid UniqueId
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            if (securityUserInfo != null)
            {
                return securityUserInfo.UniqueId;
            }

            var userContext = LibraryIocHost.Resolve<IUserContext>();

            return securityUserInfo?.UniqueId ?? UnknownUser.Instance.UniqueId;
        }
    }

    public static string FirstName
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            return securityUserInfo?.FirstName.NullIfEmpty() ?? UnknownUser.Instance.FirstName;
        }
    }

    public static string LastName
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            return securityUserInfo?.LastName.NullIfEmpty() ?? UnknownUser.Instance.LastName;
        }
    }

    public static string Name
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            
            if (securityUserInfo != null)
            {
                return securityUserInfo.Name;
            }

            var userContext = LibraryIocHost.Resolve<IUserContext>();

            return userContext?.Name.NullIfEmpty() ?? UnknownUser.Instance.Name;
        }
    }

    public static int LegacyId
    {
        get
        {
            var securityUserInfo = GetSecurityUserInfo();
            if (securityUserInfo != null)
            {
                return securityUserInfo.LegacyId;
            }

            var userContext = LibraryIocHost.Resolve<IUserContext>();

            return userContext?.LegacyId ?? UnknownUser.Instance.LegacyId;
        }
    }

    private static ISecurityUserInfo? GetSecurityUserInfo()
    {
        return System.Threading.Thread.CurrentPrincipal as ISecurityUserInfo;
    }
}
