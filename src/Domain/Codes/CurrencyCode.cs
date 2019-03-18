using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class CurrencyCode : TypeCodeBase<string, CurrencyCode>, ICurrencyCode
	{
		public int ISOCode { get; set; }
		public string Symbol { get; set; }

		public CurrencyCode (string code, string description, int isoCode, string symbol) : base(code, description)
		{
			ISOCode = isoCode;
			Symbol = symbol;
		}

		public static CurrencyCode USDollar { get; } = new CurrencyCode("USD", "US Dollar", 840, "$");

		public static CurrencyCode Euro { get; } = new CurrencyCode("EUR", "Euro", 978, "€");

		public static CurrencyCode RusRuble { get; } = new CurrencyCode("RUB", "Russian Ruble", 810, "₽");

		public static CurrencyCode UkrHryvnia { get; } = new CurrencyCode("UAH", "Hryvnia", 980, "₴");
	}
}
