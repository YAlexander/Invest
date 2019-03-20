using System;
using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class CurrencyCode : TypeCodeBase<string, CurrencyCode>, ICurrencyCode
	{
		public int? ISOCode { get; set; }
		public string Symbol { get; set; }

		public CurrencyCode (string code, string description, int? isoCode, string symbol) : base(code, description)
		{
			ISOCode = isoCode;
			Symbol = symbol;
		}

		public static CurrencyCode USD { get; } = new CurrencyCode("USD", "US Dollar", 840, "$");

		public static CurrencyCode EUR { get; } = new CurrencyCode("EUR", "Euro", 978, "€");

		public static CurrencyCode RUB { get; } = new CurrencyCode("RUB", "Russian Ruble", 810, "₽");

		public static CurrencyCode UAH { get; } = new CurrencyCode("UAH", "Hryvnia", 980, "₴");

		public static CurrencyCode CNH { get; } = new CurrencyCode("CNH", "Yuan Renminbi", 156, "¥");

		public static CurrencyCode JPY { get; } = new CurrencyCode("JPY", "Japanese Yen", 392, "¥");

		public static CurrencyCode INR { get; } = new CurrencyCode("INR", "Indian Rupee", 356, "₹");

		public static CurrencyCode GBP { get; } = new CurrencyCode("GBP", "Pound Sterling", 826, "£");

		public static CurrencyCode BRL { get; } = new CurrencyCode("BRL", "Brazilian Real", 986, "R$");

		public static CurrencyCode MXN { get; } = new CurrencyCode("MXN", "Mexican Peso", 484, "MX$");

		public static CurrencyCode CAD { get; } = new CurrencyCode("CAD", "Canadian Dollar", 124, "C$");

		public static CurrencyCode KRW { get; } = new CurrencyCode("KRW", "South Korean Won", 410, "₩");

		public static CurrencyCode TRY { get; } = new CurrencyCode("TRY", "Turkish Lira", 949, "₺");

		public static CurrencyCode IDR { get; } = new CurrencyCode("IDR", "Indonesian Rupiah", 360, "Rp");

		public static CurrencyCode AUD { get; } = new CurrencyCode("AUD", "Australian Dollar", 036, "A$");

		public static CurrencyCode TWD { get; } = new CurrencyCode("TWD", "New Taiwan Dollar", 901, "NT$");


		#region Cryptocurrencies

		public static CurrencyCode BTC { get; } = new CurrencyCode("BTC", "Bitcoin", null, "₿");

		public static CurrencyCode ETH { get; } = new CurrencyCode("ETH", "Ethereum", null, String.Empty);

		public static CurrencyCode GLX { get; } = new CurrencyCode("GLX", "Globcoin", null, String.Empty);

		public static CurrencyCode XLM { get; } = new CurrencyCode("XLM", "Stellar", null, String.Empty);

		#endregion
	}
}
