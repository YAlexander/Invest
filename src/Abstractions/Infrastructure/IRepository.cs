using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Abstractions.Infrastructure
{
	public interface IRepository<T>
	{
		Task<long?> Create (T entity, IDbConnection connection, IDbTransaction transaction);

		Task<T> Get (long id, IDbConnection connection, IDbTransaction transaction);

		Task<IEnumerable<T>> Get (IFilter filter, IDbConnection connection, IDbTransaction transaction);

		Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction);

		Task<T> Update (T entity, IDbConnection connection, IDbTransaction transaction);

		//Task<object> ExecuteScalar (string query, IDbConnection connection, IDbTransaction transaction);

		//Task<IEnumerable<object>> Execute (string query, IDbConnection connection, IDbTransaction transaction);
	}
}
