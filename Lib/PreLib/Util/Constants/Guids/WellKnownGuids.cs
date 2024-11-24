namespace Utilities.Constants.Guids;

public static class WellKnownGuids
{
    public static class ApprovalStatus
    {
        public static Guid InDevelopment => Guid.Parse("4E9C9A4A-06C8-47C2-8763-770A35449AB8");
        public static Guid InReadyForRelease => Guid.Parse("BE623BFC-473B-4020-9579-3AA117D83CD7");
        public static Guid Released => Guid.Parse("05A4A438-1217-4997-9F70-072273772610");
    }

    public static class ApprovalForm
    {
        public static Guid FormId = Guid.Parse("A5C6F9AE-15FA-446E-8ACA-8E6674324062");
    }

    public static class Brand
    {
        public static Guid Trupanion = Guid.Parse("4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A");
        public static Guid TrupanionAustralia = Guid.Parse("4C2B3AD7-CF9C-4BA1-9C48-E3C86E5A1422");
        public static Guid IntegrationTestBrand = Guid.Parse("8089674F-4064-45BD-A2F8-36C8805E95A9");
        public static Guid TestBrandName = Guid.Parse("90595566-943B-4D9F-88CD-B1F9B93966AF");
    }

    public static class WellKnownPlatformServices
    {
        public static readonly Guid TruId = Guid.Parse("5d083089-87fd-4bdb-a81d-a44c018a2c5e");

        public static readonly Guid ServiceBusRabbitMq = Guid.Parse("d0828a7c-02f1-4a29-b5eb-8273a63c115c");

        public static readonly Guid ServiceBusWindowsAzure = Guid.Parse("55ccf001-b459-4561-aa28-4d8d22a15755");

        public static readonly Guid MessageBrokerRabbitMq = Guid.Parse("2d9f9d32-607d-4dc5-a6df-ec12d3a9faf4");

        public static readonly Guid DefaultConnectionStringSet = Guid.Parse("e5138f39-93c6-449c-a893-49f9733ee1f7");

        public static readonly Guid DocumentManagementSystem = Guid.Parse("fdc2851a-56b1-4fd2-b6e7-a42901329b5f");

        public static readonly Guid ExchangeEmailService = Guid.Parse("791e3884-71b9-49b4-8bc4-a3c70189ee32");

        public static readonly Guid DataSynchronizerService = Guid.Parse("c35e3ad0-985c-4f5a-92a3-a3cc016db36b");

        public static readonly Guid WorkflowService = Guid.Parse("8aaf152b-99c2-461d-af69-a4200159689a");

        public static readonly Guid DistributedCacheService = Guid.Parse("0fdacf32-6281-49ad-9ac2-a4210156e43f");

        public static readonly Guid TrupanionWebServices = Guid.Parse("d517ec4f-64c6-42fc-b74b-a42e01787101");

        public static readonly Guid SearchServices = Guid.Parse("0313e153-4947-481b-a53a-a43d0136e326");

        public static readonly Guid DefaultLoggingConfiguration = Guid.Parse("dcb703f1-ab93-4ffe-b46d-a53a011bdfc6");

        public static readonly Guid BillingSystem = Guid.Parse("87c8ca47-4463-430f-9596-2e841af5d18d");

        public static readonly Guid CommServices = Guid.Parse("5b1f8bef-c959-4881-b530-a567015d2e8c");

        public static readonly Guid WebSitePortal = Guid.Parse("e0815601-de7e-4766-8351-a3ea017bcea8");

        public static readonly Guid GoogleAnalyticsClientApi = Guid.Parse("9ae85982-3ba4-440e-826d-a5e2014d9be6");

        public static readonly Guid ClaimbotService = Guid.Parse("10d2c823-17fe-40d5-86f2-a6b8010e4b54");

        public static readonly Guid Policy = Guid.Parse("045f43d8-aafe-4e04-a3a8-a6d5012f0e6d");

        public static readonly Guid Geography = Guid.Parse("92895342-a26f-431e-bfab-a6d601123e22");

