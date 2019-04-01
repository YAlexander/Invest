using System;
using Abstractions.Codes;

namespace Abstractions.Entities
{
	public interface IInvoice : IEntity
	{
		DateTime? ValidTill { get; set; }

		int Status { get; set; }

		long BorrowerId { get; set; }
		long InvestorId { get; set; }
		long InvestmentId { get; set; }

		ICurrencyCode CurrencyCode { get; set; }
		decimal Amount { get; set; }
		int? Quantity { get; set; }
	}
}
