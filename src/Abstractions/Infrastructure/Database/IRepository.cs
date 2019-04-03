using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Abstractions.Infrastructure.Database
{
	public interface IRepository<T>
	{
		/// <summary>
		/// Create database record
		/// </summary>
		Task<long?> Create (T item, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Delete record
		/// </summary>
		Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// UpdateRecord
		/// </summary>
		Task<T> Update (long id, T item, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Get record by Id
		/// </summary>
		Task<T> Get (long id, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Get filtered list of records
		/// </summary>
		Task<IEnumerable<T>> Get (IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Execute custom query
		/// </summary>
		Task<IEnumerable<dynamic>> Execute (string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Execute custom query
		/// </summary>
		Task<dynamic> ExecuteScalar (string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction);
	}
}
