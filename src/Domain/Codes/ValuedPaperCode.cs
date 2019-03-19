using Abstractions.Codes;

namespace Domain.Codes
{
	public class ValuedPaperCode : TypeCodeBase<string, ValuedPaperCode>, IValuedPaperCode
	{
		public ValuedPaperCode(string code, string description) : base(code, description)
		{
		}

		public static ValuedPaperCode Unknown { get; } = new ValuedPaperCode("U", "Unknown");

		public static ValuedPaperCode CorporateBond { get; } = new ValuedPaperCode("B", "Corporate Bond");

		public static ValuedPaperCode ConvertibleBond { get; } = new ValuedPaperCode("CB", "Convertible Bond");

		public static ValuedPaperCode CommonStock { get; } = new ValuedPaperCode("CS", "Common Stock");

		public static ValuedPaperCode Voucher { get; } = new ValuedPaperCode("V", "Voucher");

		public static ValuedPaperCode Bill { get; } = new ValuedPaperCode("BL", "Bill of Loan");

		public static ValuedPaperCode Share { get; } = new ValuedPaperCode("S", "Share Certificate");
	}
}
