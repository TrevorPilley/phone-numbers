using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    /// <summary>
    /// Contains unit tests for the <see cref="GBPhoneNumberParser"/> class for GB <see cref="PhoneNumber"/>s.
    /// </summary>
    public class GBPhoneNumberParserTests_NonGeographicPhoneNumber
    {
        private readonly PhoneNumberParser _parser = GBPhoneNumberParser.Create();

        [Theory]
        [InlineData("03000000000", "300", "0000000")]
        [InlineData("03009999999", "300", "9999999")]
        [InlineData("03020000000", "302", "0000000")]
        [InlineData("03029999999", "302", "9999999")]
        [InlineData("03030000000", "303", "0000000")]
        [InlineData("03039999999", "303", "9999999")]
        [InlineData("03060000000", "306", "0000000")]
        [InlineData("03069999999", "306", "9999999")]
        [InlineData("03300000000", "330", "0000000")]
        [InlineData("03309999999", "330", "9999999")]
        [InlineData("03310000000", "331", "0000000")]
        [InlineData("03319999999", "331", "9999999")]
        [InlineData("03320000000", "332", "0000000")]
        [InlineData("03329999999", "332", "9999999")]
        [InlineData("03330000000", "333", "0000000")]
        [InlineData("03339999999", "333", "9999999")]
        [InlineData("03430000000", "343", "0000000")]
        [InlineData("03439999999", "343", "9999999")]
        [InlineData("03440000000", "344", "0000000")]
        [InlineData("03449999999", "344", "9999999")]
        [InlineData("03450000000", "345", "0000000")]
        [InlineData("03459999999", "345", "9999999")]
        [InlineData("03700000000", "370", "0000000")]
        [InlineData("03709999999", "370", "9999999")]
        [InlineData("03710000000", "371", "0000000")]
        [InlineData("03719999999", "371", "9999999")]
        [InlineData("03720000000", "372", "0000000")]
        [InlineData("03729999999", "372", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_3XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("08430000000", "843", "0000000")]
        [InlineData("08439999999", "843", "9999999")]
        [InlineData("08440000000", "844", "0000000")]
        [InlineData("08449999999", "844", "9999999")]
        [InlineData("08450000000", "845", "0000000")]
        [InlineData("08459999999", "845", "9999999")]
        [InlineData("08700000000", "870", "0000000")]
        [InlineData("08709999999", "870", "9999999")]
        [InlineData("08710000000", "871", "0000000")]
        [InlineData("08719999999", "871", "9999999")]
        [InlineData("08720000000", "872", "0000000")]
        [InlineData("08729999999", "872", "9999999")]
        [InlineData("08990000000", "899", "0000000")]
        [InlineData("08999999999", "899", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_8XX_AreaCode(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.False(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("0800000000", "800", "000000")]
        [InlineData("0800999999", "800", "999999")]
        [InlineData("08080000000", "808", "0000000")]
        [InlineData("08089999999", "808", "9999999")]
        public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string areaCode, string localNumber)
        {
            var parseResult = _parser.Parse(value);
            parseResult.ThrowIfFailure();

            var phoneNumber = parseResult.PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

            var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
            Assert.Equal(areaCode, nonGeographicPhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, nonGeographicPhoneNumber.Country);
            Assert.True(nonGeographicPhoneNumber.IsFreephone);
            Assert.Equal(localNumber, nonGeographicPhoneNumber.LocalNumber);
        }
    }
}