        public static readonly Guid MarketoConfiguration = Guid.Parse("28728aff-c783-4b71-8b7b-a6b800519a6d");

        public static readonly Guid HospitalPlatform = Guid.Parse("397e4091-6d37-444d-a388-a6f8017e66f6");

        public static readonly Guid ClaimPlatform = Guid.Parse("2b601dca-97d1-4392-af76-a6f8017d9724");

        public static readonly Guid SalesLead = Guid.Parse("1c9d5fe2-f130-4e47-b47b-a6f801854567");

        public static readonly Guid FeatureCutover = Guid.Parse("ea4281bb-2956-4ef4-9e6d-a6fd016d585e");

        public static readonly Guid Promo = Guid.Parse("3cdb4eba-ba33-4c1c-8797-a701012c58ff");

        public static readonly Guid Quoting = Guid.Parse("bab85fae-2429-4360-b7b3-a70e011b31ad");

        public static readonly Guid EmailCampaignManagement = Guid.Parse("c675becc-a637-4a57-823d-a71b0120193f");

        public static readonly Guid TruBizService = Guid.Parse("185edc25-7f23-4281-b0c8-a72701530463");

        public static readonly Guid Notation = Guid.Parse("da565219-424c-49a6-8b15-a73e014a9483");

        public static readonly Guid DataAdjustment = Guid.Parse("3c14e5fa-be62-46a9-bb60-a7460016bde7");

        public static readonly Guid QaLib = Guid.Parse("86faf229-7f25-4e4b-ae8d-a657011910fa");

        public static readonly Guid TestUtilities = Guid.Parse("8df49af5-5d82-4b1e-97e2-d62ebb8ef873");

        public static readonly Guid SitecoreClient = Guid.Parse("be7cfe66-f3f0-4018-8e37-a75b0120c9e5");

        public static readonly Guid LegacyPolicy = Guid.Parse("7b63ab60-5148-48c0-af23-a767016e49bc");

        public static readonly Guid Session = Guid.Parse("ff27ca71-1a51-4365-b5ca-a76d01130f62");

        public static readonly Guid ClaimAutoAdjudicationConfiguration = Guid.Parse("38375b61-5998-4f45-9fed-a76a010b0317");

        public static readonly Guid EnterpriseCatalog = Guid.Parse("931ae702-7fb4-4552-9c73-a774011bd6b5");

        public static readonly Guid InboundSales = Guid.Parse("5322deb5-1784-4ca5-b156-a7c4014c6b10");

        public static readonly Guid EnterpriseLoggingConfiguration = Guid.Parse("5e96a5e7-aa8c-449a-b576-a7ee013606fb");

        public static readonly Guid Telephony = Guid.Parse("b7066288-95da-4df2-b2c3-a80f001ec2f7");

        public static readonly Guid StateFarm = Guid.Parse("de164fd8-2717-4e5b-b2a6-a81f0115bcd0");

        public static readonly Guid TruExAgentService = Guid.Parse("01dc6f78-70f3-457c-90f0-a95f01043f30");

        public static readonly Guid LegacyPlatform = Guid.Parse("be626419-4495-412d-bf57-a8f8012cdb7f");

        public static readonly Guid TrupanionExpressHospitalGateway = Guid.Parse("60DCEDCC-4C65-411E-B423-7D7AD12039EB");

        public static readonly Guid TrupanionExpressAttendant = Guid.Parse("5e68b15a-edf5-4ca4-8bf0-a91401552a31");

        public static readonly Guid LoyaltyProgram = Guid.Parse("974f49f3-e028-47ef-8f2f-a92001675e9b");

        public static readonly Guid Product = Guid.Parse("7074690e-9fb6-468d-b784-a922011b34e5");

        public static readonly Guid Survey = Guid.Parse("9d0c9a9b-30a6-49cf-909a-a93d014d80ba");

        public static readonly Guid ContentGeneration = Guid.Parse("7c04332b-ca87-4086-9199-a95e0127cc78");

