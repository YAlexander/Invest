using System.Threading.Tasks;
using Abstractions.Grains.StateModels;
using Orleans;

namespace Abstractions.Grains
{
	public interface IInvoiceGrain : IGrainWithStringKey
	{
		IInvoiceState Get ();

		Task<IInvoiceState> Update(IInvoiceState invoice);
	}
}
