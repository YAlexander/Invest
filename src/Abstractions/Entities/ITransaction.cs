namespace Abstractions.Entities
{
	public interface ITransaction : IEntity
	{
		long AccountId { get; set; }

		string TransactionCode { get; set; }

		int TransactionType { get; set; }
		int StatusCode { get; set; }

		string CurrencyCode { get; set; }
		decimal Amount { get; set; }

		string Description { get; set; }
	}
}
