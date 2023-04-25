using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Egypt.
    /// </summary>
    public static CountryInfo Egypt { get; } = new()
    {
        CallingCode = "20",
        Continent = Africa,
        Iso3166Code = "EG",
        Name = "Egypt",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9, 10, 11 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Nigeria.
    /// </summary>
    public static CountryInfo Nigeria { get; } = new()
    {
        AllowLocalGeographicDialling = true,
        CallingCode = "234",
        Continent = Africa,
        Iso3166Code = "NG",
        Name = "Nigeria",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 10 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for SouthAfrica.
    /// </summary>
    public static CountryInfo SouthAfrica { get; } = new()
    {
        CallingCode = "27",
        Continent = Africa,
        Iso3166Code = "ZA",
        Name = "South Africa",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9, 13 }),
        TrunkPrefix = "0",
    };
}
