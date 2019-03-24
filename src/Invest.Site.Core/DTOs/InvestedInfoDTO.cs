using System;

namespace Invest.Site.Core.DTOs
{
	public class InvestedInfoDTO
	{
		public DateTime BoughtDate { get; set; }
		public string Country { get; set; }
		public decimal Amount { get; set; }
		public int? NumberOfShares { get; set; }
	}
}
