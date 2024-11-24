using System.Collections.Concurrent;

using Utilities;
using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;

namespace Database.Helpers;
public sealed class LocationsCache : Singleton<LocationsCache>
{

    private readonly ICharacteristicAccess? characteristicAccess = LibraryIocHost.Resolve<ICharacteristicAccess>();
    public enum Location
    {
        Owner,

        Hospital,
    }

    private const string Separator = "_";

    public static Guid OwnerLocationCharacteristicTypeId = new Guid("5FEAF673-251B-4CC8-AB86-87DC580AD177");

    public static Guid PrimaryCareProviderLocationCharacteristicTypeId = new Guid("C420FCC9-8D86-4B63-AADC-162DDDE0846A");

    private ConcurrentDictionary<string, Guid> LocationDictionary { get; set; } = new ConcurrentDictionary<string, Guid>();

    public Task<bool> InitializeAsync()
    {
        this.LocationDictionary = new ConcurrentDictionary<string, Guid>();
        return Task.FromResult(true);
    }

    public async Task<(Guid, string)> GetLocation(Location locationKind, string countryIso3, string stateCode, string postalCode)
    {
        EvaluateArgument.Execute(characteristicAccess, characteristicAccess => null != characteristicAccess, "Characteristic Access is not initialized");

        string key = string.Concat(locationKind.ToString(), Separator, countryIso3, Separator, stateCode, Separator, postalCode);
        key = key.Trim()
            .Replace(" ", string.Empty);

        // No need to lock here
        if (this.LocationDictionary.TryGetValue(key, out var locationCharacteristicId))
        {
            return (locationCharacteristicId, "");
        }

        var locationCharacteristicTypeId = locationKind == Location.Owner
            ? OwnerLocationCharacteristicTypeId
            : PrimaryCareProviderLocationCharacteristicTypeId;

        var loc = locationKind == Location.Owner ?
            await this.characteristicAccess!.OwnerLocationCharacteristic(postalCode, stateCode, countryIso3) :
            await this.characteristicAccess!.ClinicLocationCharacteristic(postalCode, stateCode, countryIso3);


        if (null == loc)
        {
            return (Guid.Empty, "Unable to locate characteristic ");
        }

        if (loc.CharacteristicTypeId != Guid.Empty)
        {
            if (!this.LocationDictionary.ContainsKey(key))
            {
                this.LocationDictionary.TryAdd(key, loc.Id);
                locationCharacteristicId = loc.Id;
            }
            // handle the case when above condition will return false (because other thread put a value in it)
            // in this case locationCharacteristicId will be empty GUID
            if (locationCharacteristicId == default)
            {
                locationCharacteristicId = loc.Id;
            }
        }

        return (locationCharacteristicId, "");
    }
}
