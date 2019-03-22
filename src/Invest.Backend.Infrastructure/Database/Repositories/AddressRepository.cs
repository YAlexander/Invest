using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Abstractions.Infrastructure;
using Dapper;
using Domain.Entities;

namespace Invest.Backend.Infrastructure.Database.Repositories
{
	public class AddressRepository : IRepository<Address>
	{
		public async Task<long?> Create (Address entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<long?>(CREATE,
				new
				{
					created = entity.Created,
					countryCode = entity.CountryCode,
					region =entity.Region,
					city = entity.City,
					street = entity.Street,
					postCode = entity.PostCode,
					zipExt = entity.ZipExt
				}, transaction);
		}

		/// <summary>
		/// Get transaction by Id
		/// </summary>
		public async Task<Address> Get (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Address>(GET_BY_ID, new { id = id }, transaction);
		}

		public async Task<IEnumerable<Address>> Get (IFilter filter, IDbConnection connection, IDbTransaction transaction)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Delete (long id, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.ExecuteAsync(MARK_AS_DELETED, new { id = id }, transaction) > 0;
		}

		public async Task<Address> Update (Address entity, IDbConnection connection, IDbTransaction transaction)
		{
			return await connection.QueryFirstOrDefaultAsync<Address>(UPDATE,
				new
				{
					id = entity.Id,
					created = entity.Created,
					countryCode = entity.CountryCode,
					region = entity.Region,
					city = entity.City,
					street = entity.Street,
					postCode = entity.PostCode,
					zipExt = entity.ZipExt
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

		private string GET_BY_ID = @"SELECT * FROM Addresses WHERE id = @id";

		private string MARK_AS_DELETED = @"UPDATE Addresses SET isDeleted = true WHERE id = @id";

		private string CREATE = @"INSERT INTO
									Addresses
									(
										id,
										created,
										isDeleted,
										countryCode,
										region,
										city,
										street,
										postCode,
										zipExt
									)
								VALUES
									(
										default,
										@created,
										false,
										@countryCode,
										@region,
										@city,
										@street,
										@postCode,
										@zipExt
									)
								RETURNING
									id;";

		private string UPDATE = @"UPDATE
									Addresses
								SET
									countryCode = @countryCode,
									region = @region,
									city = @city,
									street = @street,
									postCode = @postCode,
									zipExt = @zipExt
								WHERE
									id = @id
								RETURNING
									*;";

		private string GET_FILTERED = @"SELECT * FROM Addresses {where} ORDER BY {field} {direction} OFFSET {offset} LIMIT {limit};";
	}
}
