using Budgeteer.Constants;
using Database.Models;
using MyUtilities.Constants.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountType = Budgeteer.Constants.AccountType;

namespace Budgeteer.Scaffolding
{
    public class CreateTestInstitution
    {
        public Institution institution { get; private set; } = new();

        public Institution Create()
        {
            institution.Name = "Test Institution";
            institution.Nickname = "Test";
            institution.AccountNumber = "1234567890";
            institution.PhoneNumber = "123-456-7890";
            institution.Url = "http://www.testinstitution.com";
            institution.Address = new Address
            {
                PostalCode = "98008",
                City = "Bellevue",
                State = "WA",
                Street = "123 Main St"
            };

            var account1 = new AccountDatum
            {
                AccountUniqueId = Guid.NewGuid(),
                AccountTypeId = (int)AccountType.checking,
                AccountNumber = "1234567890",
                InstitutionId = institution.Id,
                InitialBalance = 1000.00m,
                Name = "Test Checking Account",
                Nickname = "Checking for Me Alone",
                OpenDate = DateTime.Now.AddDays(-1),
                RoutingNumber = "1234567890"
            };

            account1.btTransactions.Add(new BtTransaction
            {
                TransactionId = Guid.NewGuid(),
                TransactionTypeId = (int)BtTransactionType.autoDeposit,
                BudgetCategoryId = (int)BudgetCategories.others,
                CheckNumber = "",
                Description = "Initial Deposit",
                IsDeposit = true,
                TransactionAmount = 1000.00m,
                TransactionDate = DateTime.Now
            });

            account1.btTransactions.Add(new BtTransaction
            {
                TransactionId = Guid.NewGuid(),
                TransactionTypeId = (int)BtTransactionType.atmWithdrawl,
                BudgetCategoryId = (int)BudgetCategories.eatingOut,
                CheckNumber = "",
                Description = "Dinner at Tyee",
                IsDeposit = false,
                TransactionAmount = 100.00m,
                TransactionDate = DateTime.Now
            });

            institution.AccountData.Add(account1);

            return institution;
        }
    }
}
