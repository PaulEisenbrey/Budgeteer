using Budgeteer.APR;
using Budgeteer.Constants;
using Budgeteer.Transaction;

namespace Budgeteer.Account
{
    public class AccountFactory : AccountData
    {
        public AccountData Build() => this;

        public AccountFactory SetAccountId (int accountId)
        {
            if (accountId != 0)
            {
                this.accountId = accountId;
            }

            return this;
        }

        public AccountFactory SetOpenDate(DateTime openDate)
        {
            if (openDate != DateTime.MinValue)
            {
                this.openDate = openDate;
            }

            return this;
        }

        public AccountFactory SetAccountType(AccountType accountType)
        {
            if (accountType != AccountType.uninitialized)
            {
                this.accountType = accountType;
            }

            return this;
        }

        public AccountFactory SetAccountName(string accountName)
        {
            if (!string.IsNullOrEmpty(accountName))
            {
                this.accountName = accountName;
            }

            return this;
        }

        public AccountFactory SetAccountNickName(string accountNickName)
        {
            if (!string.IsNullOrEmpty(accountNickName))
            {
                this.accountNickName = accountNickName;
            }

            return this;
        }

        public AccountFactory SetInitialBalance(decimal initialBalance)
        {
            this.initialBalance = initialBalance;
            return this;
        }

        public new AccountFactory AddTransaction(BTTransaction transaction)
        {
            base.AddTransaction(transaction);
            return this;
        }

        public AccountFactory AddApr(BTAnnualPercentageRate apr)
        {
            this.apr.Add(apr);
            return this;
        }
    }
}