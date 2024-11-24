namespace Database.Containers;

public class RetrieveCharacteristicByTypeAndLocationParameters
{
    public Guid CharacteristicTypeId { get; set; }

    public string IsoAlpha3CountryCode { get; set; } = "";

    public string StateCode { get; set; } = "";

    public string PostalCode { get; set; } = "";

    public bool IsValid => Guid.Empty != CharacteristicTypeId && !string.IsNullOrEmpty(IsoAlpha3CountryCode) && !string.IsNullOrEmpty(StateCode) && !string.IsNullOrEmpty(PostalCode);
}
