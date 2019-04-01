using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class TransactionTypeTypeCode : TypeCodeBase<int, TransactionTypeTypeCode>, ITransactionTypeCode
	{
		public TransactionTypeTypeCode (int code, string description) : base(code, description)
		{
		}

		/// <summary>
		/// The transaction allows you to reserve the necessary amount on the payment card
		/// of the buyer to guarantee the receipt of money in the future final settlement.
		/// The term of blocking money on the card, during which the reserved amount remains
		/// inaccessible for use at other outlets or ATMs, is governed by the recommendations
		/// of the payment system
		/// </summary>
		public static TransactionTypeTypeCode AUTHORIZATION { get; } = new TransactionTypeTypeCode(10, "AUTHORIZATION");

		/// <summary>
		/// Allows you to Withdraw the previously reserved amount of money from the card and
		/// thereby complete the transaction. It is possible to write off only a part of the
		/// previously blocked amount with automatic unblocking of the balance. It is convenient
		/// to use the bundle of Authorization and Capture transactions in cases where it is not
		/// known in advance what amount of money will be required to be debited from the buyer's
		/// card, and whether
		/// </summary>
		public static TransactionTypeTypeCode CAPTURE { get; } = new TransactionTypeTypeCode(20, "CAPTURE");

		/// <summary>
		/// Allows to release the reserved amount immediately, without waiting for it to be done
		/// automatically after the end of the blocking period
		/// </summary>
		public static TransactionTypeTypeCode VOID { get; } = new TransactionTypeTypeCode(30, "VOID");

		/// <summary>
		/// Allows you to cancel a previously received payment and return the money to the buyer on
		/// the bank card with which they were once debited
		/// </summary>
		public static TransactionTypeTypeCode REFUND { get; } = new TransactionTypeTypeCode(40, "REFUND");

		/// <summary>
		/// Transaction to account for payments that have been challenged by buyers or bank card
		/// holders by contacting their issuing banks
		/// </summary>
		public static TransactionTypeTypeCode CHARGEBACK { get; } = new TransactionTypeTypeCode(50, "CHARGEBACK");

		/// <summary>
		/// The transaction allows you to make any amount of payment on any bank card
		/// </summary>
		public static TransactionTypeTypeCode PAYOUT { get; } = new TransactionTypeTypeCode(60, "PAYOUT");

		/// <summary>
		/// Uses to transfer money to a bank payment card. It is required to have a successful initial
		/// incoming payment made using the card to which the money is supposed to be sent.
		/// </summary>
		public static TransactionTypeTypeCode CREDIT { get; } = new TransactionTypeTypeCode(70, "CREDIT");

		/// <summary>
		/// Basic transaction that allows you to accept payment from the buyer in one action
		/// </summary>
		public static TransactionTypeTypeCode PAYMENT { get; } = new TransactionTypeTypeCode(80, "PAYMENT");

		/// <summary>
		/// Recurring payment
		/// </summary>
		public static TransactionTypeTypeCode RECURRING { get; } = new TransactionTypeTypeCode(90, "RECURRING");

		/// <summary>
		/// Deposit or withdrawal of funds through a paper check
		/// </summary>
		public static TransactionTypeTypeCode CHECK { get; } = new TransactionTypeTypeCode(100, "CHECK");

		/// <summary>
		/// Deposit funds to the account
		/// </summary>
		public static TransactionTypeTypeCode DEPOSIT { get; } = new TransactionTypeTypeCode(110, "DEPOSIT");

		/// <summary>
		/// Transfer funds between your accounts
		/// </summary>
		public static TransactionTypeTypeCode TRANSFER { get; } = new TransactionTypeTypeCode(120, "TRANSFER");

		/// <summary>
		/// Deposit or withdrawal of funds through an ATM
		/// </summary>
		public static TransactionTypeTypeCode ATM { get; } = new TransactionTypeTypeCode(130, "ATM");

		/// <summary>
		/// Cash in or out
		/// </summary>
		public static TransactionTypeTypeCode CASH { get; } = new TransactionTypeTypeCode(140, "CASH");

		/// <summary>
		/// Withdrawal of the funds
		/// </summary>
		public static TransactionTypeTypeCode WITHDRAWAL { get; } = new TransactionTypeTypeCode(150, "WITHDRAWAL");
	}
}
