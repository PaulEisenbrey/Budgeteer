using Database.Trupanion.Context;
using Database.Trupanion.Entity.VisionMigration.Dbo;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces
{
    internal interface IVisionMigrationDboCrud
    {
        Task<ReturnValue<VmDboSegmentOwner>> RetrieveSegmentOwnerById(int ownerId, int segmentId, VisionMigrationDboContext? ctx = null);
        Task<ReturnValue<List<VmDboSegmentOwner>>> RetrieveSegmentOwners(int segmentTypeId, VisionMigrationDboContext? tdContext = null);
        Task<ReturnValue<List<VmDboSegmentOwner>>> RetrieveSegmentOwnersBySegmentId(int segmentId, VisionMigrationDboContext? ctx = null);
    }
}