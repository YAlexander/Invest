using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Abstractions.Infrastructure.Database;
using Dapper;
using Domain.Entities;

namespace Invest.Backend.Infrastructure.Database.Repositories
{
	public class InvestmentsRepository : IRepository<Investment>
	{
		public async Task<long?> Create (Investment entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<long?>(CREATE,
				new
				{
					created = entity.Created,
					investmentCode = entity.InvestmentCode,
					investmentOwner = entity.InvestmentOwner,
					startDate = entity.StartDate,
					tillDate = entity.TillDate,
					investmentTypeCode = entity.InvestmentTypeCode,
					statusCode = entity.StartDate,
					title = entity.Title,
					description = entity.Description,
					currencyCode = entity.CurrencyCode,
					totalAmount = entity.TotalAmount,
					collectedAmount = entity.CollectedAmount,
					numberOfShares = entity.NumberOfShares,
					sharePrice = entity.SharePrice
				}, transaction);
		}

		/// <summary>
		/// Get transaction by Id
		/// </summary>
		public async Task<Investment> Get (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Investment>(GET_BY_ID, new { id = id }, transaction);
		}

		public async Task<IEnumerable<Investment>> Get (IDictionary<string, object> parameters, IDbConnection connection, IDbTransaction transaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteAsync(MARK_AS_DELETED, new { id = id }, transaction) > 0;
		}

		public async Task<Investment> Update (long id, Investment entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Investment>(UPDATE,
				new
				{
					id = id,
					isPublished = entity.IsPublished,
					investmentCode = entity.InvestmentCode,
					investmentOwner = entity.InvestmentOwner,
					startDate = entity.StartDate,
					tillDate = entity.TillDate,
					investmentTypeCode = entity.InvestmentTypeCode,
					statusCode = entity.StartDate,
					isVerified = entity.IsVerified,
					title = entity.Title,
					description = entity.Description,
					currencyCode = entity.CurrencyCode,
					totalAmount = entity.TotalAmount,
					collectedAmount = entity.CollectedAmount,
					numberOfShares = entity.NumberOfShares,
					sharePrice = entity.SharePrice
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

		private string GET_BY_ID = @"SELECT * FROM Investments WHERE id = @id";

		private string MARK_AS_DELETED = @"UPDATE Investments SET isDeleted = true WHERE id = @id";

		private string CREATE = @"INSERT INTO
									Investments
									(
										id,
										created,
										isDeleted,
										isPublished,
										investmentCode,
										investmentOwner,
										startDate,
										tillDate,
										investmentTypeCode,
										statusCode,
										isVerified,
										title,
										description,
										currencyCode,
										totalAmount,
										collectedAmount,
										numberOfShares,
										sharePrice
									)
								VALUES
									(
										default,
										@created,
										false,
										false,
										investmentCode,
										investmentOwner,
										startDate,
										tillDate,
										investmentTypeCode,
										statusCode,
										false,
										title,
										description,
										currencyCode,
										totalAmount,
										0,
										numberOfShares,
										sharePrice
									)
								RETURNING
									id;";

		private string UPDATE = @"UPDATE
									Investments
								SET
									isPublished = @isPublished,
									investmentCode = @investmentCode,
									investmentOwner = @investmentOwner,
									startDate = @startDate,
									tillDate = @tillDate,
									investmentTypeCode = @investmentTypeCode,
									statusCode = @statusCode,
									isVerified = @isVerified,
									title = @title,
									description = @description,
									currencyCode = @currencyCode,
									totalAmount = @totalAmount,
									collectedAmount = @collectedAmount,
									numberOfShares = @numberOfShares,
									sharePrice = @sharePrice
								WHERE
									id = @id
								RETURNING
									*;";

		private string GET_FILTERED = @"SELECT * FROM Investments {where} ORDER BY {field} {direction} OFFSET {offset} LIMIT {limit};";
	}
}
