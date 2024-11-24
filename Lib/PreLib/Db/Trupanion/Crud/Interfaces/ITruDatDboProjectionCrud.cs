using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatDboProjectionCrud : IQaLibCrud
{
    Task<ReturnValue<TruDatDboAgeProjection>> RetrieveAgeProjectionByIdAsync(int id, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboAgeProjection>> RetrieveAgeProjectionByNameAsync(string name, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboBreedProjection>> RetrieveBreedProjectionByIdAsync(int breedId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboBreedProjection>> RetrieveBreedProjectionByNameAsync(string breedName, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboClinicProjection>> RetrieveClinicProjectionByIdAsync(int clinicId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwnerAddressProjection>> RetrieveOwnerAddressProjectionByOwnerIdAsync(int ownerId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByEMailAddressAsync(string emailAddress, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByOwnerIdAsync(int ownerId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByPersonIdAsync(Guid personId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwnerProjection>> RetrieveOwnerProjectionByPolicyNumberAsync(string policyNumber, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboPetPolicyProjection>> RetrievePetPolicyProjectionByIdAsync(int id, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboPetPolicyProjection>> RetrievePetPolicyProjectionByPetIdAsync(int petId, TruDatDboContext? context = null);
    Task<ReturnValue<List<TruDatDboPetProjection>>> RetrievePetProjectionsByOwnerIdAsync(int ownerId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboZipcodeProjection>> RetrieveZipcodeProjectionByZipcodeAsync(string zip, TruDatDboContext? context = null);
}