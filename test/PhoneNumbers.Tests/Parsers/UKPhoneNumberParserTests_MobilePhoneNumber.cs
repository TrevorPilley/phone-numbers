using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public partial class UKPhoneNumberParserTests
    {
        [Theory]
        [InlineData("07106112233", "7106", "112233")]
        [InlineData("07107112233", "7107", "112233")]
        [InlineData("07300112233", "7300", "112233")]
        [InlineData("07301112233", "7301", "112233")]
        [InlineData("07302112233", "7302", "112233")]
        [InlineData("07303112233", "7303", "112233")]
        [InlineData("07304112233", "7304", "112233")]
        [InlineData("07305112233", "7305", "112233")]
        [InlineData("07306112233", "7306", "112233")]
        [InlineData("07307112233", "7307", "112233")]
        [InlineData("07308112233", "7308", "112233")]
        [InlineData("07309112233", "7309", "112233")]
        [InlineData("07310112233", "7310", "112233")]
        [InlineData("07311112233", "7311", "112233")]
        [InlineData("07312112233", "7312", "112233")]
        [InlineData("07340112233", "7340", "112233")]
        [InlineData("07341112233", "7341", "112233")]
        [InlineData("07342112233", "7342", "112233")]
        [InlineData("07354112233", "7354", "112233")]
        [InlineData("07355112233", "7355", "112233")]
        [InlineData("07359112233", "7359", "112233")]
        [InlineData("07360112233", "7360", "112233")]
        [InlineData("07361112233", "7361", "112233")]
        [InlineData("07362112233", "7362", "112233")]
        [InlineData("07363112233", "7363", "112233")]
        [InlineData("07364412233", "7364", "412233")]
        [InlineData("07365112233", "7365", "112233")]
        [InlineData("07366112233", "7366", "112233")]
        [InlineData("07367112233", "7367", "112233")]
        [InlineData("07368112233", "7368", "112233")]
        [InlineData("07369912233", "7369", "912233")]
        [InlineData("07375112233", "7375", "112233")]
        [InlineData("07376112233", "7376", "112233")]
        [InlineData("07377112233", "7377", "112233")]
        [InlineData("07378112233", "7378", "112233")]
        [InlineData("07379112233", "7379", "112233")]
        [InlineData("07380112233", "7380", "112233")]
        [InlineData("07381112233", "7381", "112233")]
        [InlineData("07382112233", "7382", "112233")]
        [InlineData("07383112233", "7383", "112233")]
        [InlineData("07384112233", "7384", "112233")]
        [InlineData("07385112233", "7385", "112233")]
        [InlineData("07386112233", "7386", "112233")]
        [InlineData("07387112233", "7387", "112233")]
        [InlineData("07388112233", "7388", "112233")]
        [InlineData("07389112233", "7389", "112233")]
        [InlineData("07390112233", "7390", "112233")]
        [InlineData("07391112233", "7391", "112233")]
        [InlineData("07392112233", "7392", "112233")]
        [InlineData("07393112233", "7393", "112233")]
        [InlineData("07394112233", "7394", "112233")]
        [InlineData("07395112233", "7395", "112233")]
        [InlineData("07396112233", "7396", "112233")]
        [InlineData("07397112233", "7397", "112233")]
        [InlineData("07398112233", "7398", "112233")]
        [InlineData("07399112233", "7399", "112233")]
        [InlineData("07400112233", "7400", "112233")]
        [InlineData("07401112233", "7401", "112233")]
        [InlineData("07402112233", "7402", "112233")]
        [InlineData("07403112233", "7403", "112233")]
        [InlineData("07404112233", "7404", "112233")]
        [InlineData("07405112233", "7405", "112233")]
        [InlineData("07406512233", "7406", "512233")]
        [InlineData("07407112233", "7407", "112233")]
        [InlineData("07408112233", "7408", "112233")]
        [InlineData("07409112233", "7409", "112233")]
        [InlineData("07410112233", "7410", "112233")]
        [InlineData("07411112233", "7411", "112233")]
        [InlineData("07412112233", "7412", "112233")]
        [InlineData("07413112233", "7413", "112233")]
        [InlineData("07414112233", "7414", "112233")]
        [InlineData("07415112233", "7415", "112233")]
        [InlineData("07416112233", "7416", "112233")]
        [InlineData("07417212233", "7417", "212233")]
        [InlineData("07418112233", "7418", "112233")] // Isle of Man Mobile
        [InlineData("07419112233", "7419", "112233")]
        [InlineData("07420112233", "7420", "112233")]
        [InlineData("07421112233", "7421", "112233")]
        [InlineData("07422112233", "7422", "112233")]
        [InlineData("07423112233", "7423", "112233")]
        [InlineData("07424112233", "7424", "112233")]
        [InlineData("07425112233", "7425", "112233")]
        [InlineData("07426112233", "7426", "112233")]
        [InlineData("07427112233", "7427", "112233")]
        [InlineData("07428112233", "7428", "112233")]
        [InlineData("07429112233", "7429", "112233")]
        [InlineData("07430112233", "7430", "112233")]
        [InlineData("07431112233", "7431", "112233")]
        [InlineData("07432112233", "7432", "112233")]
        [InlineData("07433112233", "7433", "112233")]
        [InlineData("07434112233", "7434", "112233")]
        [InlineData("07435112233", "7435", "112233")]
        [InlineData("07436112233", "7436", "112233")]
        [InlineData("07437112233", "7437", "112233")]
        [InlineData("07438112233", "7438", "112233")]
        [InlineData("07439112233", "7439", "112233")]
        [InlineData("07440112233", "7440", "112233")]
        [InlineData("07441112233", "7441", "112233")]
        [InlineData("07442112233", "7442", "112233")]
        [InlineData("07443112233", "7443", "112233")]
        [InlineData("07444112233", "7444", "112233")]
        [InlineData("07445112233", "7445", "112233")]
        [InlineData("07446112233", "7446", "112233")]
        [InlineData("07447112233", "7447", "112233")]
        [InlineData("07448112233", "7448", "112233")]
        [InlineData("07449112233", "7449", "112233")]
        [InlineData("07450112233", "7450", "112233")]
        [InlineData("07451112233", "7451", "112233")]
        [InlineData("07452112233", "7452", "112233")] // Isle of Man Mobile
        [InlineData("07453112233", "7453", "112233")]
        [InlineData("07454112233", "7454", "112233")]
        [InlineData("07455112233", "7455", "112233")]
        [InlineData("07456112233", "7456", "112233")]
        [InlineData("07457112233", "7457", "112233")] // Isle of Man Mobile
        [InlineData("07458112233", "7458", "112233")]
        [InlineData("07459112233", "7459", "112233")]
        [InlineData("07460112233", "7460", "112233")]
        [InlineData("07461112233", "7461", "112233")]
        [InlineData("07462112233", "7462", "112233")]
        [InlineData("07463112233", "7463", "112233")]
        [InlineData("07464112233", "7464", "112233")]
        [InlineData("07465112233", "7465", "112233")]
        [InlineData("07466112233", "7466", "112233")]
        [InlineData("07467112233", "7467", "112233")]
        [InlineData("07468112233", "7468", "112233")]
        [InlineData("07469112233", "7469", "112233")]
        [InlineData("07470112233", "7470", "112233")]
        [InlineData("07471112233", "7471", "112233")]
        [InlineData("07472112233", "7472", "112233")]
        [InlineData("07473112233", "7473", "112233")]
        [InlineData("07474112233", "7474", "112233")]
        [InlineData("07475112233", "7475", "112233")]
        [InlineData("07476112233", "7476", "112233")]
        [InlineData("07477112233", "7477", "112233")]
        [InlineData("07478112233", "7478", "112233")]
        [InlineData("07479112233", "7479", "112233")]
        [InlineData("07480112233", "7480", "112233")]
        [InlineData("07481112233", "7481", "112233")]
        [InlineData("07482112233", "7482", "112233")]
        [InlineData("07483112233", "7483", "112233")]
        [InlineData("07484112233", "7484", "112233")]
        [InlineData("07485112233", "7485", "112233")]
        [InlineData("07486112233", "7486", "112233")]
        [InlineData("07487112233", "7487", "112233")]
        [InlineData("07488112233", "7488", "112233")]
        [InlineData("07489112233", "7489", "112233")]
        [InlineData("07490112233", "7490", "112233")]
        [InlineData("07491112233", "7491", "112233")]
        [InlineData("07492112233", "7492", "112233")]
        [InlineData("07493112233", "7493", "112233")]
        [InlineData("07494112233", "7494", "112233")]
        [InlineData("07495112233", "7495", "112233")]
        [InlineData("07496112233", "7496", "112233")]
        [InlineData("07497112233", "7497", "112233")]
        [InlineData("07498112233", "7498", "112233")]
        [InlineData("07499112233", "7499", "112233")]
        [InlineData("07500112233", "7500", "112233")]
        [InlineData("07501112233", "7501", "112233")]
        [InlineData("07502112233", "7502", "112233")]
        [InlineData("07503112233", "7503", "112233")]
        [InlineData("07504112233", "7504", "112233")]
        [InlineData("07505112233", "7505", "112233")]
        [InlineData("07506112233", "7506", "112233")]
        [InlineData("07507112233", "7507", "112233")]
        [InlineData("07508112233", "7508", "112233")]
        [InlineData("07509112233", "7509", "112233")] // Jersey Mobile
        [InlineData("07510112233", "7510", "112233")]
        [InlineData("07511112233", "7511", "112233")]
        [InlineData("07512112233", "7512", "112233")]
        [InlineData("07513112233", "7513", "112233")]
        [InlineData("07514112233", "7514", "112233")]
        [InlineData("07515112233", "7515", "112233")]
        [InlineData("07516112233", "7516", "112233")]
        [InlineData("07517112233", "7517", "112233")]
        [InlineData("07518112233", "7518", "112233")]
        [InlineData("07519112233", "7519", "112233")]
        [InlineData("07520112233", "7520", "112233")]
        [InlineData("07521112233", "7521", "112233")]
        [InlineData("07522112233", "7522", "112233")]
        [InlineData("07523112233", "7523", "112233")]
        [InlineData("07525112233", "7525", "112233")]
        [InlineData("07526112233", "7526", "112233")]
        [InlineData("07527112233", "7527", "112233")]
        [InlineData("07528112233", "7528", "112233")]
        [InlineData("07529112233", "7529", "112233")]
        [InlineData("07530112233", "7530", "112233")]
        [InlineData("07531112233", "7531", "112233")]
        [InlineData("07532112233", "7532", "112233")]
        [InlineData("07533112233", "7533", "112233")]
        [InlineData("07534112233", "7534", "112233")]
        [InlineData("07535112233", "7535", "112233")]
        [InlineData("07536112233", "7536", "112233")]
        [InlineData("07537112233", "7537", "112233")]
        [InlineData("07538112233", "7538", "112233")]
        [InlineData("07539112233", "7539", "112233")]
        [InlineData("07540112233", "7540", "112233")]
        [InlineData("07541112233", "7541", "112233")]
        [InlineData("07542112233", "7542", "112233")]
        [InlineData("07543112233", "7543", "112233")]
        [InlineData("07544112233", "7544", "112233")]
        [InlineData("07545112233", "7545", "112233")]
        [InlineData("07546112233", "7546", "112233")]
        [InlineData("07547112233", "7547", "112233")]
        [InlineData("07548112233", "7548", "112233")]
        [InlineData("07549112233", "7549", "112233")]
        [InlineData("07550112233", "7550", "112233")]
        [InlineData("07551112233", "7551", "112233")]
        [InlineData("07552112233", "7552", "112233")]
        [InlineData("07553112233", "7553", "112233")]
        [InlineData("07554112233", "7554", "112233")]
        [InlineData("07555112233", "7555", "112233")]
        [InlineData("07556112233", "7556", "112233")]
        [InlineData("07557112233", "7557", "112233")]
        [InlineData("07558812233", "7558", "812233")]
        [InlineData("07559012233", "7559", "012233")]
        [InlineData("07560112233", "7560", "112233")]
        [InlineData("07561112233", "7561", "112233")]
        [InlineData("07562112233", "7562", "112233")]
        [InlineData("07563112233", "7563", "112233")]
        [InlineData("07564112233", "7564", "112233")]
        [InlineData("07565112233", "7565", "112233")]
        [InlineData("07566112233", "7566", "112233")]
        [InlineData("07567112233", "7567", "112233")]
        [InlineData("07568112233", "7568", "112233")]
        [InlineData("07569112233", "7569", "112233")]
        [InlineData("07570112233", "7570", "112233")]
        [InlineData("07572112233", "7572", "112233")]
        [InlineData("07573112233", "7573", "112233")]
        [InlineData("07574112233", "7574", "112233")]
        [InlineData("07575112233", "7575", "112233")]
        [InlineData("07576112233", "7576", "112233")]
        [InlineData("07577112233", "7577", "112233")]
        [InlineData("07578112233", "7578", "112233")]
        [InlineData("07579112233", "7579", "112233")]
        [InlineData("07580112233", "7580", "112233")]
        [InlineData("07581112233", "7581", "112233")]
        [InlineData("07582112233", "7582", "112233")]
        [InlineData("07583112233", "7583", "112233")]
        [InlineData("07584112233", "7584", "112233")]
        [InlineData("07585112233", "7585", "112233")]
        [InlineData("07586112233", "7586", "112233")]
        [InlineData("07587112233", "7587", "112233")]
        [InlineData("07588112233", "7588", "112233")]
        [InlineData("07589112233", "7589", "112233")]
        [InlineData("07590112233", "7590", "112233")]
        [InlineData("07591112233", "7591", "112233")]
        [InlineData("07592112233", "7592", "112233")]
        [InlineData("07593112233", "7593", "112233")]
        [InlineData("07594112233", "7594", "112233")]
        [InlineData("07595112233", "7595", "112233")]
        [InlineData("07596112233", "7596", "112233")]
        [InlineData("07597112233", "7597", "112233")]
        [InlineData("07598112233", "7598", "112233")]
        [InlineData("07599112233", "7599", "112233")]
        [InlineData("07624112233", "7624", "112233")] // Isle of Man Mobile
        [InlineData("07700112233", "7700", "112233")] // Jersey Mobile
        [InlineData("07701112233", "7701", "112233")]
        [InlineData("07702112233", "7702", "112233")]
        [InlineData("07703112233", "7703", "112233")]
        [InlineData("07704112233", "7704", "112233")]
        [InlineData("07705112233", "7705", "112233")]
        [InlineData("07706112233", "7706", "112233")]
        [InlineData("07707112233", "7707", "112233")]
        [InlineData("07708112233", "7708", "112233")]
        [InlineData("07709112233", "7709", "112233")]
        [InlineData("07710112233", "7710", "112233")]
        [InlineData("07711112233", "7711", "112233")]
        [InlineData("07712112233", "7712", "112233")]
        [InlineData("07713112233", "7713", "112233")]
        [InlineData("07714112233", "7714", "112233")]
        [InlineData("07715112233", "7715", "112233")]
        [InlineData("07716112233", "7716", "112233")]
        [InlineData("07717112233", "7717", "112233")]
        [InlineData("07718112233", "7718", "112233")]
        [InlineData("07719112233", "7719", "112233")]
        [InlineData("07720112233", "7720", "112233")]
        [InlineData("07721112233", "7721", "112233")]
        [InlineData("07722112233", "7722", "112233")]
        [InlineData("07723112233", "7723", "112233")]
        [InlineData("07724112233", "7724", "112233")]
        [InlineData("07725112233", "7725", "112233")]
        [InlineData("07726112233", "7726", "112233")]
        [InlineData("07727112233", "7727", "112233")]
        [InlineData("07728112233", "7728", "112233")]
        [InlineData("07729112233", "7729", "112233")]
        [InlineData("07730112233", "7730", "112233")]
        [InlineData("07731112233", "7731", "112233")]
        [InlineData("07732112233", "7732", "112233")]
        [InlineData("07733112233", "7733", "112233")]
        [InlineData("07734112233", "7734", "112233")]
        [InlineData("07735112233", "7735", "112233")]
        [InlineData("07736112233", "7736", "112233")]
        [InlineData("07737112233", "7737", "112233")]
        [InlineData("07738112233", "7738", "112233")]
        [InlineData("07739112233", "7739", "112233")]
        [InlineData("07740112233", "7740", "112233")]
        [InlineData("07741112233", "7741", "112233")]
        [InlineData("07742112233", "7742", "112233")]
        [InlineData("07743112233", "7743", "112233")]
        [InlineData("07744112233", "7744", "112233")]
        [InlineData("07745112233", "7745", "112233")]
        [InlineData("07746112233", "7746", "112233")]
        [InlineData("07747112233", "7747", "112233")]
        [InlineData("07748112233", "7748", "112233")]
        [InlineData("07749112233", "7749", "112233")]
        [InlineData("07750112233", "7750", "112233")]
        [InlineData("07751112233", "7751", "112233")]
        [InlineData("07752112233", "7752", "112233")]
        [InlineData("07753112233", "7753", "112233")]
        [InlineData("07754112233", "7754", "112233")]
        [InlineData("07755112233", "7755", "112233")]
        [InlineData("07756112233", "7756", "112233")]
        [InlineData("07757112233", "7757", "112233")]
        [InlineData("07758112233", "7758", "112233")]
        [InlineData("07759112233", "7759", "112233")]
        [InlineData("07760112233", "7760", "112233")]
        [InlineData("07761112233", "7761", "112233")]
        [InlineData("07762112233", "7762", "112233")]
        [InlineData("07763112233", "7763", "112233")]
        [InlineData("07764112233", "7764", "112233")]
        [InlineData("07765112233", "7765", "112233")]
        [InlineData("07766112233", "7766", "112233")]
        [InlineData("07767112233", "7767", "112233")]
        [InlineData("07768112233", "7768", "112233")]
        [InlineData("07769112233", "7769", "112233")]
        [InlineData("07770112233", "7770", "112233")]
        [InlineData("07771112233", "7771", "112233")]
        [InlineData("07772112233", "7772", "112233")]
        [InlineData("07773112233", "7773", "112233")]
        [InlineData("07774112233", "7774", "112233")]
        [InlineData("07775112233", "7775", "112233")]
        [InlineData("07776112233", "7776", "112233")]
        [InlineData("07777112233", "7777", "112233")]
        [InlineData("07778112233", "7778", "112233")]
        [InlineData("07779112233", "7779", "112233")]
        [InlineData("07780112233", "7780", "112233")]
        [InlineData("07781112233", "7781", "112233")] // Guernsey Mobile
        [InlineData("07782112233", "7782", "112233")]
        [InlineData("07783112233", "7783", "112233")]
        [InlineData("07784112233", "7784", "112233")]
        [InlineData("07785112233", "7785", "112233")]
        [InlineData("07786112233", "7786", "112233")]
        [InlineData("07787112233", "7787", "112233")]
        [InlineData("07788112233", "7788", "112233")]
        [InlineData("07789112233", "7789", "112233")]
        [InlineData("07790112233", "7790", "112233")]
        [InlineData("07791112233", "7791", "112233")]
        [InlineData("07792112233", "7792", "112233")]
        [InlineData("07793112233", "7793", "112233")]
        [InlineData("07794112233", "7794", "112233")]
        [InlineData("07795112233", "7795", "112233")]
        [InlineData("07796112233", "7796", "112233")]
        [InlineData("07797112233", "7797", "112233")] // Jersey Mobile
        [InlineData("07798112233", "7798", "112233")]
        [InlineData("07799112233", "7799", "112233")]
        [InlineData("07800112233", "7800", "112233")]
        [InlineData("07801112233", "7801", "112233")]
        [InlineData("07802112233", "7802", "112233")]
        [InlineData("07803112233", "7803", "112233")]
        [InlineData("07804112233", "7804", "112233")]
        [InlineData("07805112233", "7805", "112233")]
        [InlineData("07806112233", "7806", "112233")]
        [InlineData("07807112233", "7807", "112233")]
        [InlineData("07808112233", "7808", "112233")]
        [InlineData("07809112233", "7809", "112233")]
        [InlineData("07810112233", "7810", "112233")]
        [InlineData("07811112233", "7811", "112233")]
        [InlineData("07812112233", "7812", "112233")]
        [InlineData("07813112233", "7813", "112233")]
        [InlineData("07814112233", "7814", "112233")]
        [InlineData("07815112233", "7815", "112233")]
        [InlineData("07816112233", "7816", "112233")]
        [InlineData("07817112233", "7817", "112233")]
        [InlineData("07818112233", "7818", "112233")]
        [InlineData("07819112233", "7819", "112233")]
        [InlineData("07820112233", "7820", "112233")]
        [InlineData("07821112233", "7821", "112233")]
        [InlineData("07822112233", "7822", "112233")]
        [InlineData("07823112233", "7823", "112233")]
        [InlineData("07824112233", "7824", "112233")]
        [InlineData("07825112233", "7825", "112233")]
        [InlineData("07826112233", "7826", "112233")]
        [InlineData("07827112233", "7827", "112233")]
        [InlineData("07828112233", "7828", "112233")]
        [InlineData("07829112233", "7829", "112233")] // Jersey Mobile
        [InlineData("07830112233", "7830", "112233")]
        [InlineData("07831112233", "7831", "112233")]
        [InlineData("07832112233", "7832", "112233")]
        [InlineData("07833112233", "7833", "112233")]
        [InlineData("07834112233", "7834", "112233")]
        [InlineData("07835112233", "7835", "112233")]
        [InlineData("07836112233", "7836", "112233")]
        [InlineData("07837112233", "7837", "112233")]
        [InlineData("07838112233", "7838", "112233")]
        [InlineData("07839112233", "7839", "112233")] // Guernsey Mobile
        [InlineData("07840112233", "7840", "112233")]
        [InlineData("07841112233", "7841", "112233")]
        [InlineData("07842112233", "7842", "112233")]
        [InlineData("07843112233", "7843", "112233")]
        [InlineData("07844112233", "7844", "112233")]
        [InlineData("07845112233", "7845", "112233")]
        [InlineData("07846112233", "7846", "112233")]
        [InlineData("07847112233", "7847", "112233")]
        [InlineData("07848112233", "7848", "112233")]
        [InlineData("07849112233", "7849", "112233")]
        [InlineData("07850112233", "7850", "112233")]
        [InlineData("07851112233", "7851", "112233")]
        [InlineData("07852112233", "7852", "112233")]
        [InlineData("07853112233", "7853", "112233")]
        [InlineData("07854112233", "7854", "112233")]
        [InlineData("07855112233", "7855", "112233")]
        [InlineData("07856112233", "7856", "112233")]
        [InlineData("07857112233", "7857", "112233")]
        [InlineData("07858112233", "7858", "112233")]
        [InlineData("07859112233", "7859", "112233")]
        [InlineData("07860112233", "7860", "112233")]
        [InlineData("07861112233", "7861", "112233")]
        [InlineData("07862112233", "7862", "112233")]
        [InlineData("07863112233", "7863", "112233")]
        [InlineData("07864112233", "7864", "112233")]
        [InlineData("07865112233", "7865", "112233")]
        [InlineData("07866112233", "7866", "112233")]
        [InlineData("07867112233", "7867", "112233")]
        [InlineData("07868112233", "7868", "112233")]
        [InlineData("07869112233", "7869", "112233")]
        [InlineData("07870112233", "7870", "112233")]
        [InlineData("07871112233", "7871", "112233")]
        [InlineData("07872112233", "7872", "112233")]
        [InlineData("07873112233", "7873", "112233")]
        [InlineData("07874112233", "7874", "112233")]
        [InlineData("07875112233", "7875", "112233")]
        [InlineData("07876112233", "7876", "112233")]
        [InlineData("07877112233", "7877", "112233")]
        [InlineData("07878112233", "7878", "112233")]
        [InlineData("07879112233", "7879", "112233")]
        [InlineData("07880112233", "7880", "112233")]
        [InlineData("07881112233", "7881", "112233")]
        [InlineData("07882112233", "7882", "112233")]
        [InlineData("07883112233", "7883", "112233")]
        [InlineData("07884112233", "7884", "112233")]
        [InlineData("07885112233", "7885", "112233")]
        [InlineData("07886112233", "7886", "112233")]
        [InlineData("07887112233", "7887", "112233")]
        [InlineData("07888112233", "7888", "112233")]
        [InlineData("07889112233", "7889", "112233")]
        [InlineData("07890112233", "7890", "112233")]
        [InlineData("07891112233", "7891", "112233")]
        [InlineData("07892112233", "7892", "112233")]
        [InlineData("07893112233", "7893", "112233")]
        [InlineData("07894112233", "7894", "112233")]
        [InlineData("07895112233", "7895", "112233")]
        [InlineData("07896112233", "7896", "112233")]
        [InlineData("07897112233", "7897", "112233")]
        [InlineData("07898112233", "7898", "112233")]
        [InlineData("07899112233", "7899", "112233")]
        [InlineData("07900112233", "7900", "112233")]
        [InlineData("07901112233", "7901", "112233")]
        [InlineData("07902112233", "7902", "112233")]
        [InlineData("07903112233", "7903", "112233")]
        [InlineData("07904112233", "7904", "112233")]
        [InlineData("07905112233", "7905", "112233")]
        [InlineData("07906112233", "7906", "112233")]
        [InlineData("07907112233", "7907", "112233")]
        [InlineData("07908112233", "7908", "112233")]
        [InlineData("07909112233", "7909", "112233")]
        [InlineData("07910112233", "7910", "112233")]
        [InlineData("07911112233", "7911", "112233")] // Guernsey Mobile
        [InlineData("07912112233", "7912", "112233")]
        [InlineData("07913112233", "7913", "112233")]
        [InlineData("07914112233", "7914", "112233")]
        [InlineData("07915112233", "7915", "112233")]
        [InlineData("07916112233", "7916", "112233")]
        [InlineData("07917112233", "7917", "112233")]
        [InlineData("07918112233", "7918", "112233")]
        [InlineData("07919112233", "7919", "112233")]
        [InlineData("07920112233", "7920", "112233")]
        [InlineData("07921112233", "7921", "112233")]
        [InlineData("07922112233", "7922", "112233")]
        [InlineData("07923112233", "7923", "112233")]
        [InlineData("07924112233", "7924", "112233")]
        [InlineData("07925112233", "7925", "112233")]
        [InlineData("07926112233", "7926", "112233")]
        [InlineData("07927112233", "7927", "112233")]
        [InlineData("07928112233", "7928", "112233")]
        [InlineData("07929112233", "7929", "112233")]
        [InlineData("07930112233", "7930", "112233")]
        [InlineData("07931112233", "7931", "112233")]
        [InlineData("07932112233", "7932", "112233")]
        [InlineData("07933112233", "7933", "112233")]
        [InlineData("07934112233", "7934", "112233")]
        [InlineData("07935112233", "7935", "112233")]
        [InlineData("07936112233", "7936", "112233")]
        [InlineData("07937112233", "7937", "112233")] // Jersey Mobile
        [InlineData("07938112233", "7938", "112233")]
        [InlineData("07939112233", "7939", "112233")]
        [InlineData("07940112233", "7940", "112233")]
        [InlineData("07941112233", "7941", "112233")]
        [InlineData("07942112233", "7942", "112233")]
        [InlineData("07943112233", "7943", "112233")]
        [InlineData("07944112233", "7944", "112233")]
        [InlineData("07945112233", "7945", "112233")]
        [InlineData("07946112233", "7946", "112233")]
        [InlineData("07947112233", "7947", "112233")]
        [InlineData("07948112233", "7948", "112233")]
        [InlineData("07949112233", "7949", "112233")]
        [InlineData("07950112233", "7950", "112233")]
        [InlineData("07951112233", "7951", "112233")]
        [InlineData("07952112233", "7952", "112233")]
        [InlineData("07953112233", "7953", "112233")]
        [InlineData("07954112233", "7954", "112233")]
        [InlineData("07955112233", "7955", "112233")]
        [InlineData("07956112233", "7956", "112233")]
        [InlineData("07957112233", "7957", "112233")]
        [InlineData("07958112233", "7958", "112233")]
        [InlineData("07959112233", "7959", "112233")]
        [InlineData("07960112233", "7960", "112233")]
        [InlineData("07961112233", "7961", "112233")]
        [InlineData("07962112233", "7962", "112233")]
        [InlineData("07963112233", "7963", "112233")]
        [InlineData("07964112233", "7964", "112233")]
        [InlineData("07965112233", "7965", "112233")]
        [InlineData("07966112233", "7966", "112233")]
        [InlineData("07967112233", "7967", "112233")]
        [InlineData("07968112233", "7968", "112233")]
        [InlineData("07969212233", "7969", "212233")]
        [InlineData("07970112233", "7970", "112233")]
        [InlineData("07971112233", "7971", "112233")]
        [InlineData("07972112233", "7972", "112233")]
        [InlineData("07973112233", "7973", "112233")]
        [InlineData("07974112233", "7974", "112233")]
        [InlineData("07975112233", "7975", "112233")]
        [InlineData("07976112233", "7976", "112233")]
        [InlineData("07977112233", "7977", "112233")]
        [InlineData("07978112233", "7978", "112233")]
        [InlineData("07979112233", "7979", "112233")]
        [InlineData("07980112233", "7980", "112233")]
        [InlineData("07981112233", "7981", "112233")]
        [InlineData("07982112233", "7982", "112233")]
        [InlineData("07983112233", "7983", "112233")]
        [InlineData("07984112233", "7984", "112233")]
        [InlineData("07985112233", "7985", "112233")]
        [InlineData("07986112233", "7986", "112233")]
        [InlineData("07987112233", "7987", "112233")]
        [InlineData("07988112233", "7988", "112233")]
        [InlineData("07989112233", "7989", "112233")]
        [InlineData("07990112233", "7990", "112233")]
        [InlineData("07999112233", "7999", "112233")]
        public void Parse_Known_MobilePhoneNumber(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07911212345", "7911", "212345")]
        [InlineData("07911812345", "7911", "812345")]
        public void Parse_Known_MobilePhoneNumber_DataOnly(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.True(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07600212233", "7600", "212233")]
        [InlineData("07602212233", "7602", "212233")]
        [InlineData("07623112233", "7623", "112233")]
        [InlineData("07625112233", "7625", "112233")]
        [InlineData("07626112233", "7626", "112233")]
        [InlineData("07640112233", "7640", "112233")]
        [InlineData("07641112233", "7641", "112233")]
        [InlineData("07644112233", "7644", "112233")]
        [InlineData("07654112233", "7654", "112233")]
        [InlineData("07659112233", "7659", "112233")]
        [InlineData("07660112233", "7660", "112233")]
        [InlineData("07661112233", "7661", "112233")]
        [InlineData("07663312233", "7663", "312233")]
        [InlineData("07666112233", "7666", "112233")]
        [InlineData("07669112233", "7669", "112233")]
        [InlineData("07677212233", "7677", "212233")]
        [InlineData("07681112233", "7681", "112233")]
        [InlineData("07693112233", "7693", "112233")]
        [InlineData("07699112233", "7699", "112233")]
        public void Parse_Known_MobilePhoneNumber_Pager(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.True(mobilePhoneNumber.IsPager);
            Assert.False(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }

        [Theory]
        [InlineData("07000112233", "7000", "112233")]
        public void Parse_Known_MobilePhoneNumber_Virtual(string value, string areaCode, string localNumber)
        {
            var phoneNumber = _parser.Parse(value).PhoneNumber;

            Assert.NotNull(phoneNumber);
            Assert.IsType<MobilePhoneNumber>(phoneNumber);

            var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
            Assert.Equal(areaCode, mobilePhoneNumber.AreaCode);
            Assert.Equal(CountryInfo.UK, mobilePhoneNumber.Country);
            Assert.False(mobilePhoneNumber.IsDataOnly);
            Assert.False(mobilePhoneNumber.IsPager);
            Assert.True(mobilePhoneNumber.IsVirtual);
            Assert.Equal(localNumber, mobilePhoneNumber.LocalNumber);
        }
    }
}
