using Budgeteer.APR;
using Budgeteer.Constants;
using Budgeteer.Transaction;

namespace Budgeteer.Account
{
    public class AccountSerializer : AccountFactory
    {
        public new int AccountId
        {
            get => base.AccountId;
            set => base.SetAccountId(value);
        }

        public new DateTime OpenDate
        {
            get => base.OpenDate;
            set => base.SetOpenDate(value);
        }

        public new AccountType AccountType
        {
            get => base.accountType;
            set => base.SetAccountType(value);
        }

        public new string AccountName
        {
            get => base.accountName;
            set => base.SetAccountName(value);
        }

        public new string AccountNickName
        {
            get => base.AccountNickName;
            set => base.SetAccountNickName(value);
        }

        public new List<BTAnnualPercentageRate> APR
        {
            get => base.APR;
            set
            {
                foreach (var rate in APR)
                {
                    base.AddApr(rate);
                }
            }
        }

        public new decimal InitialBalance
        {
            get => base.InitialBalance;
            set => base.SetInitialBalance(value);
        }

        public Dictionary<Guid, BTTransaction> BTTransactions
        {
            get => base.Transactions;
            set 
            {
                foreach (var transaction in value)
                {
                    base.AddTransaction(transaction.Value);
                }
            }
        }
    }
}
