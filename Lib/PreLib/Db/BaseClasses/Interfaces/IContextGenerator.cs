using Database.Aquarium.Context;
using Database.TestData.PurchaseProcessDbo;
using Database.Trupanion.Context;
using Database.Trupanion.Projections.PurchaseProcess.Dbo;
using Utilities.ReturnType;

using TrupanionDatabase.Aquarium.Context;

namespace Database.BaseClasses.Interfaces;

public interface IContextGenerator
{
    BillingDataIntegrationContext GenerateBillingDataIntegrationContext();

    BillingDboContext GenerateBillingDboContext();

    ClaimsDboContext GenerateClaimsDboContext();

    ClaimsPetStampContext GenerateClaimsPetStampContext();

    CLUDboContext GenerateCluDboContext();

    CommServicesRecipientContext GenerateCommRecipientContext();

    CommServicesDboContext GenerateCommServicesDboContext();

    CommServicesCpgContext GenerateCommServicesCpgContext();

    EnterpriseCatalogDboContext GenerateEnterpriseCatalogDboContext();

    Geography2DboContext GenerateGeography2DboContext();

    ProductDboContext GenerateProductDboContext();

    ProductPricingContext GenerateProductPricingContext();

    TestDataDboContext GenerateTestDataDboContext();

    TestDataNameSourceContext GenerateTestDataNameSourceContext();

    TestDataPolicyTestingContext GenerateTestDataPolicyTestingContext();

    TestDataPricingFactorContext GenerateTestDataPricingFactorContext();

    TestDataProductVersionContext GenerateTestDataProductVersionContext();

    TestDataQaLibContext GenerateTestDataQaLibContext();

    TestDataRateCardConfigContext GenerateTestDataRateCardConfigContext();

    TestDataRateCardContext GenerateTestDataRateCardContext();

    TestDataTestHarnessContext GenerateTestDataTestHarnessContext();

    TestDataWorkflowAutomationContext GenerateTestDataWorkflowAutomationContext();

    TestDataWorkflowSystemTestContext GenerateTestDataWorkflowSystemTestContext();

    TruDatClaimContext GenerateClaimContext();

    TruDatDboContext GenerateTruDatDBOContext();

    TruDatGroupPriceContext GenerateTruDatGroupPriceContext();

    TruDatPaymentContext GenerateTruDatPaymentContext();

    TruDatPolicyAdminContext GenerateTruDatPolicyAdminContext();

    TruDatPolicyContext GenerateTruDatPolicyContext();

    TruDatPriceContext GenerateTruDatPriceContext();

    TruDatPromoContext GenerateTruDatPromoContext();

    TruDatCoverageContext GenerateCoverageContext();

    TruDatPaymentContext GeneratePaymentContext();

    TruDatPolicyAdminContext GeneratePolicyAdminContext();

    TruDatBillingContext GenerateTruDatBillingContext();

    TruDatClaimBotContext GenerateTruDatClaimBotContext();

    TruDatClaimContext GenerateTruDatClaimContext();

    TruDatCoverageContext GenerateTruDatCoverageContext();

    VisionMigrationBillingContext GenerateVisionMigrationBillingContext();

    VisionMigrationClaimsContext GenerateVisionMigrationClaimsContext();

    VisionMigrationCommServiceContext GenerateVisionMigrationCommServiceContext();

    VisionMigrationDataMapContext GenerateVisionMigrationDataMapContext();

    VisionMigrationDboContext GenerateVisionDboContext();

    VisionMigrationInteractionPolicyDataContext GenerateVisionMigrationInteractionPolicyDataContext();

    VisionMigrationLegacyEmailContext GenerateVisionMigrationLegacyEmailContext();

    VisionMigrationLifecycleCoreContext GenerateVisionMigrationLifecycleCoreContext();

    VisionMigrationObfuscationContext GenerateVisionMigrationObfuscationContext();

    VisionMigrationQuoteContext GenerateVisionMigrationQuoteContext();

    VisionMigrationStagingContext GenerateVisionMigrationStagingContext();

    VisionMigrationVisionContext GenerateVisionMigrationVisionContext();

    AquariumPolicyLifeCycleDboContext GenerateAqPolicyLifecycleContext();
    AquariumClaimsContext GenerateAquariumClaimsContext();
}
