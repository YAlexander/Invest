using System.Collections.Generic;
using System.Data;

namespace Abstractions.Infrastructure.Database
{
	public interface IRepository<T>
	{
		/// <summary>
		/// Create database record
		/// </summary>
		long? Create (T item, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Delete record
		/// </summary>
		bool Delete (long id, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// UpdateRecord
		/// </summary>
		T Update (long id, T item, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Get record by Id
		/// </summary>
		T Get (long id, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Get filtered list of records
		/// </summary>
		IEnumerable<T> Get (IFilter filter, IDbConnection connection, IDbTransaction transaction);

		/// <summary>
		/// Execute custom query
		/// </summary>
		object Execute (string query, IFilter filter, IDbConnection connection, IDbTransaction transaction);
	}
}
