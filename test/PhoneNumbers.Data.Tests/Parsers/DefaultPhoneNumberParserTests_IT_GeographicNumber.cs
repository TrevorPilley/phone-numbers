namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Italy <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IT_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Italy);

    [Theory]
    [InlineData("020000", "02", "0000", "Milano")]
    [InlineData("0299999999", "02", "99999999", "Milano")]
    [InlineData("060000", "06", "0000", "Roma")]
    [InlineData("0699999999", "06", "99999999", "Roma")]
    public void Parse_Known_GeographicPhoneNumber_0X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("010000", "010", "000", "Genova")]
    [InlineData("0109999999", "010", "9999999", "Genova")]
    [InlineData("011000", "011", "000", "Torino")]
    [InlineData("0119999999", "011", "9999999", "Torino")]
    [InlineData("015000", "015", "000", "Biella")]
    [InlineData("0159999999", "015", "9999999", "Biella")]
    [InlineData("019000", "019", "000", "Savona")]
    [InlineData("0199999999", "019", "9999999", "Savona")]
    [InlineData("030000", "030", "000", "Brescia")]
    [InlineData("0309999999", "030", "9999999", "Brescia")]
    [InlineData("031000", "031", "000", "Como")]
    [InlineData("0319999999", "031", "9999999", "Como")]
    [InlineData("035000", "035", "000", "Bergamo")]
    [InlineData("0359999999", "035", "9999999", "Bergamo")]
    [InlineData("039000", "039", "000", "Monza")]
    [InlineData("0399999999", "039", "9999999", "Monza")]
    [InlineData("040000", "040", "000", "Trieste")]
    [InlineData("0409999999", "040", "9999999", "Trieste")]
    [InlineData("041000", "041", "000", "Venezia (Mestre)")]
    [InlineData("0419999999", "041", "9999999", "Venezia (Mestre)")]
    [InlineData("045000", "045", "000", "Verona")]
    [InlineData("0459999999", "045", "9999999", "Verona")]
    [InlineData("049000", "049", "000", "Padova")]
    [InlineData("0499999999", "049", "9999999", "Padova")]
    [InlineData("050000", "050", "000", "Pisa")]
    [InlineData("0509999999", "050", "9999999", "Pisa")]
    [InlineData("051000", "051", "000", "Bologna")]
    [InlineData("0519999999", "051", "9999999", "Bologna")]
    [InlineData("055000", "055", "000", "Firenze")]
    [InlineData("0559999999", "055", "9999999", "Firenze")]
    [InlineData("059000", "059", "000", "Modena")]
    [InlineData("0599999999", "059", "9999999", "Modena")]
    [InlineData("070000", "070", "000", "Cagliari")]
    [InlineData("0709999999", "070", "9999999", "Cagliari")]
    [InlineData("071000", "071", "000", "Ancona")]
    [InlineData("0719999999", "071", "9999999", "Ancona")]
    [InlineData("075000", "075", "000", "Perugia")]
    [InlineData("0759999999", "075", "9999999", "Perugia")]
    [InlineData("079000", "079", "000", "Sassari")]
    [InlineData("0799999999", "079", "9999999", "Sassari")]
    [InlineData("080000", "080", "000", "Bari")]
    [InlineData("0809999999", "080", "9999999", "Bari")]
    [InlineData("081000", "081", "000", "Napoli")]
    [InlineData("0819999999", "081", "9999999", "Napoli")]
    [InlineData("085000", "085", "000", "Pescara")]
    [InlineData("0859999999", "085", "9999999", "Pescara")]
    [InlineData("089000", "089", "000", "Salerno")]
    [InlineData("0899999999", "089", "9999999", "Salerno")]
    [InlineData("090000", "090", "000", "Messina")]
    [InlineData("0909999999", "090", "9999999", "Messina")]
    [InlineData("091000", "091", "000", "Palermo")]
    [InlineData("0919999999", "091", "9999999", "Palermo")]
    [InlineData("095000", "095", "000", "Catania")]
    [InlineData("0959999999", "095", "9999999", "Catania")]
    [InlineData("099000", "099", "000", "Taranto")]
    [InlineData("0999999999", "099", "9999999", "Taranto")]
    public void Parse_Known_GeographicPhoneNumber_0XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("012100", "0121", "00", "Pinerolo")]
    [InlineData("0121999999", "0121", "999999", "Pinerolo")]
    [InlineData("012200", "0122", "00", "Susa")]
    [InlineData("0122999999", "0122", "999999", "Susa")]
    [InlineData("012300", "0123", "00", "Lanzo Torinese")]
    [InlineData("0123999999", "0123", "999999", "Lanzo Torinese")]
    [InlineData("012400", "0124", "00", "Rivarolo Canavese")]
    [InlineData("0124999999", "0124", "999999", "Rivarolo Canavese")]
    [InlineData("012500", "0125", "00", "Ivrea")]
    [InlineData("0125999999", "0125", "999999", "Ivrea")]
    [InlineData("013100", "0131", "00", "Alessandria")]
    [InlineData("0131999999", "0131", "999999", "Alessandria")]
    [InlineData("014100", "0141", "00", "Asti")]
    [InlineData("0141999999", "0141", "999999", "Asti")]
    [InlineData("014200", "0142", "00", "Casale Monferrato")]
    [InlineData("0142999999", "0142", "999999", "Casale Monferrato")]
    [InlineData("014300", "0143", "00", "Novi Ligure")]
    [InlineData("0143999999", "0143", "999999", "Novi Ligure")]
    [InlineData("014400", "0144", "00", "Acqui Terme")]
    [InlineData("0144999999", "0144", "999999", "Acqui Terme")]
    [InlineData("016100", "0161", "00", "Vercelli")]
    [InlineData("0161999999", "0161", "999999", "Vercelli")]
    [InlineData("016300", "0163", "00", "Borgosesia")]
    [InlineData("0163999999", "0163", "999999", "Borgosesia")]
    [InlineData("016500", "0165", "00", "Aosta")]
    [InlineData("0165999999", "0165", "999999", "Aosta")]
    [InlineData("016600", "0166", "00", "St. Vincent")]
    [InlineData("0166999999", "0166", "999999", "St. Vincent")]
    [InlineData("017100", "0171", "00", "Cuneo")]
    [InlineData("0171999999", "0171", "999999", "Cuneo")]
    [InlineData("017200", "0172", "00", "Savigliano")]
    [InlineData("0172999999", "0172", "999999", "Savigliano")]
    [InlineData("017300", "0173", "00", "Alba")]
    [InlineData("0173999999", "0173", "999999", "Alba")]
    [InlineData("017400", "0174", "00", "Mondovì")]
    [InlineData("0174999999", "0174", "999999", "Mondovì")]
    [InlineData("017500", "0175", "00", "Saluzzo")]
    [InlineData("0175999999", "0175", "999999", "Saluzzo")]
    [InlineData("018200", "0182", "00", "Albenga")]
    [InlineData("0182999999", "0182", "999999", "Albenga")]
    [InlineData("018300", "0183", "00", "Imperia")]
    [InlineData("0183999999", "0183", "999999", "Imperia")]
    [InlineData("018400", "0184", "00", "San remo")]
    [InlineData("0184999999", "0184", "999999", "San remo")]
    [InlineData("018500", "0185", "00", "Rapallo")]
    [InlineData("0185999999", "0185", "999999", "Rapallo")]
    [InlineData("018700", "0187", "00", "La Spezia")]
    [InlineData("0187999999", "0187", "999999", "La Spezia")]
    [InlineData("032100", "0321", "00", "Novara")]
    [InlineData("0321999999", "0321", "999999", "Novara")]
    [InlineData("032200", "0322", "00", "Arona")]
    [InlineData("0322999999", "0322", "999999", "Arona")]
    [InlineData("032300", "0323", "00", "Baveno")]
    [InlineData("0323999999", "0323", "999999", "Baveno")]
    [InlineData("032400", "0324", "00", "Domodossola")]
    [InlineData("0324999999", "0324", "999999", "Domodossola")]
    [InlineData("033100", "0331", "00", "Busto Arsizio")]
    [InlineData("0331999999", "0331", "999999", "Busto Arsizio")]
    [InlineData("033200", "0332", "00", "Varese")]
    [InlineData("0332999999", "0332", "999999", "Varese")]
    [InlineData("034100", "0341", "00", "Lecco")]
    [InlineData("0341999999", "0341", "999999", "Lecco")]
    [InlineData("034200", "0342", "00", "Sondrio")]
    [InlineData("0342999999", "0342", "999999", "Sondrio")]
    [InlineData("034300", "0343", "00", "Chiavenna")]
    [InlineData("0343999999", "0343", "999999", "Chiavenna")]
    [InlineData("034400", "0344", "00", "Menaggio")]
    [InlineData("0344999999", "0344", "999999", "Menaggio")]
    [InlineData("034500", "0345", "00", "San Pellegrino Terme")]
    [InlineData("0345999999", "0345", "999999", "San Pellegrino Terme")]
    [InlineData("034600", "0346", "00", "Clusone")]
    [InlineData("0346999999", "0346", "999999", "Clusone")]
    [InlineData("036200", "0362", "00", "Seregno")]
    [InlineData("0362999999", "0362", "999999", "Seregno")]
    [InlineData("036300", "0363", "00", "Treviglio")]
    [InlineData("0363999999", "0363", "999999", "Treviglio")]
    [InlineData("036400", "0364", "00", "Breno")]
    [InlineData("0364999999", "0364", "999999", "Breno")]
    [InlineData("036500", "0365", "00", "Salò")]
    [InlineData("0365999999", "0365", "999999", "Salò")]
    [InlineData("037100", "0371", "00", "Lodi")]
    [InlineData("0371999999", "0371", "999999", "Lodi")]
    [InlineData("037200", "0372", "00", "Cremona")]
    [InlineData("0372999999", "0372", "999999", "Cremona")]
    [InlineData("037300", "0373", "00", "Crema")]
    [InlineData("0373999999", "0373", "999999", "Crema")]
    [InlineData("037400", "0374", "00", "Soresina")]
    [InlineData("0374999999", "0374", "999999", "Soresina")]
    [InlineData("037500", "0375", "00", "Casalmaggiore")]
    [InlineData("0375999999", "0375", "999999", "Casalmaggiore")]
    [InlineData("037600", "0376", "00", "Mantova")]
    [InlineData("0376999999", "0376", "999999", "Mantova")]
    [InlineData("037700", "0377", "00", "Codogno")]
    [InlineData("0377999999", "0377", "999999", "Codogno")]
    [InlineData("038100", "0381", "00", "Vigevano")]
    [InlineData("0381999999", "0381", "999999", "Vigevano")]
    [InlineData("038200", "0382", "00", "Pavia")]
    [InlineData("0382999999", "0382", "999999", "Pavia")]
    [InlineData("038300", "0383", "00", "Voghera")]
    [InlineData("0383999999", "0383", "999999", "Voghera")]
    [InlineData("038400", "0384", "00", "Mortara")]
    [InlineData("0384999999", "0384", "999999", "Mortara")]
    [InlineData("038500", "0385", "00", "Stradella")]
    [InlineData("0385999999", "0385", "999999", "Stradella")]
    [InlineData("038600", "0386", "00", "Ostiglia")]
    [InlineData("0386999999", "0386", "999999", "Ostiglia")]
    [InlineData("042100", "0421", "00", "San Donà di Piave")]
    [InlineData("0421999999", "0421", "999999", "San Donà di Piave")]
    [InlineData("042200", "0422", "00", "Treviso")]
    [InlineData("0422999999", "0422", "999999", "Treviso")]
    [InlineData("042300", "0423", "00", "Montebelluna")]
    [InlineData("0423999999", "0423", "999999", "Montebelluna")]
    [InlineData("042400", "0424", "00", "Bassano del Grappa")]
    [InlineData("0424999999", "0424", "999999", "Bassano del Grappa")]
    [InlineData("042500", "0425", "00", "Rovigo")]
    [InlineData("0425999999", "0425", "999999", "Rovigo")]
    [InlineData("042600", "0426", "00", "Adria")]
    [InlineData("0426999999", "0426", "999999", "Adria")]
    [InlineData("042700", "0427", "00", "Spilimbergo")]
    [InlineData("0427999999", "0427", "999999", "Spilimbergo")]
    [InlineData("042800", "0428", "00", "Tarvisio")]
    [InlineData("0428999999", "0428", "999999", "Tarvisio")]
    [InlineData("042900", "0429", "00", "Este")]
    [InlineData("0429999999", "0429", "999999", "Este")]
    [InlineData("043100", "0431", "00", "Cervignano del Friuli")]
    [InlineData("0431999999", "0431", "999999", "Cervignano del Friuli")]
    [InlineData("043200", "0432", "00", "Udine")]
    [InlineData("0432999999", "0432", "999999", "Udine")]
    [InlineData("043300", "0433", "00", "Tolmezzo")]
    [InlineData("0433999999", "0433", "999999", "Tolmezzo")]
    [InlineData("043400", "0434", "00", "Pordenone")]
    [InlineData("0434999999", "0434", "999999", "Pordenone")]
    [InlineData("043500", "0435", "00", "Pieve di Cadore")]
    [InlineData("0435999999", "0435", "999999", "Pieve di Cadore")]
    [InlineData("043600", "0436", "00", "Cortina d'Ampezzo")]
    [InlineData("0436999999", "0436", "999999", "Cortina d'Ampezzo")]
    [InlineData("043700", "0437", "00", "Belluno")]
    [InlineData("0437999999", "0437", "999999", "Belluno")]
    [InlineData("043800", "0438", "00", "Conegliano")]
    [InlineData("0438999999", "0438", "999999", "Conegliano")]
    [InlineData("043900", "0439", "00", "Feltre")]
    [InlineData("0439999999", "0439", "999999", "Feltre")]
    [InlineData("044200", "0442", "00", "Legnago")]
    [InlineData("0442999999", "0442", "999999", "Legnago")]
    [InlineData("044400", "0444", "00", "Vicenza")]
    [InlineData("0444999999", "0444", "999999", "Vicenza")]
    [InlineData("044500", "0445", "00", "Schio")]
    [InlineData("0445999999", "0445", "999999", "Schio")]
    [InlineData("046100", "0461", "00", "Trento")]
    [InlineData("0461999999", "0461", "999999", "Trento")]
    [InlineData("046200", "0462", "00", "Cavalese")]
    [InlineData("0462999999", "0462", "999999", "Cavalese")]
    [InlineData("046300", "0463", "00", "Cles")]
    [InlineData("0463999999", "0463", "999999", "Cles")]
    [InlineData("046400", "0464", "00", "Rovereto")]
    [InlineData("0464999999", "0464", "999999", "Rovereto")]
    [InlineData("046500", "0465", "00", "Tione di Trento")]
    [InlineData("0465999999", "0465", "999999", "Tione di Trento")]
    [InlineData("047100", "0471", "00", "Bolzano")]
    [InlineData("0471999999", "0471", "999999", "Bolzano")]
    [InlineData("047200", "0472", "00", "Bressanone")]
    [InlineData("0472999999", "0472", "999999", "Bressanone")]
    [InlineData("047300", "0473", "00", "Merano")]
    [InlineData("0473999999", "0473", "999999", "Merano")]
    [InlineData("047400", "0474", "00", "Brunico")]
    [InlineData("0474999999", "0474", "999999", "Brunico")]
    [InlineData("048100", "0481", "00", "Gorizia")]
    [InlineData("0481999999", "0481", "999999", "Gorizia")]
    [InlineData("052100", "0521", "00", "Parma")]
    [InlineData("0521999999", "0521", "999999", "Parma")]
    [InlineData("052200", "0522", "00", "Reggio nell'Emilia")]
    [InlineData("0522999999", "0522", "999999", "Reggio nell'Emilia")]
    [InlineData("052300", "0523", "00", "Piacenza")]
    [InlineData("0523999999", "0523", "999999", "Piacenza")]
    [InlineData("052400", "0524", "00", "Fidenza")]
    [InlineData("0524999999", "0524", "999999", "Fidenza")]
    [InlineData("052500", "0525", "00", "Fornovo di Taro")]
    [InlineData("0525999999", "0525", "999999", "Fornovo di Taro")]
    [InlineData("053200", "0532", "00", "Ferrara")]
    [InlineData("0532999999", "0532", "999999", "Ferrara")]
    [InlineData("053300", "0533", "00", "Comacchio")]
    [InlineData("0533999999", "0533", "999999", "Comacchio")]
    [InlineData("053400", "0534", "00", "Porretta Terme")]
    [InlineData("0534999999", "0534", "999999", "Porretta Terme")]
    [InlineData("053500", "0535", "00", "Mirandola")]
    [InlineData("0535999999", "0535", "999999", "Mirandola")]
    [InlineData("053600", "0536", "00", "Sassuolo")]
    [InlineData("0536999999", "0536", "999999", "Sassuolo")]
    [InlineData("054100", "0541", "00", "Rimini")]
    [InlineData("0541999999", "0541", "999999", "Rimini")]
    [InlineData("054200", "0542", "00", "Imola")]
    [InlineData("0542999999", "0542", "999999", "Imola")]
    [InlineData("054300", "0543", "00", "Forlì")]
    [InlineData("0543999999", "0543", "999999", "Forlì")]
    [InlineData("054400", "0544", "00", "Ravenna")]
    [InlineData("0544999999", "0544", "999999", "Ravenna")]
    [InlineData("054500", "0545", "00", "Lugo")]
    [InlineData("0545999999", "0545", "999999", "Lugo")]
    [InlineData("054600", "0546", "00", "Faenza")]
    [InlineData("0546999999", "0546", "999999", "Faenza")]
    [InlineData("054700", "0547", "00", "Cesena")]
    [InlineData("0547999999", "0547", "999999", "Cesena")]
    [InlineData("054900", "0549", "00", "Republic di San Marino")]
    [InlineData("054909", "0549", "09", "Republic di San Marino")]
    [InlineData("054980", "0549", "80", "Republic di San Marino")]
    [InlineData("054989", "0549", "89", "Republic di San Marino")]
    [InlineData("054990", "0549", "90", "Republic di San Marino")]
    [InlineData("054999", "0549", "99", "Republic di San Marino")]
    [InlineData("0549000", "0549", "000", "Republic di San Marino")]
    [InlineData("0549099", "0549", "099", "Republic di San Marino")]
    [InlineData("0549800", "0549", "800", "Republic di San Marino")]
    [InlineData("0549899", "0549", "899", "Republic di San Marino")]
    [InlineData("0549900", "0549", "900", "Republic di San Marino")]
    [InlineData("0549999", "0549", "999", "Republic di San Marino")]
    [InlineData("05490000", "0549", "0000", "Republic di San Marino")]
    [InlineData("05490999", "0549", "0999", "Republic di San Marino")]
    [InlineData("05498000", "0549", "8000", "Republic di San Marino")]
    [InlineData("05498999", "0549", "8999", "Republic di San Marino")]
    [InlineData("05499000", "0549", "9000", "Republic di San Marino")]
    [InlineData("05499999", "0549", "9999", "Republic di San Marino")]
    [InlineData("054900000", "0549", "00000", "Republic di San Marino")]
    [InlineData("054909999", "0549", "09999", "Republic di San Marino")]
    [InlineData("054980000", "0549", "80000", "Republic di San Marino")]
    [InlineData("054989999", "0549", "89999", "Republic di San Marino")]
    [InlineData("054990000", "0549", "90000", "Republic di San Marino")]
    [InlineData("054999999", "0549", "99999", "Republic di San Marino")]
    [InlineData("0549000000", "0549", "000000", "Republic di San Marino")]
    [InlineData("0549099999", "0549", "099999", "Republic di San Marino")]
    [InlineData("0549800000", "0549", "800000", "Republic di San Marino")]
    [InlineData("0549899999", "0549", "899999", "Republic di San Marino")]
    [InlineData("0549900000", "0549", "900000", "Republic di San Marino")]
    [InlineData("0549999999", "0549", "999999", "Republic di San Marino")]
    [InlineData("056400", "0564", "00", "Grosseto")]
    [InlineData("0564999999", "0564", "999999", "Grosseto")]
    [InlineData("056500", "0565", "00", "Piombino")]
    [InlineData("0565999999", "0565", "999999", "Piombino")]
    [InlineData("056600", "0566", "00", "Follonica")]
    [InlineData("0566999999", "0566", "999999", "Follonica")]
    [InlineData("057100", "0571", "00", "Empoli")]
    [InlineData("0571999999", "0571", "999999", "Empoli")]
    [InlineData("057200", "0572", "00", "Montecatini Terme")]
    [InlineData("0572999999", "0572", "999999", "Montecatini Terme")]
    [InlineData("057300", "0573", "00", "Pistoia")]
    [InlineData("0573999999", "0573", "999999", "Pistoia")]
    [InlineData("057400", "0574", "00", "Prato")]
    [InlineData("0574999999", "0574", "999999", "Prato")]
    [InlineData("057500", "0575", "00", "Arezzo")]
    [InlineData("0575999999", "0575", "999999", "Arezzo")]
    [InlineData("057700", "0577", "00", "Siena")]
    [InlineData("0577999999", "0577", "999999", "Siena")]
    [InlineData("057800", "0578", "00", "Chianciano Terme")]
    [InlineData("0578999999", "0578", "999999", "Chianciano Terme")]
    [InlineData("058300", "0583", "00", "Lucca")]
    [InlineData("0583999999", "0583", "999999", "Lucca")]
    [InlineData("058400", "0584", "00", "Viareggio")]
    [InlineData("0584999999", "0584", "999999", "Viareggio")]
    [InlineData("058500", "0585", "00", "Massa")]
    [InlineData("0585999999", "0585", "999999", "Massa")]
    [InlineData("058600", "0586", "00", "Livorno")]
    [InlineData("0586999999", "0586", "999999", "Livorno")]
    [InlineData("058700", "0587", "00", "Pontedera")]
    [InlineData("0587999999", "0587", "999999", "Pontedera")]
    [InlineData("058800", "0588", "00", "Volterra")]
    [InlineData("0588999999", "0588", "999999", "Volterra")]
    [InlineData("072100", "0721", "00", "Pesaro")]
    [InlineData("0721999999", "0721", "999999", "Pesaro")]
    [InlineData("072200", "0722", "00", "Urbino")]
    [InlineData("0722999999", "0722", "999999", "Urbino")]
    [InlineData("073100", "0731", "00", "Jesi")]
    [InlineData("0731999999", "0731", "999999", "Jesi")]
    [InlineData("073200", "0732", "00", "Fabriano")]
    [InlineData("0732999999", "0732", "999999", "Fabriano")]
    [InlineData("073300", "0733", "00", "Macerata")]
    [InlineData("0733999999", "0733", "999999", "Macerata")]
    [InlineData("073400", "0734", "00", "Fermo")]
    [InlineData("0734999999", "0734", "999999", "Fermo")]
    [InlineData("073500", "0735", "00", "San Benedetto del Tronto")]
    [InlineData("0735999999", "0735", "999999", "San Benedetto del Tronto")]
    [InlineData("073600", "0736", "00", "Ascoli Piceno")]
    [InlineData("0736999999", "0736", "999999", "Ascoli Piceno")]
    [InlineData("073700", "0737", "00", "Camerino")]
    [InlineData("0737999999", "0737", "999999", "Camerino")]
    [InlineData("074200", "0742", "00", "Foligno")]
    [InlineData("0742999999", "0742", "999999", "Foligno")]
    [InlineData("074300", "0743", "00", "Spoleto")]
    [InlineData("0743999999", "0743", "999999", "Spoleto")]
    [InlineData("074400", "0744", "00", "Terni")]
    [InlineData("0744999999", "0744", "999999", "Terni")]
    [InlineData("074600", "0746", "00", "Rieti")]
    [InlineData("0746999999", "0746", "999999", "Rieti")]
    [InlineData("076100", "0761", "00", "Viterbo")]
    [InlineData("0761999999", "0761", "999999", "Viterbo")]
    [InlineData("076300", "0763", "00", "Orvieto")]
    [InlineData("0763999999", "0763", "999999", "Orvieto")]
    [InlineData("076500", "0765", "00", "Poggio Mirteto")]
    [InlineData("0765999999", "0765", "999999", "Poggio Mirteto")]
    [InlineData("076600", "0766", "00", "Civitavecchia")]
    [InlineData("0766999999", "0766", "999999", "Civitavecchia")]
    [InlineData("077100", "0771", "00", "Formia")]
    [InlineData("0771999999", "0771", "999999", "Formia")]
    [InlineData("077300", "0773", "00", "Latina")]
    [InlineData("0773999999", "0773", "999999", "Latina")]
    [InlineData("077400", "0774", "00", "Tivoli")]
    [InlineData("0774999999", "0774", "999999", "Tivoli")]
    [InlineData("077500", "0775", "00", "Frosinone")]
    [InlineData("0775999999", "0775", "999999", "Frosinone")]
    [InlineData("077600", "0776", "00", "Cassino")]
    [InlineData("0776999999", "0776", "999999", "Cassino")]
    [InlineData("078100", "0781", "00", "Iglesias")]
    [InlineData("0781999999", "0781", "999999", "Iglesias")]
    [InlineData("078200", "0782", "00", "Lanusei")]
    [InlineData("0782999999", "0782", "999999", "Lanusei")]
    [InlineData("078300", "0783", "00", "Oristano")]
    [InlineData("0783999999", "0783", "999999", "Oristano")]
    [InlineData("078400", "0784", "00", "Nuoro")]
    [InlineData("0784999999", "0784", "999999", "Nuoro")]
    [InlineData("078500", "0785", "00", "Macomer")]
    [InlineData("0785999999", "0785", "999999", "Macomer")]
    [InlineData("078900", "0789", "00", "Olbia")]
    [InlineData("0789999999", "0789", "999999", "Olbia")]
    [InlineData("082300", "0823", "00", "Caserta")]
    [InlineData("0823999999", "0823", "999999", "Caserta")]
    [InlineData("082400", "0824", "00", "Benevento")]
    [InlineData("0824999999", "0824", "999999", "Benevento")]
    [InlineData("082500", "0825", "00", "Avellino")]
    [InlineData("0825999999", "0825", "999999", "Avellino")]
    [InlineData("082700", "0827", "00", "San Angelo dei Lombardi")]
    [InlineData("0827999999", "0827", "999999", "San Angelo dei Lombardi")]
    [InlineData("082800", "0828", "00", "Battipaglia")]
    [InlineData("0828999999", "0828", "999999", "Battipaglia")]
    [InlineData("083100", "0831", "00", "Brindisi")]
    [InlineData("0831999999", "0831", "999999", "Brindisi")]
    [InlineData("083200", "0832", "00", "Lecce")]
    [InlineData("0832999999", "0832", "999999", "Lecce")]
    [InlineData("083300", "0833", "00", "Gallipoli")]
    [InlineData("0833999999", "0833", "999999", "Gallipoli")]
    [InlineData("083500", "0835", "00", "Matera")]
    [InlineData("0835999999", "0835", "999999", "Matera")]
    [InlineData("083600", "0836", "00", "Maglie")]
    [InlineData("0836999999", "0836", "999999", "Maglie")]
    [InlineData("086100", "0861", "00", "Teramo")]
    [InlineData("0861999999", "0861", "999999", "Teramo")]
    [InlineData("086200", "0862", "00", "L'Aquila")]
    [InlineData("0862999999", "0862", "999999", "L'Aquila")]
    [InlineData("086300", "0863", "00", "Avezzano")]
    [InlineData("0863999999", "0863", "999999", "Avezzano")]
    [InlineData("086400", "0864", "00", "Sulmona")]
    [InlineData("0864999999", "0864", "999999", "Sulmona")]
    [InlineData("086500", "0865", "00", "Isernia")]
    [InlineData("0865999999", "0865", "999999", "Isernia")]
    [InlineData("087100", "0871", "00", "Chieti")]
    [InlineData("0871999999", "0871", "999999", "Chieti")]
    [InlineData("087200", "0872", "00", "Lanciano")]
    [InlineData("0872999999", "0872", "999999", "Lanciano")]
    [InlineData("087300", "0873", "00", "Vasto")]
    [InlineData("0873999999", "0873", "999999", "Vasto")]
    [InlineData("087400", "0874", "00", "Campobasso")]
    [InlineData("0874999999", "0874", "999999", "Campobasso")]
    [InlineData("087500", "0875", "00", "Termoli")]
    [InlineData("0875999999", "0875", "999999", "Termoli")]
    [InlineData("088100", "0881", "00", "Foggia")]
    [InlineData("0881999999", "0881", "999999", "Foggia")]
    [InlineData("088200", "0882", "00", "San Severo")]
    [InlineData("0882999999", "0882", "999999", "San Severo")]
    [InlineData("088300", "0883", "00", "Andria")]
    [InlineData("0883999999", "0883", "999999", "Andria")]
    [InlineData("088400", "0884", "00", "Manfredonia")]
    [InlineData("0884999999", "0884", "999999", "Manfredonia")]
    [InlineData("088500", "0885", "00", "Cerignola")]
    [InlineData("0885999999", "0885", "999999", "Cerignola")]
    [InlineData("092100", "0921", "00", "Cefalù")]
    [InlineData("0921999999", "0921", "999999", "Cefalù")]
    [InlineData("092200", "0922", "00", "Agrigento")]
    [InlineData("0922999999", "0922", "999999", "Agrigento")]
    [InlineData("092300", "0923", "00", "Trapani")]
    [InlineData("0923999999", "0923", "999999", "Trapani")]
    [InlineData("092400", "0924", "00", "Alcamo")]
    [InlineData("0924999999", "0924", "999999", "Alcamo")]
    [InlineData("092500", "0925", "00", "Sciacca")]
    [InlineData("0925999999", "0925", "999999", "Sciacca")]
    [InlineData("093100", "0931", "00", "Siracusa")]
    [InlineData("0931999999", "0931", "999999", "Siracusa")]
    [InlineData("093200", "0932", "00", "Ragusa")]
    [InlineData("0932999999", "0932", "999999", "Ragusa")]
    [InlineData("093300", "0933", "00", "Caltagirone")]
    [InlineData("0933999999", "0933", "999999", "Caltagirone")]
    [InlineData("093400", "0934", "00", "Caltanissetta")]
    [InlineData("0934999999", "0934", "999999", "Caltanissetta")]
    [InlineData("093500", "0935", "00", "Enna")]
    [InlineData("0935999999", "0935", "999999", "Enna")]
    [InlineData("094100", "0941", "00", "Patti")]
    [InlineData("0941999999", "0941", "999999", "Patti")]
    [InlineData("094200", "0942", "00", "Taormina")]
    [InlineData("0942999999", "0942", "999999", "Taormina")]
    [InlineData("096100", "0961", "00", "Catanzaro")]
    [InlineData("0961999999", "0961", "999999", "Catanzaro")]
    [InlineData("096200", "0962", "00", "Crotone")]
    [InlineData("0962999999", "0962", "999999", "Crotone")]
    [InlineData("096300", "0963", "00", "Vibo Valentia")]
    [InlineData("0963999999", "0963", "999999", "Vibo Valentia")]
    [InlineData("096400", "0964", "00", "Locri")]
    [InlineData("0964999999", "0964", "999999", "Locri")]
    [InlineData("096500", "0965", "00", "Reggio Calabria")]
    [InlineData("0965999999", "0965", "999999", "Reggio Calabria")]
    [InlineData("096600", "0966", "00", "Palmi")]
    [InlineData("0966999999", "0966", "999999", "Palmi")]
    [InlineData("096700", "0967", "00", "Soverato")]
    [InlineData("0967999999", "0967", "999999", "Soverato")]
    [InlineData("096800", "0968", "00", "Lamezia Terme")]
    [InlineData("0968999999", "0968", "999999", "Lamezia Terme")]
    [InlineData("097100", "0971", "00", "Potenza")]
    [InlineData("0971999999", "0971", "999999", "Potenza")]
    [InlineData("097200", "0972", "00", "Melfi")]
    [InlineData("0972999999", "0972", "999999", "Melfi")]
    [InlineData("097300", "0973", "00", "Lagonegro")]
    [InlineData("0973999999", "0973", "999999", "Lagonegro")]
    [InlineData("097400", "0974", "00", "Vallo della Lucania")]
    [InlineData("0974999999", "0974", "999999", "Vallo della Lucania")]
    [InlineData("097500", "0975", "00", "Sala Consilina")]
    [InlineData("0975999999", "0975", "999999", "Sala Consilina")]
    [InlineData("097600", "0976", "00", "Muro Lucano")]
    [InlineData("0976999999", "0976", "999999", "Muro Lucano")]
    [InlineData("098100", "0981", "00", "Castrovillari")]
    [InlineData("0981999999", "0981", "999999", "Castrovillari")]
    [InlineData("098200", "0982", "00", "Paola")]
    [InlineData("0982999999", "0982", "999999", "Paola")]
    [InlineData("098300", "0983", "00", "Rossano")]
    [InlineData("0983999999", "0983", "999999", "Rossano")]
    [InlineData("098400", "0984", "00", "Cosenza")]
    [InlineData("0984999999", "0984", "999999", "Cosenza")]
    [InlineData("098500", "0985", "00", "Scalea")]
    [InlineData("0985999999", "0985", "999999", "Scalea")]
    public void Parse_Known_GeographicPhoneNumber_0XXX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
