using System;

namespace Invest.Site.Core.DTOs
{
	public class TransactionDTO
	{
		public long Id { get; set; }
		public DateTime Created { get; set; }
		public long AccountId { get; set; }

		public string TransactionCode { get; set; } = string.Empty;

		public int TransactionType { get; set; }
		public int StatusCode { get; set; }

		public string CurrencyCode { get; set; } = string.Empty;
		public decimal Amount { get; set; }

		public string Description { get; set; } = string.Empty;
	}
}
