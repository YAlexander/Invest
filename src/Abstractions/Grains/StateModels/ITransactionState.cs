using System;
using System.Collections.Generic;
using System.Text;
using Abstractions.Codes;

namespace Abstractions.Grains.StateModels
{
	public interface ITransactionState
	{
		long AccountId { get; set; }

		string TransactionCode { get; set; }

		ITransactionTypeCode TransactionTypeType { get; set; }

		ITransactionStatusCode StatusCode { get; set; }

		ICurrencyCode CurrencyCode { get; set; }

		decimal Amount { get; set; }

		string Description { get; set; }
	}
}
