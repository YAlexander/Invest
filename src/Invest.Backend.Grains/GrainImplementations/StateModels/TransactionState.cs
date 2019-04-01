using Abstractions.Codes;
using Abstractions.Grains.StateModels;

namespace Invest.Backend.Grains.GrainImplementations.StateModels
{
	public class TransactionState : ITransactionState
	{
		public long AccountId { get; set; }
		public string TransactionCode { get; set; } = string.Empty;
		public ITransactionTypeCode TransactionTypeType { get; set; }
		public ITransactionStatusCode StatusCode { get; set; }
		public ICurrencyCode CurrencyCode { get; set; }
		public decimal Amount { get; set; }
		public string Description { get; set; } = string.Empty;
	}
}
