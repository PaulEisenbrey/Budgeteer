using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Entity.TestData.QaLib;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITestDataQaLibCrud : IQaLibCrud
{
    Task<ReturnValue<TestDataQaLibPendingEnrollment>> CreatePendingEnrollmentAsync(TestDataQaLibPendingEnrollment pendingEnrollment, TestDataQaLibContext? context = null);
    Task<ReturnValue<TestDataQaLibKeyValueConfiguration>> RetrieveKeyValueRowsAsync(string key, TestDataQaLibContext? context = null);
    Task<ReturnValue<TestDataQaLibPendingEnrollment>> RetrievePendingEnrollmentAsync(int ownerId, TestDataQaLibContext? context = null);
    Task<ReturnValue<TestDataQaLibTestOwner>> RetrieveTestOwnerAsync(int ownerId, TestDataQaLibContext? context = null);
}