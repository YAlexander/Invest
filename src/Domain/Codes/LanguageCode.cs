using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class LanguageCode : TypeCodeBase<string, LanguageCode>, ILanguageCode
	{
		public int NumericCode { get; set; }
		public string ISO6392Code { get; set; }
		public string ISO6393Code { get; set; }
		public string GOSTCode { get; set; }

		public LanguageCode (string code, string description, int numericCode, string iso6392Code, string iso6393Code, string gostCode) : base(code, description)
		{
			NumericCode = numericCode;
			ISO6392Code = iso6392Code;
			ISO6393Code = iso6393Code;
		}

		public static LanguageCode English { get; } = new LanguageCode("EN", "English", 045, "ENG", "ENG", "АНГ");

		public static LanguageCode German { get; } = new LanguageCode("DE", "German", 481, "DEU", "DEU", "НЕМ");

		public static LanguageCode Russian { get; } = new LanguageCode("RU", "Russian", 570, "RUS", "RUS", "РУС");

		public static LanguageCode Ukrainian { get; } = new LanguageCode("UK", "Ukrainian", 720, "UKR", "UKR", "УКР");

		public static LanguageCode French { get; } = new LanguageCode("FR", "French", 745, "FRE", "FRA", "ФРА");
	}
}
