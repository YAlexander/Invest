using System;
using System.Collections.Generic;

namespace Invest.Site.Core.Models
{
	public class InvestmentDTO
	{
		public long Id { get; set; }
		public bool IsVerified { get; set; }
		public string InventoryCode { get; set; } = string.Empty;
		public string CountryCode { get; set; } = string.Empty;
		public string Location { get; set; } = string.Empty;

		public CustomerDTO Customer { get; set; } = new CustomerDTO();

		public int Status { get; set; }
		public int InvestmentType { get; set; }

		public DateTime? StartDate { get; set; }
		public DateTime TillDate { get; set; }

		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string VideoLink { get; set; } = string.Empty;

		public string CurrencyCode { get; set; } = string.Empty;
		public decimal TotalAmount { get; set; }
		public decimal CollectedAmount { get; set; }

		public int? NumberOfShares { get; set; }
		public decimal? SharePrice { get; set; }

		public List<InvestedInfoDTO> InvestedInfos { get; set; } = new List<InvestedInfoDTO>();
	}
}
