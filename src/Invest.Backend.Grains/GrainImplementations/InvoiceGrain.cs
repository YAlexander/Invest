using Abstractions.Grains;
using Abstractions.Grains.StateModels;
using Invest.Backend.Grains.GrainImplementations.StateModels;
using Orleans;

namespace Invest.Backend.Grains.GrainImplementations
{
	public class InvoiceGrain : Grain<InvoiceState>, IInvoiceGrain
	{
		public IInvoiceState Get()
		{
			throw new System.NotImplementedException();
		}

		public IInvoiceState Update(IInvoiceState invoice)
		{
			throw new System.NotImplementedException();
		}
	}
}
