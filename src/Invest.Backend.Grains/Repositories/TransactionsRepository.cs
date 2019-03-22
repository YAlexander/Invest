using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Abstractions.Infrastructure;
using Dapper;
using Domain.Entities;

namespace Invest.Backend.Grains.Repositories
{
	public class TransactionsRepository : IRepository<Transaction>
	{
		public async Task<long?> Create(Transaction entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<long?>(CREATE, 
				new
				{
					created = entity.CurrencyCode,
					accountId = entity.AccountId,
					transactionCode = entity.TransactionCode,
					transactionType = entity.TransactionType,
					statusCode = entity.StatusCode,
					currencyCode = entity.CurrencyCode,
					amount = entity.Amount,
					description = entity.Description
				}, transaction);
		}

		/// <summary>
		/// Get transaction by Id
		/// </summary>
		public async Task<Transaction> Get(long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Transaction>(GET_BY_ID, new {id = id}, transaction);
		}

		public async Task<IEnumerable<Transaction>> Get(IFilter filter, IDbConnection connection, IDbTransaction transaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete(long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteAsync(MARK_AS_DELETED, new {id = id}, transaction) > 0;
		}

		public async Task<Transaction> Update(Transaction entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Transaction>(UPDATE,
				new
				{
					id = entity.Id,
					statusCode = entity.StatusCode,
					description = entity.Description
				}, transaction);
		}

		/// <summary>
		/// Execute raw sql
		/// </summary>
		/// <param name="query">SQL query</param>
		/// <param name="parameters">Query params</param>
		public async Task<dynamic> ExecuteScalar(string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteScalarAsync<dynamic>(query, parameters);
		}

		/// <summary>
		/// Execute raw sql
		/// </summary>
		/// <param name="query">SQL query</param>
		/// <param name="parameters">Query params</param>
		public async Task<IEnumerable<dynamic>> Execute(string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryAsync<IEnumerable<dynamic>>(query, parameters);
		}

		private string GET_BY_ID = @"SELECT * FROM Transactions WHERE id = @id";

		private string MARK_AS_DELETED = @"UPDATE Transactions SET isDeleted = true WHERE id = @id";

		private string CREATE = @"INSERT INTO
									Transactions
									(
										id,
										created,
										isDeleted,
										accountId,
										transactionCode,
										transactionType,
										statusCode,
										currencyCode,
										amount,
										description
									)
								VALUES
									(
										default,
										@created,
										false,
										@accountId,
										@transactionCode,
										@transactionType,
										@statusCode,
										@currencyCode,
										@amount,
										@description
									)
								RETURNING
									id;";

		private string UPDATE = @"UPDATE
									Transactions
								SET
									statusCode = @statusCode,
									description = @description
								WHERE
									id = @id
								RETURNING
									*;";

		private string GET_FILTERED = @"SELECT * FROM Transactions {where} ORDER BY {field} {direction} OFFSET {offset} LIMIT {limit};";
	}
}
