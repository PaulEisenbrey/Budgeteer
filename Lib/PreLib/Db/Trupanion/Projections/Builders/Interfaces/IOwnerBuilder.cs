using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IOwnerBuilder
{
    Task<ReturnValue<OwnerBuilder>> InitializeByEmailAddress(string emailAddress);
    Task<ReturnValue<OwnerBuilder>> InitializeByOwnerId(int ownerId);
    Task<ReturnValue<OwnerBuilder>> InitializeByPersonId(Guid personId);
    Task<ReturnValue<OwnerBuilder>> InitializeByPolicyNumber(string policyNumber);

    TruDatDboOwner Build { get; }
}