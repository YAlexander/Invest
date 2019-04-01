using System.Threading.Tasks;
using Orleans;

namespace Abstractions.Grains
{
	public interface IValuedPaperGrain<out T> : IGrainWithIntegerKey
	{
		T Get ();
	}
}
