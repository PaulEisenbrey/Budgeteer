using Database.Models;

namespace Budgeteer.Poco
{
    public class Account
    {
        public AccountDatum AccountData { get; private set; } = new();
        public List<BtTransaction> TransactionList { get; private set; } = new();

        public Account SetAccountData(AccountDatum accountData)
        {
            AccountData = accountData;
            return this;
        }

        public Account AddTransactiont(BtTransaction transaction)
        {
            TransactionList.Add(transaction);
            return this;
        }

        public Account UpdateTransaction(BtTransaction transaction)
        {
            var index = TransactionList.FindIndex(t => t.Id == transaction.Id);
            if (index >= 0)
            {
                TransactionList[index] = transaction;
            }
            return this;
        }

        public Account RemoveTransaction(BtTransaction transaction)
        {
            TransactionList.Remove(transaction);
            return this;
        }
    }
}