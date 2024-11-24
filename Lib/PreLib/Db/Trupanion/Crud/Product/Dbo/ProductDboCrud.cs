using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Containers;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Product.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Product.Dbo;

public class ProductDboCrud : QaLibCrud, IQaLibCrud, IProductDboCrud
{
    public ProductDboCrud(ILogManager logMgr) : base(logMgr)
    {

    }

    public async Task<ReturnValue<ProductDboApproval>>RetrieveApprovalByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Id must be a valid Guid");

        try
        {
            var approval = await this.EnsureContext(context).Approvals.FirstOrDefaultAsync(appvl => appvl.Id == id).ConfigureAwait(false);
            
            return null == approval
                ? ReturnValue<ProductDboApproval>.FromError($"Unable to find approval for id {id}")
                : ReturnValue<ProductDboApproval>.From(approval);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboApproval>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboApproval>> RetrieveApprovalTreeByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Id must be a valid Guid");

        try
        {
            var approval = await this.EnsureContext(context).Approvals
                .Include(appvl => appvl.ApprovalStatus)
                .Include(appvl => appvl.Brand)
                .Include(appvl => appvl.RegulatoryAgency)
                .Include(appvl => appvl.ProductVersion)
                .Include(appvl => appvl.ApprovalForms)
                .Include(appvl => appvl.CoverageTexts)
                .Include(appvl => appvl.CoverageWaitingPeriods)
                .Include(appvl => appvl.Coverages)
                .Include(appvl => appvl.EndorsementForms)
                .Include(appvl => appvl.EndorsementPlanForms)
                .Include(appvl => appvl.EndorsementPlans)
                .Include(appvl => appvl.FormConditions)
                .Include(appvl => appvl.FormDeliveryTriggers)
                .Include(appvl => appvl.FormLanguages)
                .Include(appvl => appvl.Forms)
                .Include(appvl => appvl.PlanConditions)
                .Include(appvl => appvl.PlanCoverages)
                .Include(appvl => appvl.PlanFees)
                .Include(appvl => appvl.PlanRules)
                .Include(appvl => appvl.PlanTransitions)
                .Include(appvl => appvl.Plans)
                .Include(appvl => appvl.RelatedCoverages)
                .Include(appvl => appvl.WaitingPeriods)
                .FirstOrDefaultAsync(appvl => appvl.Id == id).ConfigureAwait(false);

            return null == approval
                ? ReturnValue<ProductDboApproval>.FromError($"Unable to find approval for id {id}")
                : ReturnValue<ProductDboApproval>.From(approval);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboApproval>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboApproval>>> RetrieveApprovalsBySimilarNameAsync(string? nameFragment, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(nameFragment, fn => !string.IsNullOrEmpty(nameFragment), "Name Fragment cannot be empty");

        try
        {
            var locaseNameFragment = nameFragment?.ToLower();
            var approval = await this.EnsureContext(context).Approvals
                .Where(appvl => appvl.Name.ToLower().Contains(locaseNameFragment ?? ""))
                .ToListAsync()
                .ConfigureAwait(false);

            return null == approval
                ? ReturnValue<List<ProductDboApproval>>.FromError($"Unable to find approval like {nameFragment}")
                : ReturnValue<List<ProductDboApproval>>.From(approval);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboApproval>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboApproval>>> RetrieveApprovalTreesBySimilarNameAsync(string? nameFragment, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(nameFragment, fn => !string.IsNullOrEmpty(nameFragment), "Name Fragment cannot be empty");

        try
        {
            var locaseNameFragment = nameFragment?.ToLower();
            var approval = await this.EnsureContext(context).Approvals
                .Include(appvl => appvl.ApprovalStatus)
                .Include(appvl => appvl.Brand)
                .Include(appvl => appvl.RegulatoryAgency)
                .Include(appvl => appvl.ProductVersion)
                .Include(appvl => appvl.ApprovalForms)
                .Include(appvl => appvl.CoverageTexts)
                .Include(appvl => appvl.CoverageWaitingPeriods)
                .Include(appvl => appvl.Coverages)
                .Include(appvl => appvl.EndorsementForms)
                .Include(appvl => appvl.EndorsementPlanForms)
                .Include(appvl => appvl.EndorsementPlans)
                .Include(appvl => appvl.FormConditions)
                .Include(appvl => appvl.FormDeliveryTriggers)
                .Include(appvl => appvl.FormLanguages)
                .Include(appvl => appvl.Forms)
                .Include(appvl => appvl.PlanConditions)
                .Include(appvl => appvl.PlanCoverages)
                .Include(appvl => appvl.PlanFees)
                .Include(appvl => appvl.PlanRules)
                .Include(appvl => appvl.PlanTransitions)
                .Include(appvl => appvl.Plans)
                .Include(appvl => appvl.RelatedCoverages)
                .Include(appvl => appvl.WaitingPeriods)
                .Where(appvl => appvl.Name.ToLower().Contains(locaseNameFragment ?? ""))
                .ToListAsync()
                .ConfigureAwait(false);

            return null == approval
                ? ReturnValue<List<ProductDboApproval>>.FromError($"Unable to find approval like {nameFragment}")
                : ReturnValue<List<ProductDboApproval>>.From(approval);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboApproval>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboBrandCountry>>> RetrieveBrandCountriesByBrandIdAsync(Guid? brandId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(brandId, fn => null == brandId || Guid.Empty == brandId, "Brand Id must be a valid Guid");

        try
        {
            var brandCountries = await this.EnsureContext(context).BrandCountries.Where(bc => bc.BrandId == brandId).ToListAsync().ConfigureAwait(false);

            return 0 == brandCountries.Count()
                ? ReturnValue<List<ProductDboBrandCountry>>.FromError($"No Brand Country records matching brand id {brandId}")
                : ReturnValue<List<ProductDboBrandCountry>>.From(brandCountries);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboBrandCountry>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboBrandCountry>>> RetrieveBrandCountryTreesByBrandIdAsync(Guid? brandId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(brandId, fn => null == brandId || Guid.Empty == brandId, "Brand Id must be a valid Guid");

        try
        {
            var brandCountries = await this.EnsureContext(context).BrandCountries
                .Include(bc => bc.Brand)
                .Where(bc => bc.BrandId == brandId).ToListAsync().ConfigureAwait(false);

            return 0 == brandCountries.Count()
                ? ReturnValue<List<ProductDboBrandCountry>>.FromError($"No Brand Country records matching brand id {brandId}")
                : ReturnValue<List<ProductDboBrandCountry>>.From(brandCountries);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboBrandCountry>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Characteristic Id must be a valid Guid");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics.FirstOrDefaultAsync(ch => ch.Id == id).ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<ProductDboCharacteristic>.FromError($"No Characteristic record matching id {id}")
                : ReturnValue<ProductDboCharacteristic>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboCharacteristic>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicByparametersAsync(RetrieveCharacteristicByTypeAndLocationParameters? parms, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(parms, fn => null != parms && parms.IsValid, "Invalid Parameters");

        try
        {
            Expression<Func<ProductDboCharacteristic, bool>> filter = characteristic => null != parms && characteristic.CharacteristicTypeId == parms.CharacteristicTypeId 
                && characteristic.IsoAlpha3CountryCode == parms.IsoAlpha3CountryCode
                && characteristic.StateCode == parms.StateCode
                && characteristic.PostalCode == parms.PostalCode;

            var characteristic = await this.EnsureContext(context).Characteristics.FirstOrDefaultAsync(filter).ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<ProductDboCharacteristic>.FromError("No Characteristic record matching id entered parameters")
                : ReturnValue<ProductDboCharacteristic>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboCharacteristic>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboCharacteristic>> RetrieveCharacteristicTreeByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Characteristic Id must be a valid Guid");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .FirstOrDefaultAsync(ch => ch.Id == id).ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<ProductDboCharacteristic>.FromError($"No Characteristic record matching id {id}")
                : ReturnValue<ProductDboCharacteristic>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboCharacteristic>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByNameFragmentAsync(string? nameFragment, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(nameFragment, fn => !string.IsNullOrEmpty(nameFragment), "Characteristic name cannot be empty");

        try
        {
            var loCaseNameFragment = nameFragment?.ToLower() ?? "";
            var characteristic = await this.EnsureContext(context).Characteristics.Where(ch => ch.Name.ToLower().Contains(loCaseNameFragment)).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with name like {nameFragment}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByNameFragmentAsync(string? nameFragment, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(nameFragment, fn => !string.IsNullOrEmpty(nameFragment), "Characteristic name cannot be empty");

        try
        {
            var loCaseNameFragment = nameFragment?.ToLower() ?? "";
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .Where(ch => ch.Name.ToLower().Contains(loCaseNameFragment)).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with name like {nameFragment}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByCharacteristicTypeIdAsync(Guid? characteristicTypeId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(characteristicTypeId, fn => null == characteristicTypeId || Guid.Empty == characteristicTypeId, "Characteristic Type Id must be a valid Guid");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics.Where(ch => ch.CharacteristicTypeId == characteristicTypeId).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic Type Id {characteristicTypeId}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByCharacteristicTypeIdAsync(Guid? characteristicTypeId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(characteristicTypeId, fn => null == characteristicTypeId || Guid.Empty == characteristicTypeId, "Characteristic Type Id must be a valid Guid");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .Where(ch => ch.CharacteristicTypeId == characteristicTypeId).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic Type Id {characteristicTypeId}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByIsoCountryCodeAsync(string? isoCountryCode, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(isoCountryCode, fn => !string.IsNullOrEmpty(isoCountryCode), "Country Code cannot be empty");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics.Where(ch => ch.IsoAlpha3CountryCode == isoCountryCode).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic country code {isoCountryCode}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByIsoCountryCodeAsync(string? isoCountryCode, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(isoCountryCode, fn => !string.IsNullOrEmpty(isoCountryCode), "Country Code cannot be empty");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .Where(ch => ch.IsoAlpha3CountryCode == isoCountryCode).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic country code {isoCountryCode}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByStateAbbrAsync(string? stateAbbr, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(stateAbbr, fn => !string.IsNullOrEmpty(stateAbbr), "State Abbreviation cannot be empty");

        try
        {
            var loCaseStateCode = stateAbbr?.ToLower();
            var characteristic = await this.EnsureContext(context).Characteristics.Where(ch => null != ch.StateCode && ch.StateCode.ToLower().Equals(loCaseStateCode)).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic state abbrviation {stateAbbr}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByStateAbbrAsync(string? stateAbbr, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(stateAbbr, fn => !string.IsNullOrEmpty(stateAbbr), "State Abbreviation cannot be empty");

        try
        {
            var loCaseStateCode = stateAbbr?.ToLower();
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .Where(ch => null != ch.StateCode && ch.StateCode.ToLower().Equals(loCaseStateCode)).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic state abbrviation {stateAbbr}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicsByPostalCodeAsync(string? zipCode, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(zipCode, fn => !string.IsNullOrEmpty(zipCode), "Postal Code cannot be empty");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics.Where(ch => null != ch.StateCode && ch.StateCode == zipCode).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic country code {zipCode}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCharacteristic>>> RetrieveCharacteristicTreesByPostalCodeAsync(string? zipCode, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(zipCode, fn => !string.IsNullOrEmpty(zipCode), "Postal Code cannot be empty");

        try
        {
            var characteristic = await this.EnsureContext(context).Characteristics
                .Include(ch => ch.CharacteristicType)
                .Include(ch => ch.CharacteristicToProductVersionMaps)
                .Where(ch => null != ch.StateCode && ch.StateCode == zipCode).ToListAsync().ConfigureAwait(false);

            return null == characteristic
                ? ReturnValue<List<ProductDboCharacteristic>>.FromError($"No Characteristic record with Characteristic country code {zipCode}")
                : ReturnValue<List<ProductDboCharacteristic>>.From(characteristic);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCharacteristic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>> RetrieveProductFactorMapByProductFactorIdAsync(Guid? productFactorId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(productFactorId, fn => null == productFactorId || Guid.Empty == productFactorId, "Product Factory Id must be a valid Guid");

        try
        {
            var mapValues = await this.EnsureContext(context).CoinsuranceToProductFactorInstanceMaps.Where(cpfim => cpfim.ProductFactorId == productFactorId).ToListAsync().ConfigureAwait(false);

            return 0 == mapValues.Count()
                ? ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.FromError($"No mappings found Product Id {productFactorId}")
                : ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.From(mapValues);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>> RetrieveProductFactorMapTreeByProductFactorIdAsync(Guid? productFactorId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(productFactorId, fn => null == productFactorId || Guid.Empty == productFactorId, "Product Factory Id must be a valid Guid");

        try
        {
            var mapValues = await this.EnsureContext(context).CoinsuranceToProductFactorInstanceMaps
                .Include(mv => mv.ProductFactorInstance)
                .Where(cpfim => cpfim.ProductFactorId == productFactorId).ToListAsync().ConfigureAwait(false);

            return 0 == mapValues.Count()
                ? ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.FromError($"No mappings found Product Id {productFactorId}")
                : ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.From(mapValues);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCoinsuranceToProductFactorInstanceMap>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCondition>>> RetrieveConditionsByConditionEffectIdAsync(Guid? conditionEffectId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(conditionEffectId, fn => null == conditionEffectId || Guid.Empty == conditionEffectId, "Product Factory Id must be a valid Guid");

        try
        {
            var conditions = await this.EnsureContext(context).Conditions.Where(c => c.ConditionEffectId == conditionEffectId).ToListAsync().ConfigureAwait(false);

            return 0 == conditions.Count()
                ? ReturnValue<List<ProductDboCondition>>.FromError($"Unable to find condition for Effect Id {conditionEffectId}")
                : ReturnValue<List<ProductDboCondition>>.From(conditions);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCondition>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboCondition>>> RetrieveConditionTreesByConditionEffectIdAsync(Guid? conditionEffectId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(conditionEffectId, fn => null == conditionEffectId || Guid.Empty == conditionEffectId, "Product Factory Id must be a valid Guid");

        try
        {
            var conditions = await this.EnsureContext(context).Conditions
                .Include(cnd => cnd.ConditionEffect)
                .Include(cnd => cnd.ConditionProductFactors)
                .Include(cnd => cnd.EndorsementConditions)
                .Include(cnd => cnd.FormConditions)
                .Include(cnd => cnd.PlanConditions)
                .Where(c => c.ConditionEffectId == conditionEffectId).ToListAsync().ConfigureAwait(false);

            return 0 == conditions.Count()
                ? ReturnValue<List<ProductDboCondition>>.FromError($"Unable to find condition for Effect Id {conditionEffectId}")
                : ReturnValue<List<ProductDboCondition>>.From(conditions);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboCondition>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboEndorsement>>> RetrieveAllEndorsementsAsync(ProductDboContext? context = null)
    {
        try
        {
            var endrosements = await this.EnsureContext(context).Endorsements.ToListAsync().ConfigureAwait(false);

            return 0 == endrosements.Count()
                ? ReturnValue<List<ProductDboEndorsement>>.FromError("Unable to find Endorsements")
                : ReturnValue<List<ProductDboEndorsement>>.From(endrosements);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboEndorsement>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboEndorsement>>> RetrieveAllEndorsementTreesAsync(ProductDboContext? context = null)
    {
        try
        {
            var endrosements = await this.EnsureContext(context).Endorsements
                .Include(endorse => endorse.Coverages)
                .Include(endorse => endorse.EndorsementConditions)
                .Include(endorse => endorse.EndorsementForms)
                .Include(endorse => endorse.EndorsementPlans)
                .ToListAsync().ConfigureAwait(false);

            return 0 == endrosements.Count()
                ? ReturnValue<List<ProductDboEndorsement>>.FromError("Unable to find Endorsements")
                : ReturnValue<List<ProductDboEndorsement>>.From(endrosements);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboEndorsement>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboPlan>>> RetrievePlansByApprovalIdAsync(Guid? approvalId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(approvalId, fn => null == approvalId || Guid.Empty == approvalId, "Approval Id must be a valid Guid");
        try
        {
            var plans = await this.EnsureContext(context).Plans.Where(pl => pl.ApprovalId == approvalId).ToListAsync().ConfigureAwait(false);

            return 0 == plans.Count()
                ? ReturnValue<List<ProductDboPlan>>.FromError("Unable to find Plans")
                : ReturnValue<List<ProductDboPlan>>.From(plans);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboPlan>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboPlan>>> RetrievePlanTreesByApprovalIdAsync(Guid? approvalId, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(approvalId, fn => null == approvalId || Guid.Empty == approvalId, "Approval Id must be a valid Guid");
        try
        {
            var plans = await this.EnsureContext(context).Plans
                .Include(pl => pl.Approval)
                .Include(pl => pl.PolicyTermDurationType)
                .Include(pl => pl.PriceTermDurationType)
                .Include(pl => pl.ProductVersion)
                .Include(pl => pl.Template)
                .Include(pl => pl.EndorsementPlans)
                .Include(pl => pl.FormDeliveryTriggers)
                .Include(pl => pl.InverseTemplate)
                .Include(pl => pl.PlanConditions)
                .Include(pl => pl.PlanCoverages)
                .Include(pl => pl.PlanFees)
                .Include(pl => pl.PlanRules)
                .Include(pl => pl.PlanTransitionFromPlans)
                .Include(pl => pl.PlanTransitionToPlans)
                .Where(pl => pl.ApprovalId == approvalId).ToListAsync().ConfigureAwait(false);

            return 0 == plans.Count()
                ? ReturnValue<List<ProductDboPlan>>.FromError("Unable to find Plans")
                : ReturnValue<List<ProductDboPlan>>.From(plans);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboPlan>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboProduct>>> RetrieveProductsAsync(ProductDboContext? context = null)
    {
        try
        {
            var products = await this.EnsureContext(context).Products.ToListAsync().ConfigureAwait(false);

            return 0 == products.Count()
                ? ReturnValue<List<ProductDboProduct>>.FromError("Unable to find Products")
                : ReturnValue<List<ProductDboProduct>>.From(products);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboProduct>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<ProductDboProduct>>> RetrieveProductTreesAsync(ProductDboContext? context = null)
    {
        try
        {
            var products = await this.EnsureContext(context).Products
                .Include(pr => pr.Brand)
                .Include(pr => pr.ProductCertificateIssuingOrganizationTypes)
                .Include(pr => pr.ProductVersions)
                .ToListAsync().ConfigureAwait(false);

            return 0 == products.Count()
                ? ReturnValue<List<ProductDboProduct>>.FromError("Unable to find Products")
                : ReturnValue<List<ProductDboProduct>>.From(products);
        }
        catch (Exception ex)
        {
            return ReturnValue<List<ProductDboProduct>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboProductFactor>> RetrieveProductFactorByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Product Factor Id must be a valid Guid");
        try
        {
            var productFactor = await this.EnsureContext(context).ProductFactors.FirstOrDefaultAsync(pl => pl.Id == id).ConfigureAwait(false);

            return null == productFactor
                ? ReturnValue<ProductDboProductFactor>.FromError("Unable to find Plans")
                : ReturnValue<ProductDboProductFactor>.From(productFactor);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboProductFactor>.FromError(ex);
        }
    }

    public async Task<ReturnValue<ProductDboProductFactor>> RetrieveProductFactorTreeByIdAsync(Guid? id, ProductDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => null == id || Guid.Empty == id, "Product Factor Id must be a valid Guid");
        try
        {
            var productFactor = await this.EnsureContext(context).ProductFactors
                .Include(pf => pf.Parent)
                .Include(pf => pf.ConditionProductFactors)
                .Include(pf => pf.InverseParent)
                .Include(pf => pf.ProductFactorInstances)
                .Include(pf => pf.ProductVersionProductFactors)
                .FirstOrDefaultAsync(pl => pl.Id == id).ConfigureAwait(false);

            return null == productFactor
                ? ReturnValue<ProductDboProductFactor>.FromError("Unable to find Plans")
                : ReturnValue<ProductDboProductFactor>.From(productFactor);
        }
        catch (Exception ex)
        {
            return ReturnValue<ProductDboProductFactor>.FromError(ex);
        }
    }
}
