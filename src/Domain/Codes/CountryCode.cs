using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class CountryCode : TypeCodeBase<string, CountryCode>, ICountryCode
	{
		public int NumericCode { get; set; }
		public string ISOA3Code { get; set; }
		public string PhoneCodes { get; set; }

		public CountryCode (string code, string description, int numericCode, string isoA3Code, string phoneCodes) : base(code, description)
		{
			PhoneCodes = phoneCodes;
			NumericCode = numericCode;
			ISOA3Code = isoA3Code;
		}

		public static CountryCode Unknown { get; } = new CountryCode("Unknown", "Unknown", 0, null, null);

		public static CountryCode Afghanistan = new CountryCode("AF", "Afghanistan", 004, "AFG", "+93");

		public static CountryCode AlandIslands = new CountryCode("AX", "Aland Islands", 248, "ALA", "+35818");

		public static CountryCode Albania = new CountryCode("AL", "Albania", 008, "ALB", "+355");

		public static CountryCode Algeria = new CountryCode("DZ", "Algeria", 012, "DZA", "+213");

		public static CountryCode AmericanSamoa = new CountryCode("AS", "American Samoa", 016, "ASM", "+1684");

		public static CountryCode Andorra = new CountryCode("AD", "Andorra", 020, "AND", "+376");

		public static CountryCode Angola = new CountryCode("AO", "Angola", 024, "AGO", "+244");

		public static CountryCode Anguilla = new CountryCode("AI", "Anguilla", 660, "AIA", "+1264");

		public static CountryCode Antarctica = new CountryCode("AQ", "Antarctica", 010, "ATA", "+672");

		public static CountryCode AntiguaAndBarbuda = new CountryCode("AG", "Antigua and Barbuda", 028, "ATG", "+1268");

		public static CountryCode Argentina = new CountryCode("AF", "Argentina", 032, "ARG", "+54");

		public static CountryCode Armenia = new CountryCode("AM", "Armenia", 051, "ARM", "+374");

		public static CountryCode Aruba = new CountryCode("AW", "Aruba", 533, "ABW", "+297");

		public static CountryCode Australia = new CountryCode("AU", "Australia", 036, "AUS", "+61;+672;+6721");

		public static CountryCode Austria = new CountryCode("AT", "Austria", 040, "AUT", "+43");

		public static CountryCode Azerbaijan = new CountryCode("AZ", "Azerbaijan", 031, "AZE", "+994");

		public static CountryCode Bahamas = new CountryCode("BS", "Bahamas", 044, "BHS", "+1242");

		public static CountryCode Bahrain = new CountryCode("BH", "Bahrain", 048, "BHR", "+973");

		public static CountryCode Bangladesh = new CountryCode("BD", "Bangladesh", 050, "BGD", "+880");

		public static CountryCode Barbados = new CountryCode("BB", "Barbados", 052, "BRB", "+1246");

		public static CountryCode Belarus = new CountryCode("BY", "Belarus", 112, "BLR", "+375");

		public static CountryCode Belgium = new CountryCode("BE", "Belgium", 056, "BEL", "+32");

		public static CountryCode Belize = new CountryCode("BZ", "Belize", 084, "BLZ	", "+501");

		public static CountryCode Benin = new CountryCode("BJ", "Benin", 204, "BEN", "+229");

		public static CountryCode Bermuda = new CountryCode("BM", "Bermuda", 060, "BMU", "+1441");

		public static CountryCode Bhutan = new CountryCode("BT", "Bhutan", 064, "BTN", "+975");

		public static CountryCode Bolivia = new CountryCode("BO", "Bolivia", 068, "BOL", "+591");

		public static CountryCode BosniaAndHerzegovina = new CountryCode("BA", "Bosnia and Herzegovina", 070, "BIH", "+387");

		public static CountryCode Botswana = new CountryCode("BW", "Botswana", 072, "BWA", "+267");

		public static CountryCode Bouvet = new CountryCode("BV", "Bouvet Island", 074, "BVT", "+47");

		public static CountryCode Brazil = new CountryCode("BR", "Brazil", 076, "BRA", "+55");

		public static CountryCode BritishIndianOceanTerritory = new CountryCode("IO", "British Indian Ocean Territory", 086, "IOT", "+246");

		public static CountryCode BritishVirginIslands = new CountryCode("VG", "British Virgin Islands", 092, "VGB", "+1284");

		public static CountryCode Brunei = new CountryCode("BN", "Brunei Darussalam", 096, "BRN", "+673");

		public static CountryCode Bulgaria = new CountryCode("BG", "Bulgaria", 100, "BGR", "+359");

		public static CountryCode BurkinaFaso = new CountryCode("BF", "Burkina Faso", 854, "BFA", "+226");

		public static CountryCode Burundi = new CountryCode("BI", "Burundi", 108, "BDI", "+257");

		public static CountryCode Cambodia = new CountryCode("KH", "Cambodia", 116, "KHM", "+855");

		public static CountryCode Cameroon = new CountryCode("CM", "Cameroon", 120, "CMR", "+237");

		public static CountryCode Canada = new CountryCode("CA", "Canada", 124, "CAN", "+1");

		public static CountryCode CapeVerde = new CountryCode("CV", "Cape Verde", 132, "CPV", "+238");

		public static CountryCode CaymanIslands = new CountryCode("KY", "Cayman Islands", 136, "CYM", "	+1345");

		public static CountryCode CentralAfricanRepublic = new CountryCode("CF", "Central African Republic", 140, "CAF", "+236");

		public static CountryCode Chad = new CountryCode("TD", "Chad", 148, "TCD", "+235");

		public static CountryCode Chile = new CountryCode("CL", "Chile", 152, "CHL", "+56");

		public static CountryCode China = new CountryCode("CN", "China", 156, "CHN", "+86");

		public static CountryCode ChristmasIsland = new CountryCode("CX", "Christmas Island", 162, "CXR", "+6189164");

		public static CountryCode CocosIslands = new CountryCode("CC", "Cocos Islands", 166, "CCK", "+6189162");

		public static CountryCode Colombia = new CountryCode("CO", "Colombia", 170, "COL", "+57");

		public static CountryCode Comoros = new CountryCode("KM", "Comoros", 174, "COM", "+269");

		public static CountryCode Congo = new CountryCode("CG", "Congo", 178, "COG", "+242");

		public static CountryCode Zaire = new CountryCode("CD", "Democratic Republic of the Congo", 180, "COD", "+243");

		public static CountryCode CookIslands = new CountryCode("CK", "Cook Islands", 184, "COK", "+682");

		public static CountryCode CostaRica = new CountryCode("CR", "Costa Rica", 188, "CRI", "+506");

		public static CountryCode CoteDIvoire = new CountryCode("CI", "Côte d'Ivoire", 384, "CIV", "+225");

		public static CountryCode Croatia = new CountryCode("HR", "Croatia", 191, "HRV", "+385");

		public static CountryCode Cuba = new CountryCode("CU", "Cuba", 192, "CUB", "+53");

		public static CountryCode Cyprus = new CountryCode("CY", "Cyprus", 196, "CYP", "+357");

		public static CountryCode CzechRepublic = new CountryCode("CZ", "Czech Republic", 203, "CZE", "+420");

		public static CountryCode Denmark = new CountryCode("DK", "Denmark", 208, "DNK", "+45");

		public static CountryCode Djibouti = new CountryCode("DJ", "Djibouti", 262, "DJI", "+253");

		public static CountryCode Dominica = new CountryCode("DM", "Dominica", 212, "DMA", "+1767");

		public static CountryCode DominicanRepublic = new CountryCode("DO", "Dominican Republic", 214, "DOM", "+1809, +1829, +1849");

		public static CountryCode Ecuador = new CountryCode("EC", "Ecuador", 218, "ECU", "+593");

		public static CountryCode Egypt = new CountryCode("EG", "Egypt", 818, "EGY", "+20");

		public static CountryCode ElSalvador = new CountryCode("SV", "El Salvador", 222, "SLV", "+503");

		public static CountryCode EquatorialGuinea = new CountryCode("GQ", "Equatorial Guinea", 226, "GNQ", "+240");

		public static CountryCode Eritrea = new CountryCode("ER", "Eritrea", 232, "ERI", "+291");

		public static CountryCode Estonia = new CountryCode("EE", "Estonia", 233, "EST", "+372");

		public static CountryCode Ethiopia = new CountryCode("ET", "Ethiopia", 231, "ETH", "+251");

		public static CountryCode FalklandIslands = new CountryCode("FK", "Falkland Islands", 238, "FLK", "+500");

		public static CountryCode FaroeIslands = new CountryCode("FO", "Faroe Islands", 234, "FRO", "+298");

		public static CountryCode Fiji = new CountryCode("FJ", "Fiji", 242, "FJI", "+679");

		public static CountryCode Finland = new CountryCode("FI", "Finland", 246, "FIN", "+358");

		public static CountryCode France = new CountryCode("FR", "France", 250, "FRA", "+33");

		public static CountryCode FrenchGuiana = new CountryCode("GF", "French Guiana", 254, "GUF", "+594");

		public static CountryCode FrenchPolynesia = new CountryCode("PF", "French Polynesia", 258, "PYF", "+689");

		public static CountryCode FrenchSouthernTerritories = new CountryCode("TF", "French Southern Territories", 260, "ATF", "+262");

		public static CountryCode Gabon = new CountryCode("GA", "Gabon", 266, "GAB", "+241");

		public static CountryCode Gambia = new CountryCode("GM", "Gambia", 270, "GMB", "+220");

		public static CountryCode Georgia = new CountryCode("GE", "Georgia", 268, "GEO", "+995");

		public static CountryCode Germany = new CountryCode("DE", "Germany", 276, "DEU", "+49");

		public static CountryCode Ghana = new CountryCode("GH", "Germany", 288, "GHA", "+233");

		public static CountryCode Gibraltar = new CountryCode("GI", "Gibraltar", 292, "GIB", "+350");

		public static CountryCode Greece = new CountryCode("GR", "Greece", 300, "GRC", "+30");

		public static CountryCode Greenland = new CountryCode("GL", "Greenland", 304, "GRL", "+299");

		public static CountryCode Grenada = new CountryCode("GD", "Grenada", 308, "GRD", "+1473");

		public static CountryCode Guadeloupe = new CountryCode("GP", "Guadeloupe", 312, "GLP", "+590");

		public static CountryCode Guam = new CountryCode("GU", "Guam", 316, "GUM", "+1671");

		public static CountryCode Guatemala = new CountryCode("GT", "Guatemala", 320, "GTM", "+502");

		public static CountryCode Guernsey = new CountryCode("GG", "Guernsey", 831, "GGY", "+441481,+447781,+447839,+447911");

		public static CountryCode Guinea = new CountryCode("GN", "Guinea", 324, "GIN", "+224");

		public static CountryCode GuineaBissau = new CountryCode("GW", "Guinea-Bissau", 624, "GNB", "+245");

		public static CountryCode Guyana = new CountryCode("GY", "Guyana", 328, "GUY", "+592");

		public static CountryCode Haiti = new CountryCode("HT", "Haiti", 332, "HTI", "+509");

		public static CountryCode HeardAndMcDonaldIslands = new CountryCode("HM", "Heard and Mcdonald Islands", 334, "HMD", "+672");

		public static CountryCode Vatican = new CountryCode("VA", "Holy See (Vatican City State)", 336, "VAT", "+379");

		public static CountryCode Honduras = new CountryCode("HN", "Honduras", 340, "HND", "+504");

		public static CountryCode HongKong = new CountryCode("HK", "Hong Kong", 344, "HKG", "+852");

		public static CountryCode Hungary = new CountryCode("HU", "Hungary", 348, "HUN", "+36");

		public static CountryCode Iceland = new CountryCode("IS", "Iceland", 352, "ISL", "+354");

		public static CountryCode India = new CountryCode("IN", "India", 356, "IND", "+91");

		public static CountryCode Indonesia = new CountryCode("ID", "Indonesia", 360, "IDN", "+62");

		public static CountryCode Iran = new CountryCode("IR", "Islamic Republic of Iran", 364, "IRN", "+98");

		public static CountryCode Iraq = new CountryCode("IQ", "Iraq", 368, "IRQ", "+964");

		public static CountryCode Ireland = new CountryCode("IE", "Ireland", 372, "IRL", "+353");

		public static CountryCode IsleOfMan = new CountryCode("IM", "Isle of Man", 833, "IMN", "+441624,+447524,+447624,+447924");

		public static CountryCode Israel = new CountryCode("IL", "Israel", 376, "ISR", "+972");

		public static CountryCode Italy = new CountryCode("IT", "Italy", 380, "ITA", "+39");

		public static CountryCode Jamaica = new CountryCode("JM", "Jamaica", 388, "JAM", "+1876");

		public static CountryCode Japan = new CountryCode("JP", "Japan", 392, "JPN", "+81");

		public static CountryCode Jersey = new CountryCode("JE", "Jersey", 832, "JEY", "+441534");

		public static CountryCode Jordan = new CountryCode("JO", "Jordan", 400, "JOR", "+962");

		public static CountryCode Kazakhstan = new CountryCode("KZ", "Kazakhstan", 398, "KAZ", "+76,+77");

		public static CountryCode Kenya = new CountryCode("KE", "Kenya", 404, "KEN", "+254");

		public static CountryCode Kiribati = new CountryCode("KI", "Kiribati", 296, "KIR", "+686");

		public static CountryCode NorthKorea = new CountryCode("KP", "Democratic People's Republic of Korea", 408, "PRK", "+850");

		public static CountryCode SouthKorea = new CountryCode("KR", "Republic of Korea", 410, "KOR", "+82");

		public static CountryCode Kuwait = new CountryCode("KW", "Kuwait", 414, "KWT", "+965");

		public static CountryCode Kyrgyzstan = new CountryCode("KG", "Kyrgyzstan", 417, "KGZ", "+996");

		public static CountryCode Laos = new CountryCode("LA", "Lao People's Democratic Republic", 418, "LAO", "+856");

		public static CountryCode Latvia = new CountryCode("LV", "Latvia", 428, "LVA", "+371");

		public static CountryCode Lebanon = new CountryCode("LB", "Lebanon", 422, "LBN", "+961");

		public static CountryCode Lesotho = new CountryCode("LS", "Lesotho", 426, "LSO", "+266");

		public static CountryCode Liberia = new CountryCode("LR", "Liberia", 430, "LBR", "+231");

		public static CountryCode Libya = new CountryCode("LY", "Libya", 434, "LBY", "+218");

		public static CountryCode Liechtenstein = new CountryCode("LI", "Liechtenstein", 438, "LIE", "+423");

		public static CountryCode Lithuania = new CountryCode("LT", "Lithuania", 440, "LTU", "+370");

		public static CountryCode Luxembourg = new CountryCode("LU", "Luxembourg", 442, "LUX", "+352");

		public static CountryCode Macedonia = new CountryCode("MK", "Macedonia", 807, "MKD", "+389");

		public static CountryCode Madagascar = new CountryCode("MG", "Madagascar", 450, "MDG", "+261");

		public static CountryCode Malawi = new CountryCode("MW", "Malawi", 454, "MWI", "+265");

		public static CountryCode Malaysia = new CountryCode("MY", "Malaysia", 458, "MYS", "+60");

		public static CountryCode Maldives = new CountryCode("MV", "Maldives", 462, "MDV", "+960");

		public static CountryCode Mali = new CountryCode("ML", "Mali", 466, "MLI", "+223");

		public static CountryCode Malta = new CountryCode("MT", "Malta", 470, "MLT", "+356");

		public static CountryCode MarshallIslands = new CountryCode("MH", "Marshall Islands", 584, "MHL", "+692");

		public static CountryCode Mauritania = new CountryCode("MR", "Mauritania", 478, "MRT", "+222");

		public static CountryCode Mauritius = new CountryCode("MU", "Mauritius", 480, "MUS", "+230");

		public static CountryCode Mayotte = new CountryCode("YT", "Mayotte", 175, "MYT", "+262");

		public static CountryCode Mexico = new CountryCode("MX", "Mexico", 484, "MEX", "+52");

		public static CountryCode Micronesia = new CountryCode("FM", "Federated States of Micronesia", 583, "FSM", "+691");

		public static CountryCode Moldova = new CountryCode("MD", "Republic of Moldova", 498, "MDA", "+373");

		public static CountryCode Monaco = new CountryCode("MC", "Monaco", 492, "MCO", "+377");

		public static CountryCode Mongolia = new CountryCode("MN", "Mongolia", 496, "MNG", "+976");

		public static CountryCode Montenegro = new CountryCode("ME", "Montenegro", 499, "MNE", "+382");

		public static CountryCode Montserrat = new CountryCode("MS", "Montserrat", 500, "MSR", "+1 664");

		public static CountryCode Morocco = new CountryCode("MA", "Morocco", 504, "MAR", "+212");

		public static CountryCode Mozambique = new CountryCode("MZ", "Mozambique", 508, "MOZ", "+258");

		public static CountryCode Myanmar = new CountryCode("MM", "Myanmar", 104, "MMR", "+95");

		public static CountryCode Namibia = new CountryCode("NA", "Namibia", 516, "NAM", "+264");

		public static CountryCode Nauru = new CountryCode("NR", "Nauru", 520, "NRU", "+674");

		public static CountryCode Nepal = new CountryCode("NP", "Nepal", 524, "NPL", "+977");

		public static CountryCode Netherlands = new CountryCode("NL", "Netherlands", 528, "NLD", "+31");

		public static CountryCode NewCaledonia = new CountryCode("NC", "New Caledonia", 540, "NCL", "+687");

		public static CountryCode NewZealand = new CountryCode("NZ", "New Zealand", 554, "NZL", "+64");

		public static CountryCode Nicaragua = new CountryCode("NI", "Nicaragua", 558, "NIC", "+505");

		public static CountryCode Niger = new CountryCode("NE", "Niger", 562, "NER", "+227");

		public static CountryCode Nigeria = new CountryCode("NG", "Nigeria", 566, "NGA", "+234");

		public static CountryCode Niue = new CountryCode("NU", "Niue", 570, "NIU", "+683");

		public static CountryCode NorthernMarianaIslands = new CountryCode("MP", "Northern Mariana Islands", 580, "MNP", "+1670");

		public static CountryCode Norway = new CountryCode("NO", "Norway", 578, "NOR", "+47");

		public static CountryCode Oman = new CountryCode("OM", "Oman", 512, "OMN", "+968");

		public static CountryCode Pakistan = new CountryCode("PK", "Pakistan", 586, "PAK", "+92");

		public static CountryCode Palau = new CountryCode("PW", "Palau", 585, "PLW", "+680");

		public static CountryCode Palestine = new CountryCode("PS", "State of Palestine", 275, "PSE", "+970");

		public static CountryCode Panama = new CountryCode("PA", "Panama", 591, "PAN", "+507");

		public static CountryCode PapuaNewGuinea = new CountryCode("PG", "Papua New Guinea", 598, "PNG", "+675");

		public static CountryCode Paraguay = new CountryCode("PY", "Paraguay", 600, "PRY", "+595");

		public static CountryCode Peru = new CountryCode("PE", "Peru", 604, "PER", "+51");

		public static CountryCode Philippines = new CountryCode("PH", "Philippines", 608, "PHL", "+63");

		public static CountryCode Pitcairn = new CountryCode("PN", "Pitcairn", 612, "PCN", "+64");

		public static CountryCode Poland = new CountryCode("PL", "Poland", 616, "POL", "+48");

		public static CountryCode Portugal = new CountryCode("PT", "Portugal", 620, "PRT", "+351");

		public static CountryCode PuertoRico = new CountryCode("PR", "Puerto Rico", 630, "PRI", "+1787,+1939");

		public static CountryCode Qatar = new CountryCode("QA", "Qatar", 634, "QAT", "+974");

		public static CountryCode Reunion = new CountryCode("RE", "Réunion", 638, "REU", "+262");

		public static CountryCode Romania = new CountryCode("RO", "Romania", 642, "ROU", "+40");

		public static CountryCode Russia = new CountryCode("RU", "Russian Federation", 643, "RUS", "+7");

		public static CountryCode Rwanda = new CountryCode("RW", "Rwanda", 646, "RWA", "+250");

		public static CountryCode SaintBarthelemy = new CountryCode("BL", "Saint Barthélemy", 652, "BLM", "+590");

		public static CountryCode SaintHelena = new CountryCode("SH", "Saint Helena, Ascension and Tristan da Cunha", 654, "SHN", "+290");

		public static CountryCode SaintKittsAndNevis = new CountryCode("KN", "Saint Kitts and Nevis", 659, "KNA", "+1869");

		public static CountryCode SaintLucia = new CountryCode("LC", "Saint Lucia", 662, "LCA", "+1758");

		public static CountryCode SaintMartin = new CountryCode("MF", "Saint Martin", 663, "MAF", "+590");

		public static CountryCode SaintPierreAndMiquelon = new CountryCode("PM", "Saint Pierre and Miquelon", 666, "SPM", "+508");

		public static CountryCode SaintVincentAndTheGrenadines = new CountryCode("VC", "Saint Vincent and the Grenadines", 670, "VCT", "+1784");

		public static CountryCode Samoa = new CountryCode("WS", "Samoa", 882, "WSM", "+685");

		public static CountryCode SanMarino = new CountryCode("SM", "San Marino", 674, "SMR", "+378");

		public static CountryCode SaoTomeAndPrincipe = new CountryCode("ST", "Sao Tome and Principe", 678, "STP", "+239");

		public static CountryCode SaudiArabia = new CountryCode("SA", "Saudi Arabia", 682, "SAU", "+966");

		public static CountryCode Senegal = new CountryCode("SN", "Senegal", 686, "SEN", "+221");

		public static CountryCode Serbia = new CountryCode("RS", "Serbia", 688, "SRB", "+381");

		public static CountryCode Seychelles = new CountryCode("SC", "Seychelles", 690, "SYC", "+248");

		public static CountryCode SierraLeone = new CountryCode("SL", "Sierra Leone", 694, "SLE", "+232");

		public static CountryCode Singapore = new CountryCode("SG", "Singapore", 702, "SGP", "+65");

		public static CountryCode Slovakia = new CountryCode("SK", "Slovakia", 703, "SVK", "+421");

		public static CountryCode Slovenia = new CountryCode("SI", "Slovenia", 705, "SVN", "+386");

		public static CountryCode SolomonIslands = new CountryCode("SB", "Solomon Islands", 090, "SLB", "+677");

		public static CountryCode Somalia = new CountryCode("SO", "Somalia", 706, "SOM", "+252");

		public static CountryCode SouthAfrica = new CountryCode("ZA", "South Africa", 710, "ZAF", "+27");

		public static CountryCode SouthSudan = new CountryCode("SS", "South Sudan", 728, "SSD", "+211");

		public static CountryCode Spain = new CountryCode("ES", "Spain", 724, "ESP", "+34");

		public static CountryCode SriLanka = new CountryCode("LK", "Sri Lanka", 144, "LKA", "+94");

		public static CountryCode Sudan = new CountryCode("SD", "Sudan", 736, "SDN", "+249");

		public static CountryCode Suriname = new CountryCode("SR", "Suriname", 740, "SUR", "+597");

		public static CountryCode Svalbard = new CountryCode("SJ", "Svalbard and Jan Mayen", 744, "SJM", "+47");

		public static CountryCode Swaziland = new CountryCode("SZ", "Swaziland", 748, "SWZ", "+268");

		public static CountryCode Sweden = new CountryCode("SE", "Sweden", 752, "SWE", "+46");

		public static CountryCode Switzerland = new CountryCode("CH", "Switzerland", 756, "CHE", "+41");

		public static CountryCode Syrian = new CountryCode("SY", "Syrian Arab Republic", 760, "SYR", "+963");

		public static CountryCode Taiwan = new CountryCode("TW", "Taiwan", 158, "TWN", "+886");

		public static CountryCode Tajikistan = new CountryCode("TJ", "Tajikistan", 762, "TJK", "+992");

		public static CountryCode Tanzania = new CountryCode("TZ", "United Republic of Tanzania", 834, "TZA", "+255");

		public static CountryCode Thailand = new CountryCode("TH", "Thailand", 764, "THA", "+66");

		public static CountryCode Togo = new CountryCode("TG", "Togo", 768, "TGO", "+228");

		public static CountryCode Tokelau = new CountryCode("TK", "Tokelau", 772, "TKL", "+690");

		public static CountryCode Tonga = new CountryCode("TO", "Tonga", 776, "TON", "+676");

		public static CountryCode TrinidadAndTobago = new CountryCode("TT", "Trinidad and Tobago", 780, "TTO", "+1868");

		public static CountryCode Tunisia = new CountryCode("TN", "Tunisia", 788, "TUN", "+216");

		public static CountryCode Turkey = new CountryCode("TR", "Turkey", 792, "TUR", "+90");

		public static CountryCode Turkmenistan = new CountryCode("TM", "Turkmenistan", 795, "TKM", "+993");

		public static CountryCode TurksAndCaicosIslands = new CountryCode("TC", "Turks and Caicos Islands", 796, "TCA", "+1649");

		public static CountryCode Tuvalu = new CountryCode("TV", "Tuvalu", 798, "TUV", "+688");

		public static CountryCode Uganda = new CountryCode("UG", "Uganda", 800, "UGA", "+256");

		public static CountryCode Ukraine = new CountryCode("UA", "Ukraine", 804, "UKR", "+380");

		public static CountryCode UnitedArabEmirates = new CountryCode("AE", "United Arab Emirates", 784, "ARE", "+971");

		public static CountryCode UnitedKingdom = new CountryCode("GB", "United Kingdom", 826, "GBR", "+44");

		public static CountryCode USA = new CountryCode("US", "United States of America", 840, "USA", "+1");

		public static CountryCode Uruguay = new CountryCode("UY", "Uruguay", 858, "URY", "+598");

		public static CountryCode Uzbekistan = new CountryCode("UZ", "Uzbekistan", 860, "UZB", "+998");

		public static CountryCode Vanuatu = new CountryCode("VU", "Vanuatu", 548, "VUT", "+678");

		public static CountryCode Venezuela = new CountryCode("VE", "Bolivarian Republic of Venezuela", 682, "VEN", "+58");

		public static CountryCode Vietnam = new CountryCode("VN", "Socialist Republic of Vietnam", 704, "VNM", "+84");

		public static CountryCode USVirginIslands = new CountryCode("VI", "US Virgin Islands", 850, "VIR", "+1340");

		public static CountryCode WallisAndFutuna = new CountryCode("WF", "Wallis and Futuna", 876, "WLF", "+681");

		public static CountryCode WesternSahara = new CountryCode("EH", "Western Sahara", 732, "ESH", "+212");

		public static CountryCode Yemen = new CountryCode("YE", "Yemen", 887, "YEM", "+967");

		public static CountryCode Zambia = new CountryCode("ZM", "Zambia", 894, "ZMB", "+260");

		public static CountryCode Zimbabwe = new CountryCode("ZW", "Zimbabwe", 716, "ZWE", "+263");
	}
}
