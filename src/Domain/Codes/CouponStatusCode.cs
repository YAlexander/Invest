using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Codes
{
	public class CouponStatusCode : TypeCodeBase<int, CouponStatusCode>
	{
		public CouponStatusCode(int code, string description) : base(code, description)
		{
		}

		public static CouponStatusCode UNKNOWN { get; } = new CouponStatusCode(0, "Invalid status code");

		public static CouponStatusCode PENDING { get; } = new CouponStatusCode(10, "Pending");

		public static CouponStatusCode PAID { get; } = new CouponStatusCode(20, "Paid");

		public static CouponStatusCode VOIDED { get; } = new CouponStatusCode(30, "Voided");
	}
}
