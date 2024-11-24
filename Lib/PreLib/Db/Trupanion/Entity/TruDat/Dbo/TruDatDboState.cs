namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboState
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public string? StateCode { get; set; }
    public string? Name { get; set; }
    public decimal SetupFee { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int PriceAdjustmentNoticeDays { get; set; }
    public bool IgnoreAdjustmentOnNoPricing { get; set; }
    public int? ChangeUserId { get; set; }
    public bool TrialsHaveDeductibles { get; set; }
    public bool? AllowTrial { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboCountry? Country { get; set; }
    public virtual List<TruDatDboAreaCode> AreaCodes { get; set; } = new();
    public virtual List<TruDatDboCharityState> CharityStates { get; set; } = new();
    public virtual List<TruDatDboClaimExclusion> ClaimExclusions { get; set; } = new();
    public virtual List<TruDatDboClinic> Clinics { get; set; } = new();
    public virtual List<TruDatDboCorporateAccountAddress> CorporateAccountAddresses { get; set; } = new();
    public virtual List<TruDatDboCounty> Counties { get; set; } = new();
    public virtual List<TruDatDboEmergencyZipcode> EmergencyZipcodes { get; set; } = new();
    public virtual List<TruDatDboOwnerAddress> OwnerAddresses { get; set; } = new();
    public virtual List<TruDatDboPartner> Partners { get; set; } = new();
    public virtual List<TruDatDboPolicyOptionState> PolicyOptionStates { get; set; } = new();
    public virtual List<TruDatDboPolicyState> PolicyStates { get; set; } = new();
    public virtual List<TruDatDboPreferredPartnership> PreferredPartnerships { get; set; } = new();
    public virtual List<TruDatDboStateAttribute> StateAttributes { get; set; } = new();
    public virtual List<TruDatDboZipcode> Zipcodes { get; set; } = new();
}
