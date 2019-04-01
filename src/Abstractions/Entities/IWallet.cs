namespace Abstractions.Entities
{
	public interface IWallet : IEntity
	{
		long AccountId { get; set; }

		int CurrencyCode { get; set; }

		decimal Amount { get; set; }

		string? Description { get; set; }
 	}
}
