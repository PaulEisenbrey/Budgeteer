using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Extension.StringExtension;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TruDat.Dbo;

public class TruDatDboProjectionCrud : QaLibCrud, IQaLibCrud, ITruDatDboProjectionCrud
{
    public TruDatDboProjectionCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByOwnerIdAsync(int ownerId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a positive, non-zero integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var ownerRec = await ctx.Owners
                .Select(o => new TruDatDboOwnerProjection
                {
                    Id = o.Id,
                    BillingDayOfMonth = o.BillingDayOfMonth,
                    EmailAddress = o.EmailAddress,
                    EngineId = o.EngineId,
                    FirstName = o.FirstName,
                    HomePhone = o.HomePhone,
                    Inserted = o.Inserted,
                    IsStateFarmRelated = o.IsStateFarmRelated,
                    LastName = o.LastName,
                    PersonId = o.PersonId,
                    PolicyHolderUntil = o.PolicyHolderUntil,
                    PolicyNumber = o.PolicyNumber,
                    UniqueId = o.UniqueId,
                    Updated = o.Updated,
                    UserId = o.UserId
                })
                .FirstOrDefaultAsync(owner => owner.Id == ownerId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(ownerRec, fn => null != ownerRec, $"No Owner found for Id {ownerId}");

            return this.GenerateReturnValue<TruDatDboOwnerProjection>(ReturnValue<TruDatDboOwnerProjection>.From(ownerRec!), $"No Owner retrieved via OwnerId {ownerId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByPersonIdAsync(Guid personId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(personId, fn => Guid.Empty != personId, "Person Id must be a valid Guid");
        var ctx = this.EnsureContext(context);

        try
        {
            var ownerRec = await ctx.Owners
                .Select(o => new TruDatDboOwnerProjection
                {
                    Id = o.Id,
                    BillingDayOfMonth = o.BillingDayOfMonth,
                    EmailAddress = o.EmailAddress,
                    EngineId = o.EngineId,
                    FirstName = o.FirstName,
                    HomePhone = o.HomePhone,
                    Inserted = o.Inserted,
                    IsStateFarmRelated = o.IsStateFarmRelated,
                    LastName = o.LastName,
                    PersonId = o.PersonId,
                    PolicyHolderUntil = o.PolicyHolderUntil,
                    PolicyNumber = o.PolicyNumber,
                    UniqueId = o.UniqueId,
                    Updated = o.Updated,
                    UserId = o.UserId
                })
                .FirstOrDefaultAsync(owner => owner.PersonId == personId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(ownerRec, fn => null != ownerRec, $"No Owner found for Person Id {personId}");

            return this.GenerateReturnValue<TruDatDboOwnerProjection>(ReturnValue<TruDatDboOwnerProjection>.From(ownerRec!), $"No Owner retrieved via PersonId {personId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(ex);
        }
    }


    public async Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByPolicyNumberAsync(string policyNumber, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(policyNumber, fn => !string.IsNullOrEmpty(policyNumber), $"Policy Number must be a valid string. Received {policyNumber}");
        var ctx = this.EnsureContext(context);

        try
        {
            var lowPolicyNum = policyNumber.ToLower();
            var ownerRec = await ctx.Owners
                .Select(o => new TruDatDboOwnerProjection
                {
                    Id = o.Id,
                    BillingDayOfMonth = o.BillingDayOfMonth,
                    EmailAddress = o.EmailAddress,
                    EngineId = o.EngineId,
                    FirstName = o.FirstName,
                    HomePhone = o.HomePhone,
                    Inserted = o.Inserted,
                    IsStateFarmRelated = o.IsStateFarmRelated,
                    LastName = o.LastName,
                    PersonId = o.PersonId,
                    PolicyHolderUntil = o.PolicyHolderUntil,
                    PolicyNumber = o.PolicyNumber,
                    UniqueId = o.UniqueId,
                    Updated = o.Updated,
                    UserId = o.UserId
                })
                .FirstOrDefaultAsync(owner => owner.PolicyNumber.ToLower().Equals(lowPolicyNum))
                .ConfigureAwait(false);

            EvaluateArgument.Execute(ownerRec, fn => null != ownerRec, $"No Owner found for Policy Number {policyNumber}");

            return this.GenerateReturnValue<TruDatDboOwnerProjection>(ReturnValue<TruDatDboOwnerProjection>.From(ownerRec!), $"No Owner found for Policy Number {policyNumber}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByEMailAddressAsync(string emailAddress, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(emailAddress, fn => !string.IsNullOrEmpty(emailAddress), $"Email Address cannot be empty, Received {emailAddress}");
        var ctx = this.EnsureContext(context);

        try
        {
            var lowEmail = emailAddress.ToLower();
            var ownerRec = await ctx.Owners
                .Select(o => new TruDatDboOwnerProjection
                {
                    Id = o.Id,
                    BillingDayOfMonth = o.BillingDayOfMonth,
                    EmailAddress = o.EmailAddress,
                    EngineId = o.EngineId,
                    FirstName = o.FirstName,
                    HomePhone = o.HomePhone,
                    Inserted = o.Inserted,
                    IsStateFarmRelated = o.IsStateFarmRelated,
                    LastName = o.LastName,
                    PersonId = o.PersonId,
                    PolicyHolderUntil = o.PolicyHolderUntil,
                    PolicyNumber = o.PolicyNumber,
                    UniqueId = o.UniqueId,
                    Updated = o.Updated,
                    UserId = o.UserId
                })
                .FirstOrDefaultAsync(owner => !string.IsNullOrEmpty(owner.EmailAddress) && owner.EmailAddress.ToLower().Equals(lowEmail))
                .ConfigureAwait(false);

            EvaluateArgument.Execute(ownerRec, fn => null != ownerRec, $"No Owner found for email {emailAddress}");

            return this.GenerateReturnValue<TruDatDboOwnerProjection>(ReturnValue<TruDatDboOwnerProjection>.From(ownerRec!), $"No Owner found for email {emailAddress}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwnerProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboAgeProjection>> RetrieveAgeProjectionByIdAsync(int id, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => 0 < id && 35 > id, $"Age Id must be between 1 and 34. Received {id}");

        var ctx = this.EnsureContext(context);

        try
        {
            var age = await ctx.Ages
                .Select(a => new TruDatDboAgeProjection
                {
                    Active = a.Active,
                    AgeYearFrom = a.AgeYearFrom,
                    Name = a.Name,
                    AgeYearTo = a.AgeYearTo,
                    Id = a.Id,
                    PetCharacteristicUniqueId = a.PetCharacteristicUniqueId,
                    ProductFactorInstanceUniqueId = a.ProductFactorInstanceUniqueId,
                    ValidForEnrollment = a.ValidForEnrollment
                })
                .FirstOrDefaultAsync(a1 => a1.Id == id && a1.Active)
                .ConfigureAwait(false);

            var ageRet = (null != age)
                ? ReturnValue<TruDatDboAgeProjection>.From(age)
                : ReturnValue<TruDatDboAgeProjection>.FromError($"No age found for id {id}");

            return this.GenerateReturnValue(ageRet, $"Unable to retrieve Age Projection by id {id}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboAgeProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboAgeProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboAgeProjection>> RetrieveAgeProjectionByNameAsync(string name, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(name, fn => !string.IsNullOrEmpty(name), $"Age name must be valid. Received {name}");

        var ctx = this.EnsureContext(context);

        var lowName = name.ToLower();
        var age = await ctx.Ages
            .Select(age => new TruDatDboAgeProjection
            {
                Active = age.Active,
                AgeYearFrom = age.AgeYearFrom,
                Name = age.Name,
                AgeYearTo = age.AgeYearTo,
                Id = age.Id,
                PetCharacteristicUniqueId = age.PetCharacteristicUniqueId,
                ProductFactorInstanceUniqueId = age.ProductFactorInstanceUniqueId,
                ValidForEnrollment = age.ValidForEnrollment
            })
            .FirstOrDefaultAsync(age => age.Name.ToLower().Equals(lowName)).ConfigureAwait(false);

        var ageRet = (null != age)
            ? ReturnValue<TruDatDboAgeProjection>.From(age)
            : ReturnValue<TruDatDboAgeProjection>.FromError($"No age found for id {name}");

        return this.GenerateReturnValue(ageRet, $"Unable to retrieve Age Projection by id {name}");
    }

    public async Task<ReturnValue<TruDatDboZipcodeProjection>> RetrieveZipcodeProjectionByZipcodeAsync(string zip, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(zip, fn => !string.IsNullOrEmpty(zip), $"Zipcode must be valid. Received {zip}");

        var ctx = this.EnsureContext(context);

        var lowZip = zip.ToLower();
        var zipcode = await ctx.Zipcodes
            .Select(zip => new TruDatDboZipcodeProjection
            {
                Active = zip.Active,
                County = zip.County,
                Lat = zip.Lat,
                Lon = zip.Lat,
                PlaceName = zip.PlaceName,
                StateId = zip.StateId,
                Zipcode1 = zip.Zipcode1
            })
            .FirstOrDefaultAsync(zip => !string.IsNullOrEmpty(zip.Zipcode1) && zip.Zipcode1.ToLower().Equals(lowZip)).ConfigureAwait(false);

        var zipRet = (null != zipcode)
            ? ReturnValue<TruDatDboZipcodeProjection>.From(zipcode)
            : ReturnValue<TruDatDboZipcodeProjection>.FromError($"No Zipcode found for zip {zip}");

        return this.GenerateReturnValue(zipRet, $"Unable to retrieve Zipcode Projection by id {zip}");
    }
    public async Task<ReturnValue<TruDatDboOwnerAddressProjection>> RetrieveOwnerAddressProjectionByOwnerIdAsync(int ownerId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a non-zero positive integer");

        var ctx = this.EnsureContext(context);

        try
        {
            var ownerAddr = await ctx.OwnerAddresses
                            .Select(o => new TruDatDboOwnerAddressProjection
                            {
                                Id = o.Id,
                                AddressLine2 = o.AddressLine2,
                                AddressLine3 = o.AddressLine3,
                                City = o.City,
                                Name = o.Name,
                                OwnerId = ownerId,
                                StateId = o.Id,
                                Zipcode = o.Zipcode
                            })
                            .OrderByDescending(oa => oa.Id)
                            .FirstOrDefaultAsync(ownerAddress => ownerAddress.OwnerId == ownerId)
                            .ConfigureAwait(false);

            EvaluateArgument.Execute(ownerAddr, fn => null != ownerAddr, $"No Owner Address found for Id {ownerId}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboOwnerAddressProjection>.From(ownerAddr!), $"No Owner Address retrieved via OwnerId {ownerId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboOwnerAddressProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboOwnerAddressProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<TruDatDboPetProjection>>> RetrievePetProjectionsByOwnerIdAsync(int ownerId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a non-zero positive integer");

        var ctx = this.EnsureContext(context);

        try
        {
            var pets = await ctx.Pets
                .Select(pet => new TruDatDboPetProjection
                {
                    Id = pet.Id,
                    OwnerId = pet.OwnerId,
                    BreedId = pet.BreedId,
                    DateOfBirth = pet.DateOfBirth,
                    Gender = pet.Gender,
                    Name = pet.Name ?? "Unknown",
                    PetFoodId = pet.PetFoodId,
                    UniqueId = pet.UniqueId,
                    WorkingPetId = pet.WorkingPetId
                })
                .Where(ownerAddress => ownerAddress.OwnerId == ownerId)
                .ToListAsync()
                .ConfigureAwait(false);

            EvaluateArgument.Execute(pets, fn => null != pets, $"No pets found for Owner Id {ownerId}");

            return this.GenerateReturnValue(ReturnValue<List<TruDatDboPetProjection>>.From(pets!), $"No Owner Address retrieved via OwnerId {ownerId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<TruDatDboPetProjection>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<TruDatDboPetProjection>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboBreedProjection>> RetrieveBreedProjectionByIdAsync(int breedId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(breedId, fn => 0 < breedId, "Breed Id must be a non-zero positive integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var breedProjection = await ctx.Breeds
                .Select(breed => new TruDatDboBreedProjection
                {
                    Id = breed.Id,
                    Active = breed.Active,
                    AnimalId = breed.AnimalId,
                    Name = breed.Name.NullIfEmpty() ?? "",
                    PetCharacteristicUniqueId = breed.PetCharacteristicUniqueId,
                    ProductFactorInstanceUniqueId = breed.ProductFactorInstanceUniqueId
                })
                .FirstOrDefaultAsync(br => br.Id == breedId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(breedProjection, fn => null != breedProjection, $"No Breed found for Breed Id {breedId}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboBreedProjection>.From(breedProjection!), $"No Breed Projection retrieved via BreedId {breedId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboBreedProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboBreedProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboClinicProjection>> RetrieveClinicProjectionByIdAsync(int clinicId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(clinicId, fn => 0 < clinicId, "Clinic Id must be a non-zero positive integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var clinicProjection = await ctx.Clinics
                .Select(clinic => new TruDatDboClinicProjection
                {
                    Id = clinic.Id,
                    Active = clinic.Active,
                    AddressLine2 = clinic.AddressLine2,
                    AddressLine3 = clinic.AddressLine3,
                    City = clinic.City,
                    ClinicRiskId = clinic.ClinicRiskId,
                    EnrolledPolicyCount = clinic.EnrolledPolicyCount,
                    Name = clinic.Name,
                    PartnerId = clinic.PartnerId,
                    StateId = clinic.StateId,
                    UniqueId = clinic.UniqueId,
                    Validated = clinic.Validated,
                    Zipcode = clinic.Zipcode
                })
                .FirstOrDefaultAsync(cl => cl.Id == clinicId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(clinicProjection, fn => null != clinicProjection, $"No Hospital (clinic) found for Clinic Id {clinicId}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboClinicProjection>.From(clinicProjection!), $"No Clinic Projection retrieved via Clinic Id {clinicId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboClinicProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboClinicProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboBreedProjection>> RetrieveBreedProjectionByNameAsync(string breedName, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(breedName, fn => !string.IsNullOrEmpty(breedName), "Breed name cannot be empty");
        var ctx = this.EnsureContext(context);

        try
        {
            var breedProjection = await ctx.Breeds
                .Select(breed => new TruDatDboBreedProjection
                {
                    Id = breed.Id,
                    Active = breed.Active,
                    AnimalId = breed.AnimalId,
                    Name = breed.Name,
                    PetCharacteristicUniqueId = breed.PetCharacteristicUniqueId,
                    ProductFactorInstanceUniqueId = breed.ProductFactorInstanceUniqueId
                })
                .FirstOrDefaultAsync(br => br.Name == breedName)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(breedProjection, fn => null != breedProjection, $"No Breed found for Breed Name {breedName}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboBreedProjection>.From(breedProjection!), $"No Breed Projection retrieved via BreedId {breedName}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboBreedProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboBreedProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboPetPolicyProjection>> RetrievePetPolicyProjectionByPetIdAsync(int petId, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(petId, fn => 0 < petId, "pet Id must be a non-zero positive integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var petPolicy = await ctx.PetPolicies
                .Select(pp => new TruDatDboPetPolicyProjection
                {
                    Id = pp.Id,
                    PetId = petId,
                    AdjustmentMonth = pp.AdjustmentMonth,
                    AdjustmentYear = pp.AdjustmentYear,
                    CoinsurancePercentage = pp.CoinsurancePercentage,
                    DocumentVersionId = pp.DocumentVersionId,
                    EngineVersionId = pp.EngineVersionId,
                    PlanId = pp.PlanId,
                    PolicyAgeId = pp.PolicyAgeId,
                    PolicyDate = pp.PolicyDate,
                    PolicyId = pp.PolicyId,
                    PolicyNumber = pp.PolicyNumber,
                    ProductEffectiveDateUtc = pp.ProductEffectiveDateUtc,
                    ProductId = pp.ProductId,
                    TagNumber = pp.TagNumber,
                    UniqueId = pp.UniqueId
                })
                .FirstOrDefaultAsync(pPolicy => pPolicy.PetId == petId)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(petPolicy, fn => null != petPolicy, $"No Pet Policy found for Pet Id {petId}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboPetPolicyProjection>.From(petPolicy!), $"No Pet Policy found for Pet Id {petId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboPetPolicyProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboPetPolicyProjection>.FromError(ex);
        }
    }

    public async Task<ReturnValue<TruDatDboPetPolicyProjection>> RetrievePetPolicyProjectionByIdAsync(int id, TruDatDboContext? context = null)
    {
        EvaluateArgument.Execute(id, fn => 0 < id, "pet policy Id must be a non-zero positive integer");
        var ctx = this.EnsureContext(context);

        try
        {
            var petPolicy = await ctx.PetPolicies
                .Select(pp => new TruDatDboPetPolicyProjection
                {
                    Id = pp.Id,
                    PetId = id,
                    AdjustmentMonth = pp.AdjustmentMonth,
                    AdjustmentYear = pp.AdjustmentYear,
                    CoinsurancePercentage = pp.CoinsurancePercentage,
                    DocumentVersionId = pp.DocumentVersionId,
                    EngineVersionId = pp.EngineVersionId,
                    PlanId = pp.PlanId,
                    PolicyAgeId = pp.PolicyAgeId,
                    PolicyDate = pp.PolicyDate,
                    PolicyId = pp.PolicyId,
                    PolicyNumber = pp.PolicyNumber,
                    ProductEffectiveDateUtc = pp.ProductEffectiveDateUtc,
                    ProductId = pp.ProductId,
                    TagNumber = pp.TagNumber,
                    UniqueId = pp.UniqueId
                })
                .FirstOrDefaultAsync(pPolicy => pPolicy.Id == id)
                .ConfigureAwait(false);

            EvaluateArgument.Execute(petPolicy, fn => null != petPolicy, $"No Pet Policy found for Id {id}");

            return this.GenerateReturnValue(ReturnValue<TruDatDboPetPolicyProjection>.From(petPolicy!), $"No Pet Policy found for Id {id}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<TruDatDboPetPolicyProjection>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<TruDatDboPetPolicyProjection>.FromError(ex);
        }
    }


}
