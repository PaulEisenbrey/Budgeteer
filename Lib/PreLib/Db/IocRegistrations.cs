using Microsoft.Extensions.DependencyInjection;

using Database.Aquarium.Crud.Dbo;
using Database.Aquarium.Crud.Interfaces;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Billing.DataIntegration;
using Database.Trupanion.Crud.Billing.Dbo;
using Database.Trupanion.Crud.Claims.Dbo;
using Database.Trupanion.Crud.EnterpriseCatalog.Dbo;
using Database.Trupanion.Crud.Geography2.Dbo;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Crud.Product.Dbo;
using Database.Trupanion.Crud.PurchaseProcess.Dbo;
using Database.Trupanion.Crud.Quote.Dbo;
using Database.Trupanion.Crud.TestData.AnnualNotification;
using Database.Trupanion.Crud.TestData.NameSource;
using Database.Trupanion.Crud.TestData.PolicyTesting;
using Database.Trupanion.Crud.TestData.PricingFactor;
using Database.Trupanion.Crud.TestData.QaLib;
using Database.Trupanion.Crud.TestData.RateCardConfig;
using Database.Trupanion.Crud.TruDat.Billing;
using Database.Trupanion.Crud.TruDat.Claim;
using Database.Trupanion.Crud.TruDat.Dbo;
using Database.Trupanion.Crud.TruDat.PolicyAdmin;
using Database.Trupanion.Crud.TruDat.TruBiz;
using Database.Trupanion.Projections.Builders;
using Database.Trupanion.Projections.Builders.Interfaces;

namespace Database;

public static class IocRegistrations
{
    public static IServiceCollection AddCrudRegistrations(this IServiceCollection services)
    {
        services.AddTransient<IBillingDataIntegrationCrud, BillingDataIntegrationCrud>();
        services.AddTransient<IBillingDboCrud, BillingDboCrud>();
        services.AddTransient<IClaimsDboCrud, ClaimsDboCrud>();
        services.AddTransient<IEnterpriseCatalogDboCrud, EnterpriseCatalogDboCrud>();
        services.AddTransient<IGeography2DboCrud, Geography2DboCrud>();
        services.AddTransient<IPolicyTestingCrud, PolicyTestingCrud>();
        services.AddTransient<IProductDboCrud, ProductDboCrud>();
        services.AddTransient<IPurchaseProcessDboCrud, PurchaseProcessDboCrud>();
        services.AddTransient<IPurchaseProcessDboProjectionCrud, PurchaseProcessDboProjectionCrud>();
        services.AddTransient<IQuoteDboCrud, QuoteDboCrud>();
        services.AddTransient<ITestDataAnnualNotificationCrud, TestDataAnnualNotificationCrud>();
        services.AddTransient<ITestDataNameSourceCrud, TestDataNameSourceCrud>();
        services.AddTransient<ITestDataPricingFactorCrud, TestDataPricingFactorCrud>();
        services.AddTransient<ITestDataQaLibCrud, TestDataQaLibCrud>();
        services.AddTransient<ITestDataRateCardConfigCrud, TestDataRateCardConfigCrud>();
        services.AddTransient<ITruDatBillingCrud, TruDatBillingCrud>();
        services.AddTransient<ITruDatClaimCrud, TruDatClaimCrud>();
        services.AddTransient<ITruDatDboCrud, TruDatDboCrud>();
        services.AddTransient<ITruDatDboProjectionCrud, TruDatDboProjectionCrud>();
        services.AddTransient<ITruDatPolicyAdminCrud, TruDatPolicyAdminCrud>();
        services.AddTransient<ITruDatPolicyAdminProjectionsCrud, TruDatPolicyAdminProjectionsCrud>();
        services.AddTransient<ITruDatTruBizCrud, TruDatTruBizCrud>();

        services.AddTransient<IContextGenerator, ContextGenerator>();
        services.AddTransient<IAgeProjectionBuilder, AgeProjectionBuilder>();
        services.AddTransient<IBreedProjectionBuilder, BreedProjectionBuilder>();
        services.AddTransient<IClinicBuilder, ClinicBuilder>();
        services.AddTransient<IClinicProjectionBuilder, ClinicProjectionBuilder>();

        services.AddTransient<IOwnerBuilder, OwnerBuilder>();
        services.AddTransient<IOwnerProjectionBuilder, OwnerProjectionBuilder>();

        services.AddTransient<IPolicyAdminPolicyHolderBuilder, PolicyAdminPolicyHolderBuilder>();
        services.AddTransient<IPolicyAdminPolicyHolderProjectionBuilder, PolicyAdminPolicyHolderProjectionBuilder>();
        services.AddTransient<IZipcodeProjectionBuilder, ZipcodeProjectionBuilder>();

        services.AddTransient<IAquariumPolicyLifeCycleDboCrud, AquariumPolicyLifeCycleDboCrud>();
        services.AddTransient<IAquariumPolicyLifeCycleDboProjectionCrud, AquariumPolicyLifeCycleDboProjectionCrud>();
        services.AddTransient<IAquariumClaimsDboCrud, AquariumClaimsDboCrud> ();

        return services;
    }
}