using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class TransactionStatusCode : TypeCodeBase<int, TransactionTypeTypeCode>, ITransactionStatusCode
	{
		public TransactionStatusCode (int code, string description) : base(code, description)
		{
		}

		public static TransactionTypeTypeCode PENDING { get; } = new TransactionTypeTypeCode(10, "PENDING");

		public static TransactionTypeTypeCode INVOICED { get; } = new TransactionTypeTypeCode(20, "INVOICED");

		public static TransactionTypeTypeCode COMPLETED { get; } = new TransactionTypeTypeCode(30, "COMPLETED");

		public static TransactionTypeTypeCode VOIDED { get; } = new TransactionTypeTypeCode(40, "VOIDED");

		public static TransactionTypeTypeCode FAILED { get; } = new TransactionTypeTypeCode(50, "FAILED");
	}
}
