using Database.Trupanion.Entity.Aggregates;
using Database.Trupanion.Projections.TruDat.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Projections.Builders.Interfaces;

public interface IOwnerProjectionBuilder
{
    Task<ReturnValue<OwnerProjectionBuilder>> InitializeByEmailAddress(string emailAddress);
    Task<ReturnValue<OwnerProjectionBuilder>> InitializeByOwnerId(int ownerId);
    Task<ReturnValue<OwnerProjectionBuilder>> InitializeByPersonId(Guid personId);
    Task<ReturnValue<OwnerProjectionBuilder>> InitializeByPolicyNumber(string policyNumber);

    OwnerCollection Build { get; }
}