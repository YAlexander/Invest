using System.Data;
using System.Threading.Tasks;
using Abstractions.Infrastructure.Database;
using Domain.Entities;

namespace Invest.Backend.Infrastructure.Database.Managers
{
	public class TransactionsManager : ITransactionsManager
	{
		private readonly IRepository<Transaction> _transactionsRepository;

		public TransactionsManager(IRepository<Transaction> transactionsRepository)
		{
			_transactionsRepository = transactionsRepository;
		}

		public async Task<long?> Create(Transaction entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await _transactionsRepository.Create(entity, connection, transaction);
		}

		public async Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await _transactionsRepository.Delete(id, connection, transaction);
		}

		public async Task<Transaction> Update (Transaction entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await _transactionsRepository.Update(entity, connection, transaction);
		}
	}
}
