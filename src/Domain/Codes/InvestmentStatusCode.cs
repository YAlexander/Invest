using Abstractions.Codes;

namespace Domain.Codes
{
	public class InvestmentStatusCode : TypeCodeBase<int, InvestmentStatusCode>, IInvestmentStatusCode
	{
		public InvestmentStatusCode(int code, string description) : base(code, description)
		{
		}

		/// <summary>
		/// Status for new and on review investments
		/// </summary>
		public static InvestmentStatusCode Pending { get; } = new InvestmentStatusCode(10, "Pending");

		/// <summary>
		/// Status for start funds collecting
		/// </summary>
		public static InvestmentStatusCode Active { get; } = new InvestmentStatusCode(20, "Active");

		/// <summary>
		/// Successful, all funds collected
		/// </summary>
		public static InvestmentStatusCode Collected { get; } = new InvestmentStatusCode(30, "Collected");

		/// <summary>
		/// Funds is not collected
		/// </summary>
		public static InvestmentStatusCode Failed { get; } = new InvestmentStatusCode(40, "Failed");

		/// <summary>
		/// Old investments
		/// </summary>
		public static InvestmentStatusCode Archived { get; } = new InvestmentStatusCode(90, "Archived");
	}
}
