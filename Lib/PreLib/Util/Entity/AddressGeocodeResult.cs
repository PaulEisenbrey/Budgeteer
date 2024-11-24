namespace Utilities.Entity;

public class AddressGeocodeResult
{
    public class ErrorInfo
    {
        public string Desc { get; set; } = "";

        public int Number { get; set; }

        public string Location { get; set; } = "";
    }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public ErrorInfo? Error { get; set; }

    public bool HasError => Error != null;

    public bool HasNoError => !HasError;

    public bool HasTransientError => HasError && Error!.Number != 2;
}
