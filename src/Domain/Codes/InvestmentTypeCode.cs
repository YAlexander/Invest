using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Codes
{
	public class InvestmentTypeCode : TypeCodeBase<int, InvestmentTypeCode>
	{
		public InvestmentTypeCode(int code, string description) : base(code, description)
		{
		}

		public static InvestmentTypeCode CorporateLoan { get; } = new InvestmentTypeCode(10, "Corporate loan");

		public static InvestmentTypeCode PrivateLoan { get; } = new InvestmentTypeCode(20, "Private Loan");
	}
}
