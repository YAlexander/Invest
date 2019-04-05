using Abstractions.Codes;

namespace Abstractions.Infrastructure.Payments
{
	public interface IPaymentOptions
	{
		int PaymentService { get; set; }

		long FromAccount { get; set; }
		long? ToAccount { get; set; }

		/// <summary>
		/// Json string with payment details
		/// </summary>
		string PaymentDetails { get; set; }

		ICurrencyCode Currency { get; set; }

		decimal Amount { get; set; }
	}
}
