namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizOwnerPetPolicyHospital
{
    public int Id { get; set; }
    public Guid OwnerUniqueId { get; set; }
    public int PetId { get; set; }
    public Guid PetUniqueId { get; set; }
    public int PetPolicyId { get; set; }
    public Guid PetPolicyUniqueId { get; set; }
    public int HospitalId { get; set; }
    public Guid HospitalUniqueId { get; set; }
    public int OwnerAddressId { get; set; }
    public string FirstName { get; set; }  = "";
    public string LastName { get; set; }  = "";
    public string PolicyNumber { get; set; }  = "";
    public string EmailAddress { get; set; }  = "";
    public string PhoneNumber { get; set; }  = "";
    public string AddressLine1 { get; set; }  = "";
    public string AddressLine2 { get; set; }  = "";
    public string City { get; set; }  = "";
    public string PostalCode { get; set; }  = "";
    public string StateCode { get; set; }  = "";
    public string PetName { get; set; }  = "";
    public string Gender { get; set; } = "";
    public DateTime? DateOfBirth { get; set; }
    public int? PawPrintStatusId { get; set; }
    public int BreedId { get; set; }
    public string PetPolicyNumber { get; set; } = "";
    public DateTime PolicyDate { get; set; }
    public int? PolicyStatus { get; set; }
    public bool? IsSpayedOrNeutered { get; set; }
}
