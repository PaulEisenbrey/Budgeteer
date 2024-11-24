namespace Utilities.Constants.Enum;

public enum ProcessExecutionResult
{
    NotComplete,
    CreatedButNotStarted,
    CreatedAndStarted,
    RanToCompletion,
    RanToUserTask,
    RanToWaitTask,
    RanThroughLocation,
    RanToIntervention,
    RanUntilTimeout,
    Cancelled,
    InvalidProcessInstance,
    SystemIssuesPreventMonitoring,
    ProcessInstanceDeleted
}