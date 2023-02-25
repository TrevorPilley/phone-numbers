using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        CallingCode = "+1",
        Continent = NorthAmerica,
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
    };
}
