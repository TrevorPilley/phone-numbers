namespace PhoneNumbers.Tests;

public class PhoneNumber_TryParse_Tests
{
    [Fact]
    public void TryParse_Value_For_Austria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+43171100", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Austria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0171100", CountryInfo.Austria.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Belarus_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+375172171185", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Belarus_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("8172171185", CountryInfo.Belarus.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Belgium_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3250444646", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Belgium_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("050444646", CountryInfo.Belgium.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Bulgaria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35929492760", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Bulgaria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("029492760", CountryInfo.Bulgaria.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Croatia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+38517007007", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Croatia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("017007007", CountryInfo.Croatia.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_CzechRepublic_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+420224004111", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_CzechRepublic_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("224004111", CountryInfo.CzechRepublic.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Denmark_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4533926700", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Denmark_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4533926700", CountryInfo.Denmark.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Egypt_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+20235344239", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Egypt_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0235344239", CountryInfo.Egypt.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Estonia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3726672072", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Estonia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("6672072", CountryInfo.Estonia.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Finland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+358295390361", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Finland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0295390361", CountryInfo.Finland.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_France_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+33140477283", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_France_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("140477283", CountryInfo.France.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Germany_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+49228141177", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Germany_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0228141177", CountryInfo.Germany.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Gibraltar_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35020074636", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Gibraltar_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("20074636", CountryInfo.Gibraltar.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Greece_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+302106151000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Greece_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("2106151000", CountryInfo.Greece.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Guernsey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441481717000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }
    [Fact]
    public void TryParse_Value_CountryCode_For_Guernsey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("01481717000", CountryInfo.Guernsey.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_HongKong_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+85229616333", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_HongKong_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("29616333", CountryInfo.HongKong.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Hungary_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3614680666", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Hungary_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0614680666", CountryInfo.Hungary.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Ireland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35318049600", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Ireland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("018049600", CountryInfo.Ireland.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_IsleOfMan_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441624696300", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_IsleOfMan_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("01624696300", CountryInfo.IsleOfMan.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Italy_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+393492525255", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Italy_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("3492525255", CountryInfo.Italy.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Jersey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441534716800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Jersey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("01534716800", CountryInfo.Jersey.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Kosovo_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+38338212345", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Kosovo_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("038212345", CountryInfo.Kosovo.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Macau_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+85328000000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Macau_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("28000000", CountryInfo.Macau.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Moldova_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+37322251317", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Moldova_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("022251317", CountryInfo.Moldova.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Monaco_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+37798988800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Monaco_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("98988800", CountryInfo.Monaco.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Netherlands_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+31702140214", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Netherlands_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0702140214", CountryInfo.Netherlands.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Nigeria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+23494617000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Nigeria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("094617000", CountryInfo.Nigeria.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Norway_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4722824600", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Norway_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("22824600", CountryInfo.Norway.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Poland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+48222455856", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Poland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("222455856", CountryInfo.Poland.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Portugal_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+351217211000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Portugal_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("217211000", CountryInfo.Portugal.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Romania_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+40372845414", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Romania_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0372845414", CountryInfo.Romania.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_SanMarino_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3780549882555", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_SanMarino_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0549882555", CountryInfo.SanMarino.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Serbia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+381112026828", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Serbia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0112026828", CountryInfo.Serbia.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Singapore_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+6563773800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Singapore_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("63773800", CountryInfo.Singapore.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Slovakia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+421257881101", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Slovakia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0257881101", CountryInfo.Slovakia.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_SouthAfrica_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+27215616800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_SouthAfrica_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0215616800", CountryInfo.SouthAfrica.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Spain_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+34912582852", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Spain_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("912582852", CountryInfo.Spain.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Sweden_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4686785500", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Sweden_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("086785500", CountryInfo.Sweden.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_Switzerland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+41584605511", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_Switzerland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0584605511", CountryInfo.Switzerland.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Ukraine_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+380442819196", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Ukraine_CountryCode_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("0442819196", CountryInfo.Ukraine.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_For_UnitedKingdom_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+442079813000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_CountryCode_For_UnitedKingdom_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("02079813000", CountryInfo.UnitedKingdom.Iso3166Code, out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }
}
