using System;
using Abstractions.Codes;
using Abstractions.Grains.StateModels;
using Domain.Codes;

namespace Invest.Backend.Grains.GrainImplementations.StateModels
{
	public class InvoiceState : IInvoiceState
	{
		public DateTime Created { get; set; }
		public DateTime? ValidTill { get; set; }
		public IInvoiceStatusCode Status { get; set; } = InvoiceStatusCode.PENDING;
		public long BorrowerId { get; set; }
		public long InvestorId { get; set; }
		public long InvestmentId { get; set; }
		public ICurrencyCode Currency { get; set; } = CurrencyCode.UNKNOWN;
		public decimal Amount { get; set; }
		public int? Quantity { get; set; }
	}
}
