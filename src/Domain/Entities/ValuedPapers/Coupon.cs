﻿using System;
using Domain.Codes;

namespace Domain.Entities.ValuedPapers
{
	public class Coupon : BaseEntity
	{
		public long ValuedPaperId { get; set; }

		public int StatusCode { get; set; } = CouponStatusCode.PENDING;

		public string? CurrencyCode { get; set; }

		public decimal Amount { get; set; }

		public DateTime DayOfPayment { get; set; }
	}
}
