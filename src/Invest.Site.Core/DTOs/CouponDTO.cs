using System;

namespace Invest.Site.Core.DTOs
{
	public class CouponDTO
	{
		public long Id { get; set; }

		public DateTime Created { get; set; }

		public int StatusCode { get; set; }

		public string CurrencyCode { get; set; } = string.Empty;

		public decimal Amount { get; set; }

		public DateTime DayOfPayment { get; set; }
	}
}
