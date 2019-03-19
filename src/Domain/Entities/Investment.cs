using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
	public class Investment
	{
		public int InvestmentTypeCode { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
	}
}
