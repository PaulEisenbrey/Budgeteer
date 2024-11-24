namespace Utilities.Constants.Enum;

public enum LockRequiredOperationResultId
{
    FailedNotAssigned,
    FailedAssignedToOtherUser,
    FailedCurrentlyBeingProcessed,
    FailedInUseByOtherUser,
    FailedFailedToLockCustomEntity,
    FailedFinalized
}