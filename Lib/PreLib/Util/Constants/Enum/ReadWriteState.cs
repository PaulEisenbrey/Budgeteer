namespace Utilities.Constants.Enum;

public enum ReadWriteState
{
    ReadonlyNotAssigned = 0,
    ReadonlyAssignedToOtherUser = 1,
    ReadonlyCurrentlyBeingProcessed = 2,
    ReadonlyInUseByOtherUser = 3,
    ReadonlyFailedToLockCustomEntity = 4,
    ReadonlyFinalized = 6,
    Writeable = 7
}