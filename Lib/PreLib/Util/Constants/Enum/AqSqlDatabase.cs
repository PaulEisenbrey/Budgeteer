using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum AqSqlDatabase
{
    uninitialized = 0,

    [Description("uat-vis-weu-trup-policy-lifecycle-sqldb")]
    PolicyLifecycle,

    [Description("uat-vis-weu-trup-quote-sqldb")]
    Quote,

    [Description("uat-vis-weu-trup-claims-sqldb")]
    Claims,

    [Description("uat-vis-weu-trup-interaction-service-sqldb")]
    Interaction,

    [Description("uat-vis-weu-trup-payments-sqldb")]
    Payments,

    [Description("uat-vis-weu-visn-notes-sqldb")]
    Notes
}