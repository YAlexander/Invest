namespace Domain.Entities
{
	public class InvestmentShare : BaseEntity
	{
		/// <summary>
		/// Investor Id
		/// </summary>
		public long ShareOwner { get; set; }

		public long InvestmentId { get; set; }

		public decimal Price { get; set; }

		public int? NumberOfShares { get; set; }

		public long? InvoiceId { get; set; } 
	}
}
