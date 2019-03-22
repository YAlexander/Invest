using Abstractions.Entities;

namespace Abstractions.Infrastructure
{
	public interface ITransactionsManager : IDatabaseManager<ITransaction>
	{
		
	}
}
