using Budgeteer.Account;
using Budgeteer.Helpers;

namespace Budgeteer.Factories
{
    public class InstitutionFactory
    {
        public int NextInstitutionId { get; set; } = 1;
        public Institution CreateNewInstitution(
                string institutionName, 
                string nickName, 
                string street, 
                string city, 
                string state, 
                string zip, 
                string accountNumber) =>
            new Institution
            {
            InstitutionId = NextInstitutionId++,
            InstitutionName = institutionName,
            NickName = nickName,

            InstitutionAddress = new Address
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = zip
            },

            AccountNumber = accountNumber
        };
    }
}