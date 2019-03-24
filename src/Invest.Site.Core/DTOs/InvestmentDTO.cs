using System;
using System.Collections.Generic;

namespace Invest.Site.Core.DTOs
{
	public class InvestmentDTO
	{
		public bool IsVerified { get; set; }
		public string InventoryCode { get; set; }
		public string CountryCode { get; set; }
		public string Location { get; set; }

		public CustomerDTO Customer { get; set; }

		public int Status { get; set; }
		public int InvestmentType { get; set; }

		public DateTime? StartDate { get; set; }
		public DateTime TillDate { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
		public string VideoLink { get; set; }

		public string CurrencyCode { get; set; }
		public decimal TotalAmount { get; set; }
		public decimal CollectedAmount { get; set; }

		public int? NumberOfShares { get; set; }
		public decimal? SharePrice { get; set; }

		public List<InvestedInfoDTO> InvestedInfos { get; set; }
	}
}
