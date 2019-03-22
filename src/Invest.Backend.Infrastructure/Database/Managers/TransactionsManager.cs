using Abstractions.Infrastructure;
using Domain.Entities;

namespace Invest.Backend.Infrastructure.Database.Managers
{
	public class TransactionsManager : ITransactionsManager
	{
		private IRepository<Transaction> _transactionsRepository;

		public TransactionsManager(IRepository<Transaction> transactionsRepository)
		{
			_transactionsRepository = transactionsRepository;
		}
	}
}
