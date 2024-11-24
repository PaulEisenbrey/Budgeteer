using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TestData.AnnualNotification;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITestDataAnnualNotificationCrud : IQaLibCrud
{
    Task<ReturnValue<List<TestDataAnnualNotificationAddress>>> RetrieveAllAddressesAsync(TestDataAnnualNotificationContext? context = null);
    Task<ReturnValue<List<TestDataAnnualNotificationAddress>>> RetrieveAllAddressesByStateAbbrAsync(string? stateAbbr, TestDataAnnualNotificationContext? context = null);
    Task<ReturnValue<List<TestDataAnnualNotificationConfiguration>>> RetrieveConfigurationItemsAsync(TestDataAnnualNotificationContext? context = null);
    Task<ReturnValue<List<TestDataAnnualNotificationPet>>> RetrievePetsAsync(TestDataAnnualNotificationContext? context = null);
}