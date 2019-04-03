using System;
using System.Data;
using Abstractions.Infrastructure.Database;

namespace Invest.Backend.Infrastructure.Database
{
	public class UnitOfWork : IUnitOfWork, IDisposable
	{
		public IDbConnection Connection { get; set; }

		public IDbTransaction Transaction { get; set; }


		public void Dispose()
		{
		}
	}
}
