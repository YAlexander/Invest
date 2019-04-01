using System;

namespace Invest.Site.Core.Models
{
	public class InvestedInfoDTO
	{
		public DateTime BoughtDate { get; set; }
		public string Country { get; set; } = string.Empty;
		public decimal Amount { get; set; }
		public int? NumberOfShares { get; set; }
	}
}
