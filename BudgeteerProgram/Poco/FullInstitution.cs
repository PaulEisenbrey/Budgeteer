using Database.Models;

namespace Budgeteer.Poco;

public class FullInstitution
{
    public Institution Institution { get; private set; } = new();

    public List<Account> Accounts { get; private set; } = new();

    public FullInstitution SetInstitution(Institution institution)
    {
        Institution = institution;
        return this;
    }

    public FullInstitution AddAccounts(Account account)
    {
        Accounts.Add(account);
        return this;
    }
}