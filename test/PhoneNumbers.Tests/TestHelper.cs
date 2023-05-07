using System.Collections.ObjectModel;

namespace PhoneNumbers.Tests;

internal static class TestHelper
{
    /// <summary>
    /// Creates a <see cref="CountryInfo"/> with the specified values,
    /// the calling code will always be +422 and the ISO 3116 code will always be ZZ (which are unused).
    /// </summary>
    internal static CountryInfo CreateCountryInfo(
        string trunkPrefix = default,
        int[] ndcLengths = default,
        int[] nsnLengths = default,
        bool allowsLocalGeographicDialling = false) =>
        new()
        {
            AllowsLocalGeographicDialling = allowsLocalGeographicDialling,
            CallingCode = "422", // 422 isn't a used calling code.
            Continent = "Pangea",
            Iso3166Code = "ZZ", // ZZ isn't a used ISO 3166 code.
            Name = "Zulu",
            NdcLengths = new ReadOnlyCollection<int>(ndcLengths ?? Array.Empty<int>()),
            NsnLengths = new ReadOnlyCollection<int>(nsnLengths ?? Array.Empty<int>()),
            TrunkPrefix = trunkPrefix,
        };

    internal static PhoneNumber CreateGeographicPhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool allowsLocalGeographicDialling = false,
        PhoneNumberHint phoneNumberHint = PhoneNumberHint.None) =>
        new GeographicPhoneNumber(phoneNumberHint)
        {
            Country = CreateCountryInfo(trunkPrefix: trunkPrefix, allowsLocalGeographicDialling: allowsLocalGeographicDialling),
            GeographicArea = "AreaName",
            NationalDestinationCode = ndc,
            NationalSignificantNumber = $"{ndc}{sn}",
            SubscriberNumber = sn,
        };

    internal static PhoneNumber CreateMobilePhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool allowsLocalGeographicDialling = false,
        PhoneNumberHint phoneNumberHint = PhoneNumberHint.None) =>
        new MobilePhoneNumber(phoneNumberHint)
        {
            Country = CreateCountryInfo(trunkPrefix: trunkPrefix, allowsLocalGeographicDialling: allowsLocalGeographicDialling),
            NationalDestinationCode = ndc,
            NationalSignificantNumber = $"{ndc}{sn}",
            SubscriberNumber = sn,
        };

    internal static PhoneNumber CreateNonGeographicPhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool allowLocalGeographicDialling = false,
        PhoneNumberHint phoneNumberHint = PhoneNumberHint.None) =>
        new NonGeographicPhoneNumber(phoneNumberHint)
        {
            Country = CreateCountryInfo(trunkPrefix: trunkPrefix, allowsLocalGeographicDialling: allowLocalGeographicDialling),
            NationalDestinationCode = ndc,
            NationalSignificantNumber = $"{ndc}{sn}",
            SubscriberNumber = sn,
        };
}
