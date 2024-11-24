using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.VisionMigration.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.VisionMigration.Dbo;

public class VisionMigrationDboCrud : QaLibCrud, IQaLibCrud, IVisionMigrationDboCrud
{
    public VisionMigrationDboCrud(ILogManager logMgr) : base(logMgr)
    {
        
    }

    public async Task<ReturnValue<VmDboSegmentOwner>> RetrieveSegmentOwnerById(int ownerId, int segmentId, VisionMigrationDboContext? ctx = null)
    {
        EvaluateArgument.Execute(ownerId, fn => 0 < ownerId, "OwnerId must be a positive non-zero integer");
        EvaluateArgument.Execute(segmentId, fn => 0 < segmentId, "segmentId must be a positive non-zero integer");

        try
        {
            Expression<Func<VmDboSegmentOwner, bool>> predicate = owner => owner.OwnerId == ownerId && owner.SegmentId == segmentId;
            var owner = await this.RetrieveByQueryAsync(predicate, ctx).ConfigureAwait(false);

            return this.GenerateReturnValue(owner, $"Unable to find owner for Id {ownerId} and segment {segmentId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<VmDboSegmentOwner>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<VmDboSegmentOwner>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<VmDboSegmentOwner>>> RetrieveSegmentOwnersBySegmentId(int segmentId, VisionMigrationDboContext? ctx = null)
    {
        EvaluateArgument.Execute(segmentId, fn => 0 < segmentId, "segmentId must be a positive non-zero integer");

        try
        {
            Expression<Func<VmDboSegmentOwner, bool>> predicate = owner => owner.SegmentId == segmentId;
            var ownerList = await this.RetrieveManyByQueryAsync(predicate, ctx).ConfigureAwait(false);

            return this.GenerateReturnValue(ownerList,
                $"Null owner returned for for segment search {segmentId}",
                $"Unable to find any owners in segment {segmentId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<VmDboSegmentOwner>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<VmDboSegmentOwner>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<VmDboSegmentOwner>>> RetrieveSegmentOwners(int segmentTypeId, VisionMigrationDboContext? tdContext = null)
    {
        EvaluateArgument.Execute(segmentTypeId, fn => 0 < segmentTypeId, $"Segment Type Id must be a non-zero positive integer. Passed Value: {segmentTypeId}");

        Expression<Func<VmDboSegment, bool>> predicate = seg => seg.SegmentTypeId == segmentTypeId;
        var segOwners = await this.RetrieveManyByQueryAsync(predicate, tdContext).ConfigureAwait(false);

        EvaluateArgument.Execute(segOwners, fn => segOwners.IsValid, segOwners.ErrorText);
        EvaluateArgument.Execute(segOwners, fn => null != segOwners.Result, $"No owner ids found in segment type {segmentTypeId}");

        var segIds = segOwners.Result!.Select(x => x.Id).ToList();
        try
        {
            Expression<Func<VmDboSegmentOwner, bool>> predicate2 = seg => segIds.Contains(seg.SegmentId);
            var sos = await this.RetrieveManyByQueryAsync(predicate2, tdContext).ConfigureAwait(false);

            return this.GenerateReturnValue(sos,
                "Null list returned looking for owner records",
                $"No owners found for segment type {segmentTypeId}");
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<VmDboSegmentOwner>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<VmDboSegmentOwner>>.FromError(ex);
        }
    }
}