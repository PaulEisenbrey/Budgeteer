using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

using Database.Aquarium.Context;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.Aggregates;
using Utilities;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.ReturnType;
using TrupanionDatabase.Aquarium.Context;

namespace Database.BaseClasses;

public class ContextGenerator : IContextGenerator, ISingletonSvc
{
    private readonly ILogManager logManager;
    public ContextGenerator(ILogManager logMgr)
    {

        this.logManager = logMgr;
        this.Logger = logManager.GenerateLogger();

    }

    protected ILog? Logger { get; private set; }

    public AquariumClaimsContext GenerateAquariumClaimsContext() => new();

    public BillingDataIntegrationContext GenerateBillingDataIntegrationContext() => new();

    public BillingDboContext GenerateBillingDboContext() => new();

    public ClaimsDboContext GenerateClaimsDboContext() => new();

    public ClaimsPetStampContext GenerateClaimsPetStampContext() => new();

    public CLUDboContext GenerateCluDboContext() => new();

    public CommServicesRecipientContext GenerateCommRecipientContext() => new();

    public CommServicesDboContext GenerateCommServicesDboContext() => new();

    public CommServicesCpgContext GenerateCommServicesCpgContext() => new();

    public EnterpriseCatalogDboContext GenerateEnterpriseCatalogDboContext() => new();

    public Geography2DboContext GenerateGeography2DboContext() => new();

    public ProductDboContext GenerateProductDboContext() => new();

    public ProductPricingContext GenerateProductPricingContext() => new();

    public TestDataDboContext GenerateTestDataDboContext() => new();

    public TestDataNameSourceContext GenerateTestDataNameSourceContext() => new();

    public TestDataPolicyTestingContext GenerateTestDataPolicyTestingContext() => new();

    public TestDataPricingFactorContext GenerateTestDataPricingFactorContext() => new();

    public TestDataProductVersionContext GenerateTestDataProductVersionContext() => new();

    public TestDataQaLibContext GenerateTestDataQaLibContext() => new();

    public TestDataRateCardConfigContext GenerateTestDataRateCardConfigContext() => new();

    public TestDataRateCardContext GenerateTestDataRateCardContext() => new();

    public TestDataTestHarnessContext GenerateTestDataTestHarnessContext() => new();

    public TestDataWorkflowAutomationContext GenerateTestDataWorkflowAutomationContext() => new();

    public TestDataWorkflowSystemTestContext GenerateTestDataWorkflowSystemTestContext() => new();

    public TruDatClaimContext GenerateClaimContext() => new();

    public TruDatDboContext GenerateTruDatDBOContext() => new();

    public TruDatGroupPriceContext GenerateTruDatGroupPriceContext() => new();

    public TruDatPaymentContext GenerateTruDatPaymentContext() => new();

    public TruDatPolicyAdminContext GenerateTruDatPolicyAdminContext() => new();

    public TruDatPolicyContext GenerateTruDatPolicyContext() => new();

    public TruDatPriceContext GenerateTruDatPriceContext() => new();

    public TruDatPromoContext GenerateTruDatPromoContext() => new();

    public TruDatCoverageContext GenerateCoverageContext() => new();

    public TruDatPaymentContext GeneratePaymentContext() => new();

    public TruDatPolicyAdminContext GeneratePolicyAdminContext() => new();

    public TruDatBillingContext GenerateTruDatBillingContext() => new();

    public TruDatClaimBotContext GenerateTruDatClaimBotContext() => new();

    public TruDatClaimContext GenerateTruDatClaimContext() => new();

    public TruDatCoverageContext GenerateTruDatCoverageContext() => new();

    public VisionMigrationBillingContext GenerateVisionMigrationBillingContext() => new();

    public VisionMigrationClaimsContext GenerateVisionMigrationClaimsContext() => new();

    public VisionMigrationCommServiceContext GenerateVisionMigrationCommServiceContext() => new();

    public VisionMigrationDataMapContext GenerateVisionMigrationDataMapContext() => new();

    public VisionMigrationDboContext GenerateVisionDboContext() => new();

    public VisionMigrationInteractionPolicyDataContext GenerateVisionMigrationInteractionPolicyDataContext() => new();

    public VisionMigrationLegacyEmailContext GenerateVisionMigrationLegacyEmailContext() => new();

    public VisionMigrationLifecycleCoreContext GenerateVisionMigrationLifecycleCoreContext() => new();

    public VisionMigrationObfuscationContext GenerateVisionMigrationObfuscationContext() => new();

    public VisionMigrationQuoteContext GenerateVisionMigrationQuoteContext() => new();

    public VisionMigrationStagingContext GenerateVisionMigrationStagingContext() => new();

    public VisionMigrationVisionContext GenerateVisionMigrationVisionContext() => new();

    public AquariumPolicyLifeCycleDboContext GeneratePolicyLifecycleContext() => new();

    public AquariumPolicyLifeCycleDboContext GenerateAqPolicyLifecycleContext() => new();

