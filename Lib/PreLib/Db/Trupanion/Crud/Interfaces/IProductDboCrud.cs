using Database.BaseClasses.Interfaces;
using Database.Containers;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Product.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface IProductDboCrud : IQaLibCrud
{
    Task<ReturnValue<List<ProductDboEndorsement>>> RetrieveAllEndorsementsAsync(ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboEndorsement>>> RetrieveAllEndorsementTreesAsync(ProductDboContext? context = null);
    Task<ReturnValue<ProductDboApproval>> RetrieveApprovalByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboApproval>>> RetrieveApprovalsBySimilarNameAsync(string? nameFragment, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboApproval>> RetrieveApprovalTreeByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboApproval>>> RetrieveApprovalTreesBySimilarNameAsync(string? nameFragment, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboBrandCountry>>> RetrieveBrandCountriesByBrandIdAsync(Guid? brandId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboBrandCountry>>> RetrieveBrandCountryTreesByBrandIdAsync(Guid? brandId, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicByparametersAsync(RetrieveCharacteristicByTypeAndLocationParameters? parms, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByCharacteristicTypeIdAsync(Guid? characteristicTypeId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByIsoCountryCodeAsync(string? isoCountryCode, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByNameFragmentAsync(string? nameFragment, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByPostalCodeAsync(string? zipCode, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByStateAbbrAsync(string? stateAbbr, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicTreeByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByCharacteristicTypeIdAsync(Guid? characteristicTypeId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByIsoCountryCodeAsync(string? isoCountryCode, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByNameFragmentAsync(string? nameFragment, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByPostalCodeAsync(string? zipCode, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByStateAbbrAsync(string? stateAbbr, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCondition>>> RetrieveConditionsByConditionEffectIdAsync(Guid? conditionEffectId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCondition>>> RetrieveConditionTreesByConditionEffectIdAsync(Guid? conditionEffectId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboPlan>>> RetrievePlansByApprovalIdAsync(Guid? approvalId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboPlan>>> RetrievePlanTreesByApprovalIdAsync(Guid? approvalId, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboProductFactor>> RetrieveProductFactorByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>> RetrieveProductFactorMapByProductFactorIdAsync(Guid? productFactorId, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>> RetrieveProductFactorMapTreeByProductFactorIdAsync(Guid? productFactorId, ProductDboContext? context = null);
    Task<ReturnValue<ProductDboProductFactor>> RetrieveProductFactorTreeByIdAsync(Guid? id, ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboProduct>>> RetrieveProductsAsync(ProductDboContext? context = null);
    Task<ReturnValue<List<ProductDboProduct>>> RetrieveProductTreesAsync(ProductDboContext? context = null);
}