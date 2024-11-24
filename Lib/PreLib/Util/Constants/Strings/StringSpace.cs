using System.Text.RegularExpressions;

namespace Utilities.Constants.Strings;

public static class StringSpace
{
    public static class ConnectionStrings
    {
        public static string TruDatConnection => "TruDatConnectionString";

        public static string TestDataConnection => "TestDataConnectionString";


        public static string BillingConnection = "BillingConnectionString";

        public static string CommServicesConnection => "CommServicesConnectionString";

        public static string ClaimsConnection => "ClaimsConnectionString";

        public static string EnterpriseCatalogConnection => "EnterpriseCatalogConnectionString";

        public static string Geography2Connection => "Geography2ConnectionString";

        public static string ProductConnection => "ProductConnectionString";

        public static string AquariumClaimsConnection => "AquariumClaimsConnectionString";

        public static string AquariumPolicyConnection => "AquariumPolicyConnectionString";

        public static string AquariumPolicyQuoteConnection => "AquariumPolicyQuoteConnectionString";

        public static string AquariumPolicyInteractionConnection => "AquariumPolicyInteractionConnectionString";

        public static string AquariumPolicyPaymentConnection => "AquariumPolicyPaymentsConnectionString";

        public static string AquariumPolicyNotesConnection => "AquariumPolicyNotesConnectionString";

        public static string ReportingConnection => "ReportingConnectionString";

        public static string VisionMigrationConnection => "VisionMigrationConnectionString";

        public static string CLUConnection => "CluConnectionString";
    }

    public static class AppSettings
    {
        public static string OutputDirectory => @"D:\_work\Docs\Vision Datamigration Project";
    }

    public static class ZipCodeStrings
    {
        public static string postalCode = "INVALID";
        public static readonly string usa = "USA";
        public static readonly string canada = "CAN";
        public static readonly string aus = "AUS";

        public static readonly string usaRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
        public static readonly string canRegEx = @"^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
        public static readonly string ausRegEx = @"^(0[289][0-9]{2})|([1345689][0-9]{3})|(2[0-8][0-9]{2})|(290[0-9])|(291[0-4])|(7[0-4][0-9]{2})|(7[8-9][0-9]{2})$";

        public static readonly string invalid = "INVALID";
    }

    public static class PhoneStrings
    {
        public static readonly string ValidAustraliaNumber = "[0][234578][0-9]{8}?";
        public static readonly string ValidNorthAmericaNumber = "^[2-9][0-8][0-9][2-9][0-9]{6}?";
    }

    public static class MessageProperties
    {
        public const string OriginalPublishTopic = "OriginalPublishTopic";
        // Left as "TriggeringMessageId" for backwards compatibility.
        public const string ParentMessageId = "TriggeringMessageId";
        public const string OriginatingUserId = "OriginatingUserId";
        public const string RetryCustomStatus = "__RetryCustomstatus__";
    }

    public static class HttpUsers
    {
        public const string ModifyBillingUser = "f13f3bd42be940d68e77077f498b48d9:JL1NDT";
    }
    public static class HttpHeaders
    {
        public const string TrupanionUser = "x-trupanion-user";
        public const string TrupanionRequestId = "x-trupanion-requestid";

        public const string TrupanionTruIdOriginator = "x-trupanion-truid-origin";
        public const string TrupanionTruIdOriginatorHash = "x-trupanion-truid-origin-hash";

        public const string CorrelationId = "x-trupanion-CorrelationId";
        public const string OnBehalfOfUserId = "x-trupanion-OnBehalfOfUserId";
        public const string ParentMessageId = "x-trupanion-ParentMessageId";
    }

    public static class LegacyServiceBaseStrings
    {
        public const string billingServiceName = "BillingService";
        public const string billingService = "billing.services.trupanion.com";
        public const string hospitalService = "hospital.services.trupanion.com";
        public const string hospitalServiceName = "HospitalService";
        public const string policyService = "policy.services.trupanion.com";
        public const string enterpriseCatelogService = "ecat.services.trupanion.com";
        public const string paymentService = "payment.services.trupanion.com";
        public const string policyAdminService = "policyadmin.services.trupanion.com";
        public const string productService = "product.services.trupanion.com";
        public const string productServiceName = "ProductService";
        public const string promoService = "promo.services.trupanion.com";
        public const string promoServiceName = "PromoService";
        public const string salesLeadServiceName = "SalesLeadService";
        public const string salesLeadService = "saleslead.services.trupanion.com";
        public const string contactServiceName = "ContactService";
        public const string contactService = "sales.services.trupanion.com";
        public const string petNavGatewayServiceName = "PetNavGatewayService";
        public const string petNavGatewayService = "petnavgateway.services.trupanion.com";
        public const string workflowServiceName = "WorkflowService";
        public const string workflowService = "workflow.services.trupanion.com";
    }

    public static class WorkflowUrls
    {
        public const string CreateTask = "v2/createtaskcommands";
        public const string TransitionTask = "v2/transitiontaskcommands";
    }

    public static class PetNavGateway
    {
        public const string SaveContact = "inboundsales/v4/savecontactcommands";
        public const string SubmitEfCommand = "billing/v2/eftcommandrepository/submit";
        public const string GetCoordinateRequest = "geography/v3/retrievegeocodeforpostalcodeasync";
    }

    public static class LegacyBillingUrls
    {
        public const string CreateAccount = "accounts/accountcreationinfoes";
    }

    public static class LegacyHospitalUrls
    {
        public const string proximitySearch = "hospitalapi/v3/proximitysearch";
    }

    public static class PromoCodeUrls
    {
        public const string RequestPromoCodes = "v2/certificatecodes";

        public const string RequestDiscountCodes = "v2/discountcodes";
    }

    public static class LegacySalesLeadUrls
    {
        public const string Create = "v1/people";
        public const string SaveContactPolicies = "v2/contactapi/save";
        public const string SaveOpportunity = "v1/opportunityapi/save";
        public const string SaveOpportunityWin = "v1/opportunityapi/win";
    }

    public static class ProductServiceUrls
    {
        public const string CalculatePlanPremium = "plans/v4/calculateplanpremium";
    }

    public static class LegacyRTN
    {
        public static string RTN => "021000021";

        public static string CanadaRTN => "12312";

        public static string AUSRTN => "12312";
    }

    public static class LegacyBankCode
    {
        public static string? BankCode => null;

        public static string CanadaBankCode => "113";
    }

    public static class PetCharacteristic
    {
        public const string Male = "Male";
        public const string Female = "Female";
        public const string Dog = "Dog";
        public const string Cat = "Cat";
        public const string Altered = "Spayed/neutered";
        public const string Intact = "Intact";
        public const string ServiceAnimal = "Service animal";
        public const string Vip = "Vip";
        public const string ConvertedFromTrial = "Has converted from trial";
        public const string NotConvertedFromTrial = "Did not converted from trial";
        public const string DiscountTypeHospital = "Hospital Employee";
        public const string DiscountTypeTerritoryPartner = "Territory Partner";
        public const string DiscountTypeTrupanionEmployee = "Trupanion Employee";
        public const string DiscountTypeWebLinkPartner = "Web Link Partner Referral";
        public const string DiscountTypeAffinity = "Affinity Group Member";
    }
}
