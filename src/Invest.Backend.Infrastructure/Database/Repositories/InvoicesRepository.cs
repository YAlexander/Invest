using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Abstractions.Infrastructure.Database;
using Dapper;
using Domain.Entities;

namespace Invest.Backend.Infrastructure.Database.Repositories
{
	public class InvoicesRepository : IRepository<Invoice>
	{
		public async Task<long?> Create (Invoice entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<long?>(CREATE,
				new
				{
					created = entity.Created,
					sellerId = entity.SellerId,
					buyerId = entity.BuyerId,
					validTill = entity.ValidTill,
					statusCode = entity.StatusCode,
					currencyCode = entity.CurrencyCode,
					totalAmount = entity.TotalAmount,
					tax = entity.Tax,
					discount = entity.Discount
				}, transaction);
		}

		/// <summary>
		/// Get transaction by Id
		/// </summary>
		public async Task<Invoice> Get (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Invoice>(GET_BY_ID, new { id = id }, transaction);
		}

		public async Task<IEnumerable<Invoice>> Get (IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteAsync(MARK_AS_DELETED, new { id = id }, transaction) > 0;
		}

		public async Task<Invoice> Update (long id, Invoice entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Invoice>(UPDATE,
				new
				{
					id = id,
					created = entity.Created,
					sellerId = entity.SellerId,
					buyerId = entity.BuyerId,
					validTill = entity.ValidTill,
					statusCode = entity.StatusCode,
					currencyCode = entity.CurrencyCode,
					totalAmount = entity.TotalAmount,
					tax = entity.Tax,
					discount = entity.Discount
				}, transaction);
		}

		/// <summary>
		/// Execute raw sql
		/// </summary>
		/// <param name="query">SQL query</param>
		/// <param name="parameters">Query params</param>
		public async Task<dynamic> ExecuteScalar (string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteScalarAsync<dynamic>(query, parameters);
		}

		/// <summary>
		/// Execute raw sql
		/// </summary>
		/// <param name="query">SQL query</param>
		/// <param name="parameters">Query params</param>
		public async Task<IEnumerable<dynamic>> Execute (string query, IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryAsync<IEnumerable<dynamic>>(query, parameters);
		}

		private string GET_BY_ID = @"SELECT * FROM Invoices WHERE id = @id";

		private string MARK_AS_DELETED = @"UPDATE Invoices SET isDeleted = true WHERE id = @id";

		private string CREATE = @"INSERT INTO
									Invoices
									(
										id,
										created,
										isDeleted,
										sellerId,
										buyerId,
										validTill,
										statusCode,
										currencyCode,
										totalAmount,
										tax,
										discount
									)
								VALUES
									(
										default,
										@created,
										false,
										sellerId,
										buyerId,
										validTill,
										statusCode,
										currencyCode,
										totalAmount,
										tax,
										discount
									)
								RETURNING
									id;";

		private string UPDATE = @"UPDATE
									Invoices
								SET
									validTill = @validTill,
									statusCode = @statusCode,
									currencyCode = @currencyCode,
									totalAmount = @totalAmount,
									tax = @tax,
									discount = @discount
								WHERE
									id = @id
								RETURNING
									*;";

		private string GET_FILTERED = @"SELECT * FROM Invoices {where} ORDER BY {field} {direction} OFFSET {offset} LIMIT {limit};";
	}
}
