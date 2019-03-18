using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class TransactionStatusCode : TypeCodeBase<int, TransactionTypeCode>, ITransactionStatusCode
	{
		public TransactionStatusCode (int code, string description) : base(code, description)
		{
		}

		public static TransactionTypeCode PENDING { get; } = new TransactionTypeCode(10, "PENDING");

		public static TransactionTypeCode INVOICED { get; } = new TransactionTypeCode(20, "INVOICED");

		public static TransactionTypeCode COMPLETED { get; } = new TransactionTypeCode(30, "COMPLETED");

		public static TransactionTypeCode VOIDED { get; } = new TransactionTypeCode(40, "VOIDED");

		public static TransactionTypeCode FAILED { get; } = new TransactionTypeCode(50, "FAILED");
	}
}
