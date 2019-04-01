using Abstractions.Codes;

namespace Domain.Codes
{
	public class InvoiceStatusCode : TypeCodeBase<int, InvoiceStatusCode>, IInvoiceStatusCode
	{
		public InvoiceStatusCode(int code, string description) : base(code, description)
		{
		}

		public static InvoiceStatusCode PENDING { get; } = new InvoiceStatusCode(0, "Pending");

		public static InvoiceStatusCode PAID { get; } = new InvoiceStatusCode(10, "Paid");

		public static InvoiceStatusCode VOIDED { get; } = new InvoiceStatusCode(20, "Voided");

		public static InvoiceStatusCode EXPIRED { get; } = new InvoiceStatusCode(20, "Expired");
	}
}