        public static readonly Guid TrupanionExpressHMT = Guid.Parse("d06380b1-f7c8-4f60-a38b-a97d010780b0");

        public static readonly Guid WebSales = Guid.Parse("d8634349-3f1b-4061-bb91-a9810108106a");

        public static readonly Guid TruTimeTfsAttendant = Guid.Parse("b725a874-8d4d-4239-bfb5-a9900113f6bc");

        public static readonly Guid QaPriceTestService = Guid.Parse("93e35d08-468d-4741-a476-a850012ced67");

        public static readonly Guid WelcomeKit = Guid.Parse("ee697b20-1020-4db9-acdf-a996016b43a6");

        public static readonly Guid Rayne = Guid.Parse("992c8c21-e861-4f81-8fef-a9a7010a66c3");

        public static readonly Guid QaRateAdjustmentTestService = Guid.Parse("7d5d9d02-c44c-4acd-bf7c-a88d016e5583");

        public static readonly Guid PetNavApi = Guid.Parse("d9a6949c-8c33-4d22-ad46-a9a80186612a");

        public static readonly Guid WebSiteGateway = Guid.Parse("8ca3b09d-8992-4d79-ba65-a9c40120189c");

        public static readonly Guid DataPointApiClient = Guid.Parse("953b185f-5f39-419a-822d-a9dc01430c5f");

        public static readonly Guid PetNavGateway = Guid.Parse("43aa9b4a-fc9f-48df-98e3-a9e001882d65");

        public static readonly Guid Payment = Guid.Parse("86ef8921-f99f-4853-8549-da26c9d99245");

        public static readonly Guid MedicalConditions = Guid.Parse("096781CA-A9A1-4791-993C-A1D211D0DA49");

        public static readonly Guid PublicApiGateway = Guid.Parse("fea5f595-d781-42c8-a3bc-9119005037ca");

        public static readonly Guid Azure = Guid.Parse("4182F0B5-3E63-418A-AECB-8DB42402C0CA");

        public static readonly Guid Attribution = Guid.Parse("67A6A1CC-8764-4A29-A97A-2504D3E3ACA3");

        public static readonly Guid CRMDataAccess = Guid.Parse("C7A6B048-3417-4A6D-A705-7D0AB20209FF");
    }

    public static class CharacteristicType
    {
        public static Guid CatBreed = Guid.Parse("46A2749A-6A1A-42D9-9E81-1277CE197B92");
        public static Guid DogBreed = Guid.Parse("057DC4B4-4B45-4FC9-B002-0BC516A37464");
        public static Guid AgeBand = Guid.Parse("389D09C4-A023-485D-AA1C-E73FB8088749");
        public static Guid Species = Guid.Parse("B7CB8049-E98D-49A6-B00D-0E93C12D3C19");
        public static Guid Gender = Guid.Parse("EE677C81-0D9E-4E78-A46E-0F2FADA2DF83");
        public static Guid SpayNeuter = Guid.Parse("9A759490-B488-40FD-AA16-920D27BDF5AA");
        public static Guid ServiceAnimal = Guid.Parse("BC76AF25-B350-4142-ABDC-C90C3A392DDD");
        public static Guid Vip = Guid.Parse("791D0764-547F-4F46-8525-8E1FD55C0762");
        public static Guid Discount = Guid.Parse("B97099EB-FE20-4F4F-B10D-37EAB7C9B3AA");
        public static Guid PrimaryCareLocation = Guid.Parse("C420FCC9-8D86-4B63-AADC-162DDDE0846A");
        public static Guid PrimaryPolicyHolderLocation = Guid.Parse("5FEAF673-251B-4CC8-AB86-87DC580AD177");
        public static Guid ConvertedFromTrial = Guid.Parse("5FD0AF3B-1923-44F1-9E5F-13E3487EFBD2");
        public static Guid GroupPlan = Guid.Parse("882C9EBB-9ED7-4BA7-8850-EDFBF5F6C698");
    }

