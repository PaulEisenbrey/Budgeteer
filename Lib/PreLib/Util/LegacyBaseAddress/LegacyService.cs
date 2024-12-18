using System.ComponentModel;

using Utilities.Constants.Strings;

namespace Utilities.LegacyBaseAddress;

public enum LegacyService
{
    uninitialized = 0,

    [Description(StringSpace.LegacyServiceBaseStrings.billingService)]
    billing,

    [Description(StringSpace.LegacyServiceBaseStrings.enterpriseCatelogService)]
    ecat,

    [Description(StringSpace.LegacyServiceBaseStrings.paymentService)]
    payment,

    [Description(StringSpace.LegacyServiceBaseStrings.petNavGatewayService)]
    petNavGateway,

    [Description(StringSpace.LegacyServiceBaseStrings.policyService)]
    policy,

    [Description(StringSpace.LegacyServiceBaseStrings.policyAdminService)]
    policyAdmin,

    [Description(StringSpace.LegacyServiceBaseStrings.productService)]
    product,

    [Description(StringSpace.LegacyServiceBaseStrings.promoService)]
    promo,

    [Description(StringSpace.LegacyServiceBaseStrings.salesLeadService)]
    salesLead,

    [Description(StringSpace.LegacyServiceBaseStrings.workflowService)]
    workflow,

    outofrance
}