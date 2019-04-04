using System.Threading.Tasks;
using Abstractions.Grains.StateModels;

namespace Abstractions.Infrastructure
{
	public interface IStorageService<in T> where T : IState
	{
		Task Read();
		Task Write();
	}
}
