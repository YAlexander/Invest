using Domain.Codes;

namespace Domain.Entities
{
	public class Investment : BaseEntity
	{
		/// <summary>
		/// Unique public number of investment
		/// </summary>
		public string InvestmentCode { get; set; }
		public long InvestmentOwner { get; set; }

		public int InvestmentTypeCode { get; set; }

		public int StatusCode { get; set; } = InvestmentStatusCode.Pending.Code;
		public bool IsVerified { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }

		/// <summary>
		/// Collect funds in this currency
		/// </summary>
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Total investment price
		/// </summary>
		public decimal TotalAmount { get; set; }
		public decimal CollectedAmount { get; set; }
		public int? NumberOfShares { get; set; }
		public decimal? SharePrice { get; set; }
	}
}
