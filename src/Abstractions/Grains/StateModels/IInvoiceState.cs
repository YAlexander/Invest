using System;
using Abstractions.Codes;

namespace Abstractions.Grains.StateModels
{
	public interface IInvoiceState : IState
	{
		DateTime Created { get; set; }
		DateTime? ValidTill { get; set; }

		IInvoiceStatusCode Status { get; set; }

		long BorrowerId { get; set; }
		long InvestorId { get; set; }
		long InvestmentId { get; set; }

		ICurrencyCode Currency { get; set; }
		decimal Amount { get; set; }
		int? Quantity { get; set; }
	}
}
