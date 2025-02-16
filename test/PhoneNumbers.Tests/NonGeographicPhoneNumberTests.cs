namespace PhoneNumbers.Tests;

public class NonGeographicPhoneNumberTests
{
    [Fact]
    public void Constructor_Sets_Properties_Freephone()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(PhoneNumberHint.Freephone)
        {
            Country = countryInfo,
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.True(phoneNumber.IsFreephone);
        Assert.False(phoneNumber.IsMachineToMachine);
        Assert.False(phoneNumber.IsPremiumRate);
        Assert.False(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.Kind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_MachineToMachine()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(PhoneNumberHint.MachineToMachine)
        {
            Country = countryInfo,
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsFreephone);
        Assert.True(phoneNumber.IsMachineToMachine);
        Assert.False(phoneNumber.IsPremiumRate);
        Assert.False(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.Kind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_PremiumRate()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(PhoneNumberHint.PremiumRate)
        {
            Country = countryInfo,
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsFreephone);
        Assert.False(phoneNumber.IsMachineToMachine);
        Assert.True(phoneNumber.IsPremiumRate);
        Assert.False(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.Kind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Constructor_Sets_Properties_SharedCost()
    {
        var countryInfo = TestHelper.CreateCountryInfo();
        var phoneNumber = new NonGeographicPhoneNumber(PhoneNumberHint.SharedCost)
        {
            Country = countryInfo,
            NationalDestinationCode = "12345",
            NationalSignificantNumber = "12345667788",
            SubscriberNumber = "667788",
        };

        Assert.Equal(countryInfo, phoneNumber.Country);
        Assert.False(phoneNumber.IsFreephone);
        Assert.False(phoneNumber.IsMachineToMachine);
        Assert.False(phoneNumber.IsPremiumRate);
        Assert.True(phoneNumber.IsSharedCost);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, phoneNumber.Kind);
        Assert.Equal("12345", phoneNumber.NationalDestinationCode);
        Assert.Equal("12345667788", phoneNumber.NationalSignificantNumber);
        Assert.Equal("667788", phoneNumber.SubscriberNumber);
    }

    [Fact]
    public void Equality_Both_Null()
    {
        var phoneNumber1 = default(NonGeographicPhoneNumber);
        var phoneNumber2 = default(NonGeographicPhoneNumber);

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Instance()
    {
        var phoneNumber1 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");
        var phoneNumber2 = phoneNumber1;

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.True(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
        Assert.False(phoneNumber1 != (object)phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_With_NationalDestinationCode()
    {
        var phoneNumber1 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Equality_Same_Values_Without_NationalDestinationCode()
    {
        var phoneNumber1 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: default,
            sn: "667788");

        var phoneNumber2 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: default,
            sn: "667788");

        Assert.Equal(phoneNumber1, phoneNumber2);
        Assert.True(phoneNumber1.Equals(phoneNumber2));
        Assert.True(phoneNumber1.Equals((object)phoneNumber2));
        Assert.True(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber1 != phoneNumber2);
    }

    [Fact]
    public void Inequality()
    {
        var phoneNumber1 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667788");

        var phoneNumber2 = default(NonGeographicPhoneNumber);

        Assert.NotEqual(phoneNumber1, phoneNumber2);
        Assert.NotEqual(phoneNumber2, phoneNumber1);
        Assert.False(phoneNumber1.Equals(phoneNumber2));
        Assert.False(phoneNumber1.Equals((object)phoneNumber2));
        Assert.False(phoneNumber1 == phoneNumber2);
        Assert.False(phoneNumber2 == phoneNumber1);
        Assert.False(phoneNumber1 == (object)phoneNumber2);
        Assert.False(phoneNumber2 == (object)phoneNumber1);
        Assert.True(phoneNumber1 != phoneNumber2);
        Assert.True(phoneNumber2 != phoneNumber1);
        Assert.True(phoneNumber1 != (object)phoneNumber2);
        Assert.True(phoneNumber2 != (object)phoneNumber1);

        // Change national destination code
        var phoneNumber3 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12346",
            sn: "667788");

        Assert.NotEqual(phoneNumber1, phoneNumber3);
        Assert.False(phoneNumber1.Equals(phoneNumber3));
        Assert.False(phoneNumber1 == phoneNumber3);
        Assert.True(phoneNumber1 != phoneNumber3);

        // change subscriber number
        var phoneNumber4 = TestHelper.CreateNonGeographicPhoneNumber(
            trunkPrefix: default,
            ndc: "12345",
            sn: "667789");

        Assert.NotEqual(phoneNumber1, phoneNumber4);
        Assert.False(phoneNumber1.Equals(phoneNumber4));
        Assert.False(phoneNumber1 == phoneNumber4);
        Assert.True(phoneNumber1 != phoneNumber4);

        // change country
        var phoneNumber5 = new NonGeographicPhoneNumber(PhoneNumberHint.None)
        {
            Country = CountryInfo.France,
            NationalDestinationCode = phoneNumber1.NationalDestinationCode,
            NationalSignificantNumber = phoneNumber1.NationalSignificantNumber,
            SubscriberNumber = phoneNumber1.SubscriberNumber,
        };

        Assert.NotEqual(phoneNumber1, phoneNumber5);
        Assert.False(phoneNumber1.Equals(phoneNumber5));
        Assert.False(phoneNumber1 == phoneNumber5);
        Assert.True(phoneNumber1 != phoneNumber5);
    }
}
