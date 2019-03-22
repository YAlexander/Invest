using Domain.Codes;

namespace Domain.Entities
{
	public class Transaction : BaseEntity
	{
		public long AccountId { get; set; }

		public string TransactionCode { get; set; }

		public int TransactionType { get; set; }
		public int StatusCode { get; set; } = TransactionStatusCode.PENDING.Code;

		public string CurrencyCode { get; set; }
		public decimal Amount { get; set; }

		public string Description { get; set; }
	}
}