    public static class CharityId
    {
        public static Guid FarleyFoundation = Guid.Parse("D9A5EB0B-5306-40E3-ADCD-794B413F75A3");
        public static Guid SPCABiscuitFund = Guid.Parse("1D4EBBBB-1B68-434C-B9E5-8D3423D40A0C");
        public static Guid AmericanHumaneAssociation = Guid.Parse("6FA5C496-20A1-41A2-B690-E0EFA3149EBA");
        public static Guid RedRover = Guid.Parse("78C5D463-3859-4AA6-B910-14C68F62DC3A");
        public static Guid BestFriendsAnimalSociety = Guid.Parse("7DDDA9CB-FD64-48FA-8898-114A788CF560");
        public static Guid SpeakingOfDogs = Guid.Parse("9372BF9B-E3F4-43D8-8366-9A273AE5158A");
        public static Guid SeattleHumane = Guid.Parse("30C2B29A-07CC-4359-94E6-E99E2B0CF200");
        public static Guid PawsForPeople = Guid.Parse("F95D059E-340C-4049-AB5E-2F2830592E07");
    }

    public static class ConditionEffectId
    {
        public static Guid IncludesWhenMet = Guid.Parse("FA693167-05AA-4F0C-85B2-E1B9D0375E96");
        public static Guid ExcludesWhenMet = Guid.Parse("2CD6F17D-3677-4064-B3E3-8B2DCFD21194");
    }

    public static class QaLibId
    {
        public static Guid DevelopmentId = Guid.Parse("FC0B0793-0E1F-42F3-AF7F-6C3A3E2C0766");
        public static Guid TestId = Guid.Parse("01EEBB8D-D3B8-4FB4-A474-4E3CBA064E4C");
    }

    public static class PetCharacteristicTypes
    {
        public static Guid CatBreed => Guid.Parse("46A2749A-6A1A-42D9-9E81-1277CE197B92");
        public static Guid DogBreed => Guid.Parse("057DC4B4-4B45-4FC9-B002-0BC516A37464");
        public static Guid AgeBand => Guid.Parse("389D09C4-A023-485D-AA1C-E73FB8088749");
        public static Guid Species => Guid.Parse("B7CB8049-E98D-49A6-B00D-0E93C12D3C19");
        public static Guid Gender => Guid.Parse("EE677C81-0D9E-4E78-A46E-0F2FADA2DF83");
        public static Guid Spay_Neuter => Guid.Parse("9A759490-B488-40FD-AA16-920D27BDF5AA");
        public static Guid ServiceAnimal => Guid.Parse("BC76AF25-B350-4142-ABDC-C90C3A392DDD");
        public static Guid Vip => Guid.Parse("791D0764-547F-4F46-8525-8E1FD55C0762");
        public static Guid Discount => Guid.Parse("B97099EB-FE20-4F4F-B10D-37EAB7C9B3AA");
        public static Guid PrimaryCareProviderLocation => Guid.Parse("C420FCC9-8D86-4B63-AADC-162DDDE0846A");
        public static Guid PrimaryPolicyholderLocation => Guid.Parse("5FEAF673-251B-4CC8-AB86-87DC580AD177");
        public static Guid ConvertedFromTrial => Guid.Parse("5FD0AF3B-1923-44F1-9E5F-13E3487EFBD2");
        public static Guid GroupPlanParticipant => Guid.Parse("882C9EBB-9ED7-4BA7-8850-EDFBF5F6C698");
    }

    public static class QuoteBrands
    {
        public static Guid TrupUSA => Guid.Parse("4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A");
        public static Guid TrupCAN => Guid.Parse("3FB3788E-1C81-4339-B841-FFA6D26DE4D8");
        public static Guid TrupAUS => Guid.Parse("B25B9A90-D514-4F77-BF03-06E6B4D5CCAF");
    }

