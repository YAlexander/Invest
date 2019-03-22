using System;
using Domain.Codes;

namespace Domain.Entities
{
	public class Invoice : BaseEntity
	{
		public long SellerId { get; set; }
		public long BuyerId { get; set; }

		public DateTime? ValidTill { get; set; }

		public int StatusCode { get; set; } = InvoiceStatusCode.PENDING.Code;

		public string CurrencyCode { get; set; }
		public decimal TotalAmount { get; set; }
		public decimal? Tax { get; set; }
		public decimal? Discount { get; set; }
	}
}
