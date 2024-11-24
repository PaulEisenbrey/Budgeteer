using Budgeteer.Helpers;

namespace Budgeteer.Account
{
    public class Institution
    {
        public int InstitutionId { get; set; }
        
        public string InstitutionName { get; set; } = string.Empty;
        
        public string NickName { get; set; } = string.Empty;
        
        public List<Address> InstitutionAddress { get; set; } = new();
        
        public string AccountNumber { get; set; } = string.Empty;
        
        public string PhoneNumber { get; set; } = string.Empty;

        public List<AccountData> AccountData { get; set; } = new();

    }
}