    public static class TruBizEnterpriseEvent
    {
        public static readonly Guid PurchaseProcessComplete = Guid.Parse("B3370835-98F9-47EA-8108-484EE4CF399D");
        public static readonly Guid CertificateIssueComplete = Guid.Parse("8A6342A0-A84D-4847-AF73-FAEABB06600F");
    }

    public static class PN3WorkflowIds
    {
        // Sales 
        public static Guid InboundSalesEnrollment = Guid.Parse("7100A036-D373-4EBE-BF49-DA4820C16585");

        // Billing 
        public static Guid PayNowReschedule = Guid.Parse("30318692-E872-46C2-BE62-CAAD02B233D5");
        public static Guid UpdatePayment = Guid.Parse("0F4DEC78-A9E9-48A6-9705-6E9EB502DD3C");
        public static Guid Charity = Guid.Parse("36E3FFEC-3E1F-4314-BB10-845FB382D996");

        // Policy Admin 
        public static Guid UpdatePolicyholderAddress = Guid.Parse("B5EA5422-9278-48E9-82B9-47673482353A");
        public static Guid UpdatePolicyholderContactInfo = Guid.Parse("F17E24EB-FA89-4ACC-B6FB-4284E06FC28F");
        public static Guid UpdatePetPolicyCoverageOptions = Guid.Parse("DE5A3621-829B-4CB0-82B4-4FDDD380F8EA");
        public static Guid ResendPolicyDocuments = Guid.Parse("AA0E904F-A919-4E03-9D43-47BFF2516CA0");
        public static Guid EditPetCharacteristics = Guid.Parse("5A0891AD-49C6-4270-9826-360DA0A900FA");
        public static Guid MemberHospitalChange = Guid.Parse("D52CCDDA-9953-4D4C-AE40-29BB68490A4A");
        public static Guid ProRateWaitingPeriods = Guid.Parse("415B43E1-5E68-4373-A58A-34B14056988E");
        public static Guid PetCancellation = Guid.Parse("791D0D87-F330-4151-A7CF-328A555BFEC5");
    }

    public static class WellKnownBrands
    {
        public static readonly Guid Trupanion = new Guid("4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A");

        public static readonly Guid TrupanionAustralia = new Guid("4C2B3AD7-CF9C-4BA1-9C48-E3C86E5A1422");
    }

    public static class WellknownPN3EnrollmentIds
    {
        public static Guid CoverageSummaryFeeTypeId = Guid.Parse("fc71b7a3-321d-4309-865c-a087aef41d57");

        public static Guid SpeciesCharacteristicTypeId = new Guid("B7CB8049-E98D-49A6-B00D-0E93C12D3C19");

        public static Guid CatBreedCharacteristicTypeId = new Guid("46a2749a-6a1a-42d9-9e81-1277ce197b92");

        public static Guid DogBreedCharacteristicTypeId = new Guid("057dc4b4-4b45-4fc9-b002-0bc516a37464");

        public static Guid AgeBandCharacteristicTypeId = new Guid("389d09c4-a023-485d-aa1c-e73fb8088749");

        public static Guid Cat = new Guid("24BB9B9B-61B7-4C2A-B5A5-ADCC8377029B");

        public static Guid Dog = new Guid("F3B4FAFA-3728-4525-9E71-F6BCED67DAA4");

        public static Guid SpayedNeutered = new Guid("4311c900-4df5-4cad-9e71-20437952b635");

        public static Guid Intact = new Guid("28DE8E9A-AA9D-4659-A855-24E687D0E0C5");

        public static Guid ServiceAnimal = new Guid("14e3811b-78d5-4bf3-9e14-57f2b254e57d");

        public static Guid Male = new Guid("D05EE7B3-F805-491D-8112-2C9B16E10446");

        public static Guid Female = new Guid("B8F742FA-53F6-4DFF-B7CD-069C2111088A");

        public static Guid BabyPet = new Guid("37D06449-5299-4AD4-9D78-CC8AAA4CFADD");

        public static Guid YoungAnimal0 = new Guid("37D06449-5299-4AD4-9D78-CC8AAA4CFADD");

