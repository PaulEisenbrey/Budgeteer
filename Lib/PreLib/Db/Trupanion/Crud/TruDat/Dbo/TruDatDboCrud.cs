using System.Linq.Expressions;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.CollectionExt;
using Utilities.Extension.StringExtension;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TruDat.Dbo;

public class TruDatDboCrud : QaLibCrud, IQaLibCrud, ITruDatDboCrud
{
    public TruDatDboCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public ReturnValue<List<TruDatDboBreed>> RetrieveAllBreeds(bool activeOnly = false, TruDatDboContext? context = null)
    {
        try
        {
            var breeds = this.EnsureContext(context).Breeds.ToList();
            if (0 != breeds.Count)
            {
                return activeOnly 
                    ? ReturnValue<List<TruDatDboBreed>>.From(breeds.Where(breed => breed.Active).ToList()) 
                    : ReturnValue<List<TruDatDboBreed>>.From(breeds);
            }

            return ReturnValue<List<TruDatDboBreed>>.FromError("No Breeds Found");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatDboBreed>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatDboBreed>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatDboOwnerVisionPolicyMigrationStatus>>> RetrieveMigratedOwnersAsync(TruDatDboContext? tdContext = null)
    {
        Expression<Func<TruDatDboOwnerVisionPolicyMigrationStatus, bool>> predicate = ovpms => ovpms.MigrationStatusId >= 2;

        try
        {
            var migratedOwners = await this.RetrieveManyByQueryAsync(predicate, tdContext).ConfigureAwait(false);

            return this.GenerateReturnValue(migratedOwners,
                "NULL response for migrated Owners query",
                "No Owners Found in migrated Owners query");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatDboOwnerVisionPolicyMigrationStatus>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatDboOwnerVisionPolicyMigrationStatus>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatDboOwner>>> RetrieveMultipleOwnersAsync(IEnumerable<int> ownerIds, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerIds, fn => 0 < ownerIds.Count(), "OwnerId list must not be empty");

        Expression<Func<TruDatDboOwner, bool>> predicate = owner => ownerIds.Any(oid => owner.Id == oid);
        try
        {
            var owners = await this.RetrieveManyByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(owners,
                "NULL response retrieving list of owners",
                "No Owners returned from query");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatDboOwner>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatDboOwner>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByIdAsync(int ownerId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a positive, non-zero integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var ownerRec = await this.RetrieveByIdAsync<TruDatDboOwner, int, TruDatDboContext>(ownerId, ctx).ConfigureAwait(false);

            return this.GenerateReturnValue(ownerRec, $"No Owner retrieved via OwnerId {ownerId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByPolicyNumberAsync(string policyNumber, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(policyNumber, fn => !string.IsNullOrEmpty(policyNumber), "Policy Number cannot be empty");

        var loCasePolicyNumber = policyNumber.ToLower();
        Expression<Func<TruDatDboOwner, bool>> predicate = policyOwner => policyOwner.PolicyNumber.ToLower().Equals(loCasePolicyNumber);
        try
        {
            var ownerRec = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(ownerRec, $"No Owner retrieved via Policy Number {policyNumber}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByPersonIdAsync(Guid personId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(personId, fn => Guid.Empty != personId, "Person Id cannot be empty");

        Expression<Func<TruDatDboOwner, bool>> predicate = owner => owner.PersonId == personId;
        try
        {
            var ownerRec = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(ownerRec, $"No Owner retrieved via Person Id {personId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByEmailAsync(string emailAddress, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(emailAddress, fn => !string.IsNullOrEmpty(emailAddress), "Email address cannot be empty");
        EvaluateEmailAddress.Execute(emailAddress, $"Invalid email address {emailAddress}");

        var loCaseMailAddr = emailAddress.ToLower();
        Expression<Func<TruDatDboOwner, bool>> predicate = emailOwner => !string.IsNullOrEmpty(emailOwner.EmailAddress) && emailOwner.EmailAddress.ToLower().Equals(loCaseMailAddr);
        try
        {
            var ownerRec = await this.RetrieveByQueryAsync(predicate, context).ConfigureAwait(false);

            return this.GenerateReturnValue(ownerRec, $"No Owner retrieved via email {emailAddress}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    /// <summary>
    /// This function is hear for completeness, and for those extremely rare situations when you need ALL the data.
    /// Normally, however, you shouldn't call this. It is slow, and has possible impacts on the server.
    /// Normally, you should use the owner projections.
    /// </summary>
    /// <param name="ownerId"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeByOwnerIdAsync(int ownerId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "Owner Id must be a non-zero positive integer. Received value: {ownerId}");

        Expression<Func<TruDatDboOwner, bool>> predicate = owner => owner.Id == ownerId;
        try
        {
            var ctx = this.EnsureContext(context);

            var ownerRec = await this.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);
            EvaluateArgument.Execute(ownerRec, fn => ownerRec.IsValid && null != ownerRec.Result, ownerRec.ErrorText);

            return await this.RetrieveOwnerTreeAsync(ownerRec, ctx).ConfigureAwait(false);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    /// <summary>
    /// This function is hear for completeness, and for those extremely rare situations when you need ALL the data.
    /// Normally, however, you shouldn't call this. It is slow, and has possible impacts on the server.
    /// Normally, you should use the owner projections.
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeByEmailAsync(string emailAddress, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(emailAddress, fn => !string.IsNullOrEmpty(emailAddress), "Email address cannot be empty");
        EvaluateEmailAddress.Execute(emailAddress, $"Invalid email address {emailAddress}");

        var loCaseMailAddr = emailAddress.ToLower();
        Expression<Func<TruDatDboOwner, bool>> predicate = emailOwner => !string.IsNullOrEmpty(emailOwner.EmailAddress) && emailOwner.EmailAddress.ToLower().Equals(loCaseMailAddr);
        try
        {
            var ctx = this.EnsureContext(context);

            var ownerRec = await this.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);
            EvaluateArgument.Execute(ownerRec, fn => ownerRec.IsValid && null != ownerRec.Result, ownerRec.ErrorText);

            return await this.RetrieveOwnerTreeAsync(ownerRec, ctx).ConfigureAwait(false);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    /// <summary>
    /// This function is hear for completeness, and for those extremely rare situations when you need ALL the data.
    /// Normally, however, you shouldn't call this. It is slow, and has possible impacts on the server.
    /// Normally, you should use the owner projections.
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeAsync(ReturnValue<TruDatDboOwner> ownerRec, TruDatDboContext? context = null)
    {
        int ownerId = ownerRec.Result!.Id;  // null result is filtered out above.
        var ctx = this.EnsureContext(context);

        try
        {
            // first, the singleton links
            Expression<Func<TruDatDboCommunicationPreference, bool>> commPrefPredicate = commPref => commPref.Id == ownerRec.Result.CommunicationPreferenceId;
            _ = await this.RetrieveByQueryAsync(commPrefPredicate, ctx).ConfigureAwait(false);  // this fills the context, incidentally filling the struct value

            Expression<Func<TruDatDboCorporateAccount, bool>> corpAcctPredicate = corpAcct => corpAcct.Id == ownerRec.Result.CorporateAccountId;
            var corpAccount = await this.RetrieveByQueryAsync(corpAcctPredicate, ctx).ConfigureAwait(false);
            if (null != corpAccount.Result && corpAccount.IsValid)
            {
                Expression<Func<TruDatDboCorporateAccountAddress, bool>> corpAcctAddrPredicate = corpAddrAcct => corpAddrAcct.CorporateAccountId == corpAccount.Result.Id;
                var corpAddrAccount = await this.RetrieveManyByQueryAsync(corpAcctAddrPredicate, ctx).ConfigureAwait(false);

                Expression<Func<TruDatDboCorporateAccountCampaignInstance, bool>> corpAcctCampaignPredicate = corpAddrCmpgn => corpAddrCmpgn.CorporateAccountId == corpAccount.Result.Id;
                _ = await this.RetrieveManyByQueryAsync(corpAcctCampaignPredicate, ctx).ConfigureAwait(false);
            }

            Expression<Func<TruDatDboOwnerCharity, bool>> charityPredicate = charity => charity.OwnerId == ownerId;
            var charity = await this.RetrieveByQueryAsync(charityPredicate, ctx).ConfigureAwait(false);

            if (null != charity.Result && charity.IsValid)
            {
                Expression<Func<TruDatDboCharity, bool>> charityPredicate1 = cp => cp.Id == charity.Result.CharityId;
                var charity1 = await this.RetrieveManyByQueryAsync(charityPredicate1, ctx).ConfigureAwait(false);

                Expression<Func<TruDatDboCharityCountry, bool>> charityCountryPredicate = ccp => ccp.Id == charity.Result.CharityId;
                _ = await this.RetrieveManyByQueryAsync(charityCountryPredicate, ctx).ConfigureAwait(false);

                Expression<Func<TruDatDboCharityState, bool>> charityStatePredicate = ccp => ccp.CharityId == charity.Result.CharityId;
                _ = await this.RetrieveManyByQueryAsync(charityStatePredicate, ctx).ConfigureAwait(false);
            }

            Expression<Func<TruDatDboOwnerFailedPaymentDatum, bool>> failedPmtPredicate = fpd => fpd.OwnerId == ownerId;
            _ = await this.RetrieveByQueryAsync(failedPmtPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerLanguagePreference, bool>> languageOwnerPredicate = lp => lp.OwnerId == ownerId;
            var langPreference = await this.RetrieveByQueryAsync(languageOwnerPredicate, ctx).ConfigureAwait(false);

            if (null != langPreference.Result && langPreference.IsValid)
            {
                Expression<Func<TruDatDboLanguage, bool>> languagePredicate = lp => lp.Id == langPreference.Result.LanguageId;
                _ = await this.RetrieveByQueryAsync(languagePredicate, ctx).ConfigureAwait(false);
            }

            Expression<Func<TruDatDboOwnerPendingRateChange, bool>> pendingRatePredicate = prc => prc.OwnerId == ownerId;
            _ = await this.RetrieveByQueryAsync(pendingRatePredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerVisionClaimSyncStatus, bool>> claimSyncPredicate = csp => csp.OwnerId == ownerId;
            _ = await this.RetrieveByQueryAsync(claimSyncPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerVisionPolicyMigrationStatus, bool>> policyMigrationPredicate = pmp => pmp.OwnerId == ownerId;
            _ = await this.RetrieveByQueryAsync(policyMigrationPredicate, ctx).ConfigureAwait(false);

            // Now for the lists
            Expression<Func<TruDatDboOwnerAddress, bool>> addressPredicate = ap => ap.OwnerId == ownerId;
            var addresses = await this.RetrieveManyByQueryAsync(addressPredicate, ctx).ConfigureAwait(false);

            if (null != addresses.Result)
            {
                foreach (var addr in addresses.Result)
                {
                    Expression<Func<TruDatDboState, bool>> statePredicate = stateRec => stateRec.Id == addr.StateId;
                    _ = await this.RetrieveByQueryAsync(statePredicate, ctx);
                }
            }

            Expression<Func<TruDatDboOwnerAssociation, bool>> associationPredicate = ap => ap.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(associationPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerAttribute, bool>> ownerAttrPredicate = oa => oa.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(ownerAttrPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerCharityEffective, bool>> ownerCharityEffectivePredicate = ocep => ocep.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(ownerCharityEffectivePredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerCorporateAccountHistory, bool>> corpAcctHistoryPredicate = cah => cah.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(corpAcctHistoryPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboOwnerVisionClaimMigrationStatus, bool>> migrationStatusPredicate = msp => msp.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(migrationStatusPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyRateFactorEffective, bool>> rateEffectvePredicate = rep => rep.OwnerId == ownerId;
            _ = await this.RetrieveManyByQueryAsync(rateEffectvePredicate, ctx).ConfigureAwait(false);

            return await this.RetrievePetsByOwnerAsync(ownerRec.Result, ctx);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwner>> RetrievePetsByOwnerAsync(TruDatDboOwner owner, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(owner, fn => null != owner, "Owner Record cannot be null");
        var ctx = this.EnsureContext(context);

        Expression<Func<TruDatDboPet, bool>> petPredicate = p => p.OwnerId == owner.Id;
        var pets = await this.RetrieveManyByQueryAsync(petPredicate, ctx).ConfigureAwait(false);

        EvaluateArgument.Execute(pets, fn => pets.IsValid && null != pets.Result, "No pets found for the owner");

        foreach (var pet in pets.Result!)
        {
            _ = await this.RetrieveByIdAsync<TruDatDboBreed, int, TruDatDboContext>(pet.BreedId, ctx).ConfigureAwait(false);

            if (null != pet.PawPrintHistoryId)
            {
                Expression<Func<TruDatDboStatus, bool>> pawaprintStatusPredicate = ppsp => ppsp.Id == pet.PawPrintHistoryId;
                pet.PawPrintHistory = await this.RetrieveByQueryAsync(pawaprintStatusPredicate, ctx).ConfigureAwait(false);
            }

            if (null != pet.WorkingPetId)
            {
                Expression<Func<TruDatDboWorkingPet, bool>> workingPetPredicate = wpp => wpp.Id == pet.WorkingPetId;
                _ = await this.RetrieveByQueryAsync(workingPetPredicate, ctx).ConfigureAwait(false);
            }

            Expression<Func<TruDatDboPetAttribute, bool>> petAttrPredicate = pa => pa.PetId == pet.Id;
            _ = await this.RetrieveManyByQueryAsync(petAttrPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicy, bool>> petPolicyPredicate = pp => pp.PetId == pet.Id;
            var petPolicy = await this.RetrieveByQueryAsync(petPolicyPredicate, ctx).ConfigureAwait(false);

            EvaluateArgument.Execute(petPolicy, fn => petPolicy.IsValid && null != petPolicy.Result, "No pet Policy found for the owner");
            var petPolicyId = petPolicy.Result!.Id;

            // pet Policy Tree -> this is the last of section the tree, for now.
            Expression<Func<TruDatDboPolicy, bool>> policyPredicate = p => p.Id == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboAge, bool>> policyAgePredicate = pa => pa.Id == petPolicy.Result!.PolicyAgeId;
            _ = await this.RetrieveByQueryAsync(policyAgePredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyCancelInfo, bool>> policyCancelInfoPredicate = ppci => ppci.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyCancelInfoPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyClinic, bool>> policyClinicPredicate = clinic => clinic.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyClinicPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyPartner, bool>> policyPartnerPredicate = ppp => ppp.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyPartnerPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyReferral, bool>> petPolicyReferralPredicate = ppr => ppr.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(petPolicyReferralPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyVoucher, bool>> policyVoucherPredicate = pvp => pvp.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyVoucherPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyWebPartner, bool>> policyWebPartnerPredicate = ppwp => ppwp.PetPolicyId == petPolicyId;
            _ = await this.RetrieveByQueryAsync(policyWebPartnerPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboClaim, bool>> claimPredicate = cp => cp.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(claimPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyAction, bool>> petPolicyActionPredicate = ppa => ppa.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyActionPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyAssociation, bool>> petPolicyAssnPredicate = pps => pps.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyAssnPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyAttribute, bool>> petePolicyAttrPredicate = ppa => ppa.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petePolicyAttrPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyCost, bool>> petPolicyCostPredicate = ppc => ppc.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyCostPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyRateAdjustment, bool>> petPolicyRAPredicate = ppra => ppra.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyRAPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyRateFactorEffective, bool>> petPolicyRateEffPredicate = ppre => ppre.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyRateEffPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyRatePendingChange, bool>> petPolicyRatePendingPredicate = pprp => pprp.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyRatePendingPredicate, ctx).ConfigureAwait(false);

            Expression<Func<TruDatDboPetPolicyTagNumber, bool>> petPolicyTagPredicate = ppt => ppt.PetPolicyId == petPolicyId;
            _ = await this.RetrieveManyByQueryAsync(petPolicyTagPredicate, ctx).ConfigureAwait(false);
        }

        return this.GenerateReturnValue(ReturnValue<TruDatDboOwner>.From(owner), "Unable to retrieve Pet Trees");
    }

    public async Task<ReturnValue<List<TruDatDboClinic>>> RetrieveClinicsByPostalCodeAsync(string postalCode, TruDatDboContext? context = null)
    {
        try
        {
            Expression<Func<TruDatDboClinic, bool>> predicate = clinic => clinic.Zipcode == postalCode && clinic.Validated;
            var hospitals = await this.EnsureContext(context).Clinics.Where(predicate).ToListAsync().ConfigureAwait(false);

            if (null == hospitals || 0 == hospitals.Count)
            {
                var postalCodeSubstring = postalCode.TrimLastCharacter();
                while (!string.IsNullOrEmpty(postalCodeSubstring))
                {
                    predicate = clinic => null != clinic.Zipcode && clinic.Zipcode.StartsWith(postalCodeSubstring) && clinic.Validated;
                    hospitals = await this.EnsureContext(context).Clinics.Where(predicate).ToListAsync().ConfigureAwait(false);
                    if (0 != hospitals.Count)
                    {
                        break;
                    }

                    postalCodeSubstring = postalCode.TrimLastCharacter();
                }
            }

            EvaluateArgument.Execute(hospitals, fn => null != hospitals, $"No hospitals found for {postalCode}");
            EvaluateArgument.Execute(hospitals, fn => 0 != hospitals!.Count, $"No hospitals found for {postalCode} II");

            return ReturnValue<List<TruDatDboClinic>>.From(hospitals!);
        }
        catch (SqlException sqex)
        {
            return ReturnValue<List<TruDatDboClinic>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (System.Exception ex)
        {
            return ReturnValue<List<TruDatDboClinic>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboAge>> RetrieveAgeByIdAsync(int id, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => 0 < id && 35 > id, $"Age Id must be between 1 and 34. Received {id}");

        var ctx = this.EnsureContext(context);

        var age = await this.RetrieveByIdAsync<TruDatDboAge, int, TruDatDboContext>(id, ctx).ConfigureAwait(false);

        return this.GenerateReturnValue(age, $"Unable to retrieve Age by id {id}");
    }

    public async Task<ReturnValue<TruDatDboAge>> RetrieveAgeByNameAsync(string name, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(name, fn => !string.IsNullOrEmpty(name), $"Age name must be valid. Received {name}");

        var ctx = this.EnsureContext(context);

        var lowName = name.ToLower();
        Expression<Func<TruDatDboAge, bool>> predicate = fn => fn.Name.ToLower().Equals(lowName);
        var age = await this.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);

        return this.GenerateReturnValue(age, $"Unable to retrieve Age by name {name}");
    }
}