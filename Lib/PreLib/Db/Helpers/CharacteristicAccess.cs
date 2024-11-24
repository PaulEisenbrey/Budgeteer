using Database.Containers;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Product.Dbo;
using Database.Helpers;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Constants.Strings;
using Utilities.Extension;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

using static Utilities.Constants.Guids.WellKnownGuids;

namespace Http.Helpers;

public class CharacteristicAccess : ICharacteristicAccess, ISingletonSvc
{
    private readonly SemaphoreSlim mutex = new(1);
    private static Dictionary<Guid, List<ProductDboCharacteristic>> petCharacteristics = new();
    private static string errorText = string.Empty;
    private IProductDboCrud productCrud;

    public CharacteristicAccess(IProductDboCrud productCrud)
    {
        this.productCrud = productCrud;
    }

    public async Task InitializeListings()
    {
        await this.Initialize();
    }

    public ProductDboCharacteristic? DogBreedCharacteristic(string breedName) => this.RetrieveNamedEntity(PetCharacteristicTypes.DogBreed, breedName);

    public ReturnValue<IEnumerable<ProductDboCharacteristic>> DogBreeds() => new ReturnValue<IEnumerable<ProductDboCharacteristic>>().SetValue(petCharacteristics[PetCharacteristicTypes.DogBreed]);

    public ProductDboCharacteristic? CatBreedCharacteristic(string breedName) => this.RetrieveNamedEntity(PetCharacteristicTypes.CatBreed, breedName);

    public ReturnValue<IEnumerable<ProductDboCharacteristic>> CatBreeds() => new ReturnValue<IEnumerable<ProductDboCharacteristic>>().SetValue(petCharacteristics[PetCharacteristicTypes.CatBreed]);

    public ProductDboCharacteristic? DogSpeciesCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Species, StringSpace.PetCharacteristic.Dog);

    public ProductDboCharacteristic? CatSpeciesCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Species, StringSpace.PetCharacteristic.Cat);

    public ProductDboCharacteristic? AgeBandCharacteristic(AgeType age) => this.RetrieveNamedEntity(PetCharacteristicTypes.AgeBand, age.Description()!);

    public ReturnValue<IEnumerable<ProductDboCharacteristic>> AgeBands() => ReturnValue<IEnumerable<ProductDboCharacteristic>>.From(petCharacteristics[PetCharacteristicTypes.AgeBand]);

    public ProductDboCharacteristic? MaleCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Gender, StringSpace.PetCharacteristic.Male);

    public ProductDboCharacteristic? FemaleCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Gender, StringSpace.PetCharacteristic.Female);

    public ProductDboCharacteristic? AlteredCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Spay_Neuter, StringSpace.PetCharacteristic.Altered);

    public ProductDboCharacteristic? IntactCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Spay_Neuter, StringSpace.PetCharacteristic.Intact);

    public ProductDboCharacteristic? ServiceCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.ServiceAnimal, StringSpace.PetCharacteristic.ServiceAnimal);

    public ProductDboCharacteristic? VipCharacteristic() => this.RetrieveNamedEntity(PetCharacteristicTypes.Vip, StringSpace.PetCharacteristic.Vip);

    public ProductDboCharacteristic? DiscountCharacteristic(string discountType) => this.RetrieveNamedEntity(PetCharacteristicTypes.Discount, discountType);

    public async Task<ProductDboCharacteristic> ClinicLocationCharacteristic(string zipCode, string stateCode, string country) => await this.RetrievePostalEntity(PetCharacteristicTypes.PrimaryCareProviderLocation, zipCode, stateCode, country);

    public async Task<ProductDboCharacteristic> OwnerLocationCharacteristic(string zipCode, string stateCode, string country) => await this.RetrievePostalEntity(PetCharacteristicTypes.PrimaryPolicyholderLocation, zipCode, stateCode, country);

    public ProductDboCharacteristic? ConvertedFromTrialCharacteristic(bool isTrialConversion) =>
        isTrialConversion
        ? this.RetrieveNamedEntity
            (
                PetCharacteristicTypes.ConvertedFromTrial,
                StringSpace.PetCharacteristic.ConvertedFromTrial
            )
        : this.RetrieveNamedEntity
            (
                PetCharacteristicTypes.ConvertedFromTrial,
                StringSpace.PetCharacteristic.NotConvertedFromTrial
            );

    public ProductDboCharacteristic? GroupPlanCharacteristic(string groupPlanName) => this.RetrieveNamedEntity(PetCharacteristicTypes.GroupPlanParticipant, groupPlanName);

    private ProductDboCharacteristic? RetrieveNamedEntity(Guid key, string name)
    {
        var characteristic = petCharacteristics[key].FirstOrDefault(x => x.Name == name);
        if (default != characteristic)
        {
            return characteristic;
        }

        return default;
    }

    private async Task<ReturnValue<ProductDboCharacteristic>> RetrievePostalEntity(Guid key, string zipCode, string stateCode, string countryCode)
    {
        try
        {
            EvaluateArgument.Execute(key, fn => Guid.Empty != key, "Postal Entity Key cannot be empty");

            var arg = new RetrieveCharacteristicByTypeAndLocationParameters
            {
                CharacteristicTypeId = key,
                StateCode = stateCode,
                IsoAlpha3CountryCode = countryCode,
                PostalCode = zipCode
            };
            var characteristic = await this.productCrud.RetrieveCharacteristicByparametersAsync(arg).ConfigureAwait(false);

            if (!characteristic.IsValid)
            {
                errorText += $"{characteristic.ErrorText}. {System.Environment.NewLine}";
                return ReturnValue<ProductDboCharacteristic>.FromError(errorText);
            }

            EvaluateArgument.Execute(characteristic.Result, fn => null != characteristic.Result, $"Unable to retrieve characteristic for Id {key}");

            return ReturnValue<ProductDboCharacteristic>.From(characteristic.Result!);
        }
        catch (ArgumentException aex)
        {
            return ReturnValue<ProductDboCharacteristic>.FromError(aex);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboCharacteristic>.FromError(ex);
        }
    }

    private async Task Initialize()
    {
        if (!petCharacteristics.Any())
        {
            try
            {
                await this.mutex.WaitAsync().ConfigureAwait(false);

                if (!petCharacteristics.Any())
                {
                    var pair = await this.CreateEntry(PetCharacteristicTypes.DogBreed);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.CatBreed);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.AgeBand);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.Species);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.Gender);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.Spay_Neuter);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.ServiceAnimal);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.Vip);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.Discount);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.ConvertedFromTrial);
                    petCharacteristics.Add(pair.Key, pair.Value);

                    pair = await this.CreateEntry(PetCharacteristicTypes.GroupPlanParticipant);
                    petCharacteristics.Add(pair.Key, pair.Value);
                }
            }
            finally
            {
                this.mutex.Release();
            }
        }
    }

    private async Task<KeyValuePair<Guid, List<ProductDboCharacteristic>>> CreateEntry(Guid typeId)
    {
        var characteristics = await this.productCrud.RetrieveCharacteristicsByCharacteristicTypeIdAsync(typeId).ConfigureAwait(false);

        if (!characteristics.IsValid)
        {
            errorText += $"{characteristics.ErrorText}. {System.Environment.NewLine}";
            return new KeyValuePair<Guid, List<ProductDboCharacteristic>>();
        }

        return new KeyValuePair<Guid, List<ProductDboCharacteristic>>(typeId, characteristics.Result!.ToList());
    }
}