        public static Guid YoungAnimal1 = new Guid("92BA2FF1-61B8-45BE-A5D0-D7562EEDEDE5");

        public static Guid YoungAnimal2 = new Guid("6844314F-0A0F-471B-BAEA-B3E95BB8FA64");

        public static Guid YoungAnimal3 = new Guid("751DE4DC-E3FD-44A9-89BC-CB66B7519372");

        public static Guid TrialCharacteristicTypeId = new Guid("5FD0AF3B-1923-44F1-9E5F-13E3487EFBD2");

        public static Guid TrialConversion_True = new Guid("D31E258C-F2B1-45C6-BC86-78214752BD85");

        public static Guid TrialConversion_False = new Guid("ABA76296-2DBE-45A5-A765-0B017D336BD2");

        public static Guid HeardOfUsThroughVet = new Guid("5A0C2060-CB12-4073-B7D0-A44338D52954");
    }

    public static class WellKnownDurationTypes
    {
        public static readonly Guid Year = new Guid("5D74646D-5961-4A15-BB44-91DC495A62A1");

        public static readonly Guid Day = new Guid("07CEEB6F-7649-4CA3-AD06-AFC6A1E9D287");

        public static readonly Guid Month = new Guid("40ADDE59-57B1-4FE0-A9BF-B22F343E0FC4");
    }

    public static class PetTraits
    {
        public static Guid SpeciesCharacteristicTypeId = new Guid("B7CB8049-E98D-49A6-B00D-0E93C12D3C19"); // Species
        public static Guid CatBreedCharacteristicTypeId = new Guid("46a2749a-6a1a-42d9-9e81-1277ce197b92"); // Cat Breed
        public static Guid DogBreedCharacteristicTypeId = new Guid("057dc4b4-4b45-4fc9-b002-0bc516a37464"); // Dog Breed
        public static Guid AgeBandCharacteristicTypeId = new Guid("389d09c4-a023-485d-aa1c-e73fb8088749"); // Age Band

        public static Guid Cat = new Guid("24BB9B9B-61B7-4C2A-B5A5-ADCC8377029B");
        public static Guid Dog = new Guid("F3B4FAFA-3728-4525-9E71-F6BCED67DAA4");
        public static Guid SpayedNeutered = new Guid("4311c900-4df5-4cad-9e71-20437952b635");
        public static Guid Intact = new Guid("28DE8E9A-AA9D-4659-A855-24E687D0E0C5");
        public static Guid ServiceAnimal = new Guid("14e3811b-78d5-4bf3-9e14-57f2b254e57d");
        public static Guid Male = new Guid("D05EE7B3-F805-491D-8112-2C9B16E10446");
        public static Guid Female = new Guid("B8F742FA-53F6-4DFF-B7CD-069C2111088A");

        public static Guid BabyPet = new Guid("37D06449-5299-4AD4-9D78-CC8AAA4CFADD");

        // Characteristic IDs of Age bands of young animals, too young to breed.
        public static Guid YoungAnimal0 = new Guid("37D06449-5299-4AD4-9D78-CC8AAA4CFADD");

        public static Guid YoungAnimal1 = new Guid("92BA2FF1-61B8-45BE-A5D0-D7562EEDEDE5");
        public static Guid YoungAnimal2 = new Guid("6844314F-0A0F-471B-BAEA-B3E95BB8FA64");
        public static Guid YoungAnimal3 = new Guid("751DE4DC-E3FD-44A9-89BC-CB66B7519372");

        public static Guid TrialCharacteristicTypeId = new Guid("5FD0AF3B-1923-44F1-9E5F-13E3487EFBD2");

        // Has/Is converting from trial
        public static Guid ConvertFromTrial = new Guid("D31E258C-F2B1-45C6-BC86-78214752BD85");

        // Has/Is NOT converting from trial
        public static Guid Regular = new Guid("ABA76296-2DBE-45A5-A765-0B017D336BD2");
    }
}
