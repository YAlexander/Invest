using Abstractions.Codes;

namespace Domain.Codes
{
	public class PaymentServiceCode : TypeCodeBase<int, PaymentServiceCode>, IPaymentServiceCode
	{
		public PaymentServiceCode(int code, string description) : base(code, description)
		{
		}

		public static PaymentServiceCode InternalPayment = new PaymentServiceCode(10, "Transfer between accounts");

		public static PaymentServiceCode Stripe = new PaymentServiceCode(20, "Stripe");

		public static PaymentServiceCode LiqPay = new PaymentServiceCode(30, "LiqPay");

		public static PaymentServiceCode Swift = new PaymentServiceCode(40, "Swift");
	}
}
