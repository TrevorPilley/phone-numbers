namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Australia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AU_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Australia);

    [Theory]
    [InlineData("0233000000", "2", "33000000", "Gosford")]
    [InlineData("0233999999", "2", "33999999", "Gosford")]
    [InlineData("0238000000", "2", "38000000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0238999999", "2", "38999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0240000000", "2", "40000000", "Newcastle")]
    [InlineData("0241999999", "2", "41999999", "Newcastle")]
    [InlineData("0242000000", "2", "42000000", "Wollongong")]
    [InlineData("0242999999", "2", "42999999", "Wollongong")]
    [InlineData("0243000000", "2", "43000000", "Gosford")]
    [InlineData("0243999999", "2", "43999999", "Gosford")]
    [InlineData("0244000000", "2", "44000000", "Moruya, Nowra")]
    [InlineData("0244999999", "2", "44999999", "Moruya, Nowra")]
    [InlineData("0245000000", "2", "45000000", "Windsor")]
    [InlineData("0245999999", "2", "45999999", "Windsor")]
    [InlineData("0246000000", "2", "46000000", "Campbelltown")]
    [InlineData("0246999999", "2", "46999999", "Campbelltown")]
    [InlineData("0247000000", "2", "47000000", "Penrith")]
    [InlineData("0247999999", "2", "47999999", "Penrith")]
    [InlineData("0248000000", "2", "48000000", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0248999999", "2", "48999999", "Bowral, Crookwell, Goulburn, Marulan")]
    [InlineData("0249000000", "2", "49000000", "Newcastle")]
    [InlineData("0249999999", "2", "49999999", "Newcastle")]
    [InlineData("0250000000", "2", "50000000", "Albury, Corryong")]
    [InlineData("0250999999", "2", "50999999", "Albury, Corryong")]
    [InlineData("0251000000", "2", "51000000", "Canberra")]
    [InlineData("0252999999", "2", "52999999", "Canberra")]
    [InlineData("0253000000", "2", "53000000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0253999999", "2", "53999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0255000000", "2", "55000000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0255999999", "2", "55999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0256000000", "2", "56000000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0256999999", "2", "56999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0257000000", "2", "57000000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0257999999", "2", "57999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0258000000", "2", "58000000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0258999999", "2", "58999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0259000000", "2", "59000000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0259999999", "2", "59999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0260000000", "2", "60000000", "Albury, Corryong")]
    [InlineData("0260999999", "2", "60999999", "Albury, Corryong")]
    [InlineData("0261000000", "2", "61000000", "Canberra")]
    [InlineData("0262999999", "2", "62999999", "Canberra")]
    [InlineData("0263000000", "2", "63000000", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0263999999", "2", "63999999", "Bathurst, Cowra, Lithgow, Mudgee, Orange, Rylstone, Young")]
    [InlineData("0264000000", "2", "64000000", "Bega, Cooma")]
    [InlineData("0264999999", "2", "64999999", "Bega, Cooma")]
    [InlineData("0265000000", "2", "65000000", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0265999999", "2", "65999999", "Kempsey, Lord Howe Island, Muswellbrook, Singleton, Taree, Wauchope")]
    [InlineData("0266000000", "2", "66000000", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0266999999", "2", "66999999", "Casino, Coffs Harbour, Graton, Kyogle, Lismore, Murwillumbah")]
    [InlineData("0267000000", "2", "67000000", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0267999999", "2", "67999999", "Armidale, Barraba, Gunnedah, Inverell, Moree, Narrabri, Glen Innes, Tamworth")]
    [InlineData("0268000000", "2", "68000000", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0268999999", "2", "68999999", "Bourke, Condoblin, Coonamble, Dubbo, Forbes, Moree, Nyngan, Parkes, Wellington")]
    [InlineData("0269000000", "2", "69000000", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0269999999", "2", "69999999", "Adelong, Griffith, Hay, Narrandera, Temora, Wagga Wagga, West Wyalong")]
    [InlineData("0270000000", "2", "70000000", "Sydney")]
    [InlineData("0299999999", "2", "99999999", "Sydney")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0340000000", "3", "40000000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0340999999", "3", "40999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0341000000", "3", "41000000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0341999999", "3", "41999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0342000000", "3", "42000000", "Geelong, Colac")]
    [InlineData("0342999999", "3", "42999999", "Geelong, Colac")]
    [InlineData("0343000000", "3", "43000000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0343999999", "3", "43999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0344000000", "3", "44000000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0344999999", "3", "44999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0345000000", "3", "45000000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0345999999", "3", "45999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0346000000", "3", "46000000", "Foster, Korumburra, Warragul")]
    [InlineData("0346999999", "3", "46999999", "Foster, Korumburra, Warragul")]
    [InlineData("0347000000", "3", "47000000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0347999999", "3", "47999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348000000", "3", "48000000", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0348999999", "3", "48999999", "Deniliquin, Numurkah, Shepparton")]
    [InlineData("0349000000", "3", "49000000", "Mornington, Warragul")]
    [InlineData("0349999999", "3", "49999999", "Mornington, Warragul")]
    [InlineData("0350000000", "3", "50000000", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0350999999", "3", "50999999", "Balranald, Hopetoun, Mildura, Ouyen, Swan Hill")]
    [InlineData("0351000000", "3", "51000000", "Bairnsdale, Morwell, Sale")]
    [InlineData("0351999999", "3", "51999999", "Bairnsdale, Morwell, Sale")]
    [InlineData("0352000000", "3", "52000000", "Geelong, Colac")]
    [InlineData("0352999999", "3", "52999999", "Geelong, Colac")]
    [InlineData("0353000000", "3", "53000000", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0353999999", "3", "53999999", "Ararat, Ballarat, Horsham, Kyneton, Nhill")]
    [InlineData("0354000000", "3", "54000000", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0354999999", "3", "54999999", "Bendigo, Charlton, Echuca, Kerang, Kyneton, Maryborough")]
    [InlineData("0355000000", "3", "55000000", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0355999999", "3", "55999999", "Camperdown, Casterton, Edenhope, Hamilton, Portland, Warrnambool")]
    [InlineData("0357000000", "3", "57000000", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0357999999", "3", "57999999", "Alexandra, Myrtleford, Seymour, Wangaratta, Deniliquin, Numurkah, Shepparton")]
    [InlineData("0359000000", "3", "59000000", "Mornington, Warragul")]
    [InlineData("0359999999", "3", "59999999", "Mornington, Warragul")]
    [InlineData("0361000000", "3", "61000000", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0362999999", "3", "62999999", "Hobart, Geeveston, Oatlands, Ouse")]
    [InlineData("0363000000", "3", "63000000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0363999999", "3", "63999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0364000000", "3", "64000000", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0365999999", "3", "65999999", "Burnie, Devonport, King Island, Queenstown, Smithton")]
    [InlineData("0367000000", "3", "67000000", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0367999999", "3", "67999999", "Deloraine, Flinders Island, Launceston, Scottsdale, St Mary’s")]
    [InlineData("0370000000", "3", "70000000", "Melbourne")]
    [InlineData("0399999999", "3", "99999999", "Melbourne")]
    public void Parse_Known_GeographicPhoneNumber_3_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0720000000", "7", "20000000", "Brisbane, Bribie Island, Esk")]
    [InlineData("0739999999", "7", "39999999", "Brisbane, Bribie Island, Esk")]
    [InlineData("0740000000", "7", "40000000", "Cairns")]
    [InlineData("0740999999", "7", "40999999", "Cairns")]
    [InlineData("0741000000", "7", "41000000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0741999999", "7", "41999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0742000000", "7", "42000000", "Cairns")]
    [InlineData("0742999999", "7", "42999999", "Cairns")]
    [InlineData("0743000000", "7", "43000000", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0743999999", "7", "43999999", "Bundaberg, Gayndah, Kingaroy, Maryborough, Murgon")]
    [InlineData("0744000000", "7", "44000000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0744999999", "7", "44999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0745000000", "7", "45000000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0746999999", "7", "46999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0747000000", "7", "47000000", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0747999999", "7", "47999999", "Cloncurry, Hughenden, Townsville")]
    [InlineData("0748000000", "7", "48000000", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0749999999", "7", "49999999", "Biloela, Emerald, Gladstone, Mackay, Rockhampton")]
    [InlineData("0752000000", "7", "52000000", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0754999999", "7", "54999999", "Caboolture, Esk, Gatton, Gympie, Nambour")]
    [InlineData("0755000000", "7", "55000000", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0757999999", "7", "57999999", "Beaudesert, Southport, Tweed Heads")]
    [InlineData("0776000000", "7", "76000000", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    [InlineData("0776999999", "7", "76999999", "Charleville, Dalby, Dirranbandi, Goondiwindi, Inglewood, Longreach, Miles, Roma, Stanthorpe, Toowoomba, Warwick")]
    public void Parse_Known_GeographicPhoneNumber_7_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Australia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
