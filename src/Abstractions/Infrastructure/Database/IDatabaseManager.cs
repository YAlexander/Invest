using System.Data;
using System.Threading.Tasks;

namespace Abstractions.Infrastructure.Database
{
	public interface IDatabaseManager<T>
	{
		Task<T> Get(long id, IDbConnection connection, IDbTransaction transaction);
	}
}
