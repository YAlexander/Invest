using Abstractions.Codes;

namespace Domain.Codes
{
	public sealed class TransactionTypeCode : TypeCodeBase<int, TransactionTypeCode>, ITransactionCode
	{
		public TransactionTypeCode (int code, string description) : base(code, description)
		{
		}

		/// <summary>
		/// The transaction allows you to reserve the necessary amount on the payment card
		/// of the buyer to guarantee the receipt of money in the future final settlement.
		/// The term of blocking money on the card, during which the reserved amount remains
		/// inaccessible for use at other outlets or ATMs, is governed by the recommendations
		/// of the payment system
		/// </summary>
		public static TransactionTypeCode AUTHORIZATION { get; } = new TransactionTypeCode(10, "AUTHORIZATION");

		/// <summary>
		/// Allows you to Withdraw the previously reserved amount of money from the card and
		/// thereby complete the transaction. It is possible to write off only a part of the
		/// previously blocked amount with automatic unblocking of the balance. It is convenient
		/// to use the bundle of Authorization and Capture transactions in cases where it is not
		/// known in advance what amount of money will be required to be debited from the buyer's
		/// card, and whether
		/// </summary>
		public static TransactionTypeCode CAPTURE { get; } = new TransactionTypeCode(20, "CAPTURE");

		/// <summary>
		/// Allows to release the reserved amount immediately, without waiting for it to be done
		/// automatically after the end of the blocking period
		/// </summary>
		public static TransactionTypeCode VOID { get; } = new TransactionTypeCode(30, "VOID");

		/// <summary>
		/// Allows you to cancel a previously received payment and return the money to the buyer on
		/// the bank card with which they were once debited
		/// </summary>
		public static TransactionTypeCode REFUND { get; } = new TransactionTypeCode(40, "REFUND");

		/// <summary>
		/// Transaction to account for payments that have been challenged by buyers or bank card
		/// holders by contacting their issuing banks
		/// </summary>
		public static TransactionTypeCode CHARGEBACK { get; } = new TransactionTypeCode(50, "CHARGEBACK");

		/// <summary>
		/// The transaction allows you to make any amount of payment on any bank card
		/// </summary>
		public static TransactionTypeCode PAYOUT { get; } = new TransactionTypeCode(60, "PAYOUT");

		/// <summary>
		/// Uses to transfer money to a bank payment card. It is required to have a successful initial
		/// incoming payment made using the card to which the money is supposed to be sent.
		/// </summary>
		public static TransactionTypeCode CREDIT { get; } = new TransactionTypeCode(70, "CREDIT");

		/// <summary>
		/// Basic transaction that allows you to accept payment from the buyer in one action
		/// </summary>
		public static TransactionTypeCode PAYMENT { get; } = new TransactionTypeCode(80, "PAYMENT");

		/// <summary>
		/// Recurring payment
		/// </summary>
		public static TransactionTypeCode RECURRING { get; } = new TransactionTypeCode(90, "RECURRING");

		/// <summary>
		/// Deposit or withdrawal of funds through a paper check
		/// </summary>
		public static TransactionTypeCode CHECK { get; } = new TransactionTypeCode(100, "CHECK");

		/// <summary>
		/// Deposit funds to the account
		/// </summary>
		public static TransactionTypeCode DEPOSIT { get; } = new TransactionTypeCode(110, "DEPOSIT");

		/// <summary>
		/// Transfer funds between your accounts
		/// </summary>
		public static TransactionTypeCode TRANSFER { get; } = new TransactionTypeCode(120, "TRANSFER");

		/// <summary>
		/// Deposit or withdrawal of funds through an ATM
		/// </summary>
		public static TransactionTypeCode ATM { get; } = new TransactionTypeCode(130, "ATM");

		/// <summary>
		/// Cash in or out
		/// </summary>
		public static TransactionTypeCode CASH { get; } = new TransactionTypeCode(140, "CASH");

		/// <summary>
		/// Withdrawal of the funds
		/// </summary>
		public static TransactionTypeCode WITHDRAWAL { get; } = new TransactionTypeCode(150, "WITHDRAWAL");
	}
}
