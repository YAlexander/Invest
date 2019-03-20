namespace Domain.Codes
{
	public class InvestmentTypeCode : TypeCodeBase<int, InvestmentTypeCode>
	{
		public InvestmentTypeCode(int code, string description) : base(code, description)
		{
		}

		/// <summary>
		/// Type code is not recognized
		/// </summary>
		public static InvestmentTypeCode Unknown { get; } = new InvestmentTypeCode(0, "Unknown");

		/// <summary>
		/// Corporate loan. Associated valued paper is bond
		/// </summary>
		public static InvestmentTypeCode CorporateLoan { get; } = new InvestmentTypeCode(10, "Corporate loan");

		/// <summary>
		/// CrowdFunding. Associated valued paper is convertible bond
		/// </summary>
		public static InvestmentTypeCode CrowdFunding { get; } = new InvestmentTypeCode(20, "CrowdFunding");

		/// <summary>
		/// Common private loan. Associated valued paper is bill
		/// </summary>
		public static InvestmentTypeCode PrivateLoan { get; } = new InvestmentTypeCode(30, "Private Loan");

		public static InvestmentTypeCode PrivateAutoLoan { get; } = new InvestmentTypeCode(31, "Private Loan Auto");

		public static InvestmentTypeCode PrivateMortgagesLoan { get; } = new InvestmentTypeCode(32, "Private Loan Mortgages");

		public static InvestmentTypeCode PrivateStudentLoan { get; } = new InvestmentTypeCode(33, "Private Loan Student");

		public static InvestmentTypeCode PrivateMedicalLoan { get; } = new InvestmentTypeCode(34, "Private Loan Medical");

		/// <summary>
		/// Sell business or it's part. Associated valued paper is stock
		/// </summary>
		public static InvestmentTypeCode PartOfBusiness { get; } = new InvestmentTypeCode(40, "Part Of Business");

		/// <summary>
		/// EFT. Associated valued paper is share
		/// </summary>
		public static InvestmentStatusCode ExchangeTradedFund { get; } = new InvestmentStatusCode(50, "Exchange-Traded Fund");

		/// <summary>
		/// Charitable crowdfunding. Associated valued paper is share
		/// </summary>
		public static InvestmentStatusCode Charitable { get; } = new InvestmentStatusCode(60, "Charitable Fund");
	}
}
