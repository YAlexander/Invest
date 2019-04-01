using Abstractions.Entities;

namespace Abstractions.Infrastructure
{
	public interface IValuedPapersManager<T> : IDatabaseManager<T> where T : IValuedPaper
	{
	}
}
