using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITruDatDboCrud : IQaLibCrud
{
    Task<ReturnValue<TruDatDboAge>> RetrieveAgeByIdAsync(int id, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboAge>> RetrieveAgeByNameAsync(string name, TruDatDboContext? context = null);
    ReturnValue<List<TruDatDboBreed>> RetrieveAllBreeds(bool activeOnly = false, TruDatDboContext? context = null);
    Task<ReturnValue<List<TruDatDboClinic>>> RetrieveClinicsByPostalCodeAsync(string postalCode, TruDatDboContext? context = null);
    Task<ReturnValue<List<TruDatDboOwnerVisionPolicyMigrationStatus>>> RetrieveMigratedOwnersAsync(TruDatDboContext? tdContext = null);
    Task<ReturnValue<List<TruDatDboOwner>>> RetrieveMultipleOwnersAsync(IEnumerable<int> ownerIds, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByEmailAsync(string emailAddress, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByIdAsync(int ownerId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByPersonIdAsync(Guid personId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerByPolicyNumberAsync(string policyNumber, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeAsync(ReturnValue<TruDatDboOwner> ownerRec, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeByEmailAsync(string emailAddress, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrieveOwnerTreeByOwnerIdAsync(int ownerId, TruDatDboContext? context = null);
    Task<ReturnValue<TruDatDboOwner>> RetrievePetsByOwnerAsync(TruDatDboOwner owner, TruDatDboContext? context = null);
}