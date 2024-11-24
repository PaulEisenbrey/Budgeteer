namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizMedicalRecordsClinicPet
{
    public int? Id { get; set; }
    public int PetId { get; set; }
    public int ClinicId { get; set; }
    public string PetName { get; set; } = "";
    public string BreedName { get; set; } = "";
    public string Species { get; set; } = "";
    public int OwnerId { get; set; }
    public string OwnerFirstName { get; set; } = "";
    public string OwnerLastName { get; set; } = "";
    public string SecondaryOwnerFirstName { get; set; } = "";
    public string SecondaryOwnerLastName { get; set; } = "";
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; } = "";
    public DateTime EnrollmentDate { get; set; }
    public string PolicyNumber { get; set; } = "";
    public string EnrollmentStatus { get; set; } = "";
    public string Promo { get; set; } = "";
    public string PawPrintStatus { get; set; } = "";
    public bool IsVip { get; set; }
    public bool IsHospitalEmployee { get; set; }
    public int? OpenClaimsCount { get; set; }
    public bool? SpayedNeutered { get; set; }
    public int? PawPrintStatusId { get; set; }
}