    public WorkflowDboContext GenerateWorkflowContext() => new();

    public ReturnValue<List<T>> GenerateReturnValue<T>(ReturnValue<List<T>> resultToTest, string nullResults, string noResults) where T : class, new() =>
        !resultToTest.IsValid
            ? ReturnValue<List<T>>.FromError(resultToTest.ErrorText)
            : null == resultToTest.Result
                ? ReturnValue<List<T>>.FromError(nullResults)
                : 0 == resultToTest.Result!.Count()
                    ? ReturnValue<List<T>>.FromError(noResults)
                    : ReturnValue<List<T>>.From(resultToTest.Result!);

    public ReturnValue<T> GenerateReturnValue<T>(ReturnValue<T> resultToTest, string nullResults) where T : class, new() =>
        !resultToTest.IsValid
            ? ReturnValue<T>.FromError(resultToTest.ErrorText)
            : null == resultToTest.Result
                ? ReturnValue<T>.FromError(nullResults)
                : ReturnValue<T>.From(resultToTest.Result!);

    protected TransactionScope GenerateNoLockTransaction()
    {
        var transactionOptions = new TransactionOptions
        {
            IsolationLevel = IsolationLevel.ReadUncommitted,
        };

        //create the transaction scope, passing our options in
        return new TransactionScope(
            TransactionScopeOption.Required,
            transactionOptions,
            TransactionScopeAsyncFlowOption.Enabled);
    }

    protected T HandleException<T>(Exception ex) where T : class, new()
    {
        ConsoleOutPut.WriteVerbose($"{ex.Message}. {ex.InnerException}", true);
        return new T();
    }

    protected T EnsureContext<T>(T? ctx) where T : DbContext, new() => ctx ?? new T();

    protected int RegionIdFromStateCode(string state)
    {
        int regionId = 0;

        switch (state)
        {
            case "AL": regionId = 1; break;
            case "AK": regionId = 2; break;
            case "AS": regionId = 3; break;
            case "AZ": regionId = 4; break;
            case "AR": regionId = 5; break;
            case "CA": regionId = 6; break;
            case "CO": regionId = 7; break;
            case "CT": regionId = 8; break;
            case "DE": regionId = 9; break;
            case "DC": regionId = 10; break;
            case "FL": regionId = 11; break;
            case "GA": regionId = 12; break;
            case "GU": regionId = 13; break;
            case "HI": regionId = 14; break;
            case "ID": regionId = 15; break;
            case "IL": regionId = 16; break;
            case "IN": regionId = 17; break;
            case "IA": regionId = 18; break;
            case "KS": regionId = 19; break;
            case "KY": regionId = 20; break;
            case "LA": regionId = 21; break;
            case "ME": regionId = 22; break;
            case "MD": regionId = 23; break;
            case "MA": regionId = 24; break;
            case "MI": regionId = 25; break;
            case "MN": regionId = 26; break;
            case "MS": regionId = 27; break;
            case "MO": regionId = 28; break;
            case "MT": regionId = 29; break;
            case "NE": regionId = 30; break;
            case "NV": regionId = 31; break;
            case "NH": regionId = 32; break;
            case "NJ": regionId = 33; break;
            case "NM": regionId = 34; break;
            case "NY": regionId = 35; break;
            case "NC": regionId = 36; break;
            case "ND": regionId = 37; break;
            case "MP": regionId = 38; break;
            case "OH": regionId = 39; break;
            case "OK": regionId = 40; break;
            case "OR": regionId = 41; break;
            case "PA": regionId = 42; break;
            case "PR": regionId = 43; break;
            case "RI": regionId = 44; break;
            case "SC": regionId = 45; break;
            case "SD": regionId = 46; break;
            case "TN": regionId = 47; break;
            case "TX": regionId = 48; break;
            case "VI": regionId = 49; break;
            case "UT": regionId = 50; break;
            case "VT": regionId = 51; break;
            case "VA": regionId = 52; break;
            case "WA": regionId = 53; break;
            case "WV": regionId = 54; break;
            case "WI": regionId = 55; break;
            case "WY": regionId = 56; break;
            default:
                regionId = 0;
                break;
        }

        return regionId;
    }

    protected (List<int> ownerids, List<Guid?> personIds, List<int?> customerIds, List<int?> corpAccountIds) ParseOutIdsFromSegmentData(List<SegmentAndOwnerIds> sowners) =>
        (sowners.Select(so => so.Id).ToList(),
        sowners.Select(so => so.PersonId).ToList(),
        sowners.Select(so => so.CustomerId).ToList(),
        sowners.Where(so => null != so.CorporateAccountId).Select(so => so.CorporateAccountId).ToList());

    protected string SqlExceptionFormat(SqlException sqex) =>
        $"SQL Exception: {sqex.Message}. [Error Number {sqex.Number} - Line Number {sqex.LineNumber}]. {sqex.InnerException}";
}