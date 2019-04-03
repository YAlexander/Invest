using System.Threading.Tasks;
using Orleans;

namespace Abstractions.Grains
{
	public interface IValuedPaperGrain<out T> : IGrainWithIntegerCompoundKey
	{
		T Get ();
	}
}
