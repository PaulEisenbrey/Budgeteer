using Budgeteer.APR;
using Budgeteer.Constants;
using Budgeteer.Transaction;

namespace Budgeteer.Account
{
    public class AccountData
    {
        protected int accountId = -1;
        protected DateTime openDate = DateTime.MinValue;
        protected AccountType accountType = AccountType.uninitialized;
        protected string accountName = string.Empty;
        protected string accountNickName = string.Empty;
        protected decimal initialBalance = 0.0m;
        protected string accountNumber;
        protected string routingNumber;
        private readonly Dictionary<Guid, BTTransaction> transactions = new();
        protected readonly List<BTAnnualPercentageRate> apr = new();

        public int Id
        {
            get => accountId;
            set => accountId = value;
        }
        
        public DateTime OpenDate
        {
            get => openDate;
            set => openDate = value;
        }

        public AccountType AccountType
        {
            get => accountType;
            set => accountType = value;
        }

        public string Name
        {
            get => accountName;
            set => accountName = value;
        }

        public string NickName
        {
            get => accountNickName;
            set => accountNickName = value;
        }

        public string AccountNumber
        {
            get => accountNumber;
            set => accountNumber = value;
        }

        public string RoutingNumber
        {
            get => routingNumber;
            set => routingNumber = value;
        }

        public List<BTAnnualPercentageRate> APR => apr;
        
        public decimal InitialBalance => initialBalance;
        
        public Dictionary<Guid, BTTransaction> Transactions => transactions;

        public void AddTransaction(BTTransaction transaction)
        {
            transactions.TryAdd(transaction.TransactionId, transaction);
        }
    }
}
