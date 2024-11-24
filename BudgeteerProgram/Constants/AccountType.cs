using System.ComponentModel;

namespace Budgeteer.Constants
{
    public enum AccountType
    {
        uninitialized = 0,
        [Description("Bucket Account")]
        bucket = 1,
        [Description("Checking Account")]
        checking = 2,
        [Description("Savings Account")]
        savings = 3,
        [Description("Credit Card")]
        credit = 4,
        [Description("Secured Loan")]
        securedLoan = 5,
        [Description("Unsecured Loan")]
        unsecuredLoan = 6,
        [Description("Investment Account")]
        investment = 7,
        outofrange
    }
}