using System.Data;
using System.Threading.Tasks;
using Abstractions.Entities;

namespace Abstractions.Infrastructure.Database
{
	public interface IValuedPapersManager<T> : IDatabaseManager<T> where T : IValuedPaper
	{
		Task<string> GetType (long id, IDbConnection connection, IDbTransaction transaction);
	}
}
