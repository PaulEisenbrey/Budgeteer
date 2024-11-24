using Database.Trupanion.Entity.Product.Dbo;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Helpers
{
    public interface ICharacteristicAccess
    {
        ProductDboCharacteristic? AgeBandCharacteristic(AgeType age);
        ReturnValue<IEnumerable<ProductDboCharacteristic>> AgeBands();
        ProductDboCharacteristic? AlteredCharacteristic();
        ProductDboCharacteristic? CatBreedCharacteristic(string breedName);
        ReturnValue<IEnumerable<ProductDboCharacteristic>> CatBreeds();
        ProductDboCharacteristic? CatSpeciesCharacteristic();
        Task<ProductDboCharacteristic> ClinicLocationCharacteristic(string zipCode, string stateCode, string country);
        ProductDboCharacteristic? ConvertedFromTrialCharacteristic(bool isTrialConversion);
        ProductDboCharacteristic? DiscountCharacteristic(string discountType);
        ProductDboCharacteristic? DogBreedCharacteristic(string breedName);
        ReturnValue<IEnumerable<ProductDboCharacteristic>> DogBreeds();
        ProductDboCharacteristic? DogSpeciesCharacteristic();
        ProductDboCharacteristic? FemaleCharacteristic();
        ProductDboCharacteristic? GroupPlanCharacteristic(string groupPlanName);
        Task InitializeListings();
        ProductDboCharacteristic? IntactCharacteristic();
        ProductDboCharacteristic? MaleCharacteristic();
        Task<ProductDboCharacteristic> OwnerLocationCharacteristic(string zipCode, string stateCode, string country);
        ProductDboCharacteristic? ServiceCharacteristic();
        ProductDboCharacteristic? VipCharacteristic();
    }
